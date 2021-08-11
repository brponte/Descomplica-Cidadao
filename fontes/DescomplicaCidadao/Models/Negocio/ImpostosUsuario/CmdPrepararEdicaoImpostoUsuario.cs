using DescomplicaCidadao.Models.Data;
using DescomplicaCidadao.Models.DB;
using DescomplicaCidadao.Properties;
using System;

namespace DescomplicaCidadao.Models.Negocio.ImpostosUsuario
{
	public class CmdPrepararEdicaoImpostoUsuario
	{
		//----------------------------------------------------------------------
		#region variáveis
		//----------------------------------------------------------------------
		public ImpostoUsuario		ImpostoUsuario			{ get; private set; }
		public string				MsgErro					{ get; private set; }

		private int m_id;
		//----------------------------------------------------------------------
		#endregion
		//----------------------------------------------------------------------
		public CmdPrepararEdicaoImpostoUsuario( int id )
		{
			m_id = id;
		}

		//----------------------------------------------------------------------
		#region funções public
		//----------------------------------------------------------------------
		public void execCmd( DBConexao db )
		{
			if ( m_id == ImpostoUsuario.ID_IMPOSTO_USUARIO_INVALIDO )
			{
				ImpostoUsuario = new ImpostoUsuario();
				//Advertencia.DataAdvertencia = DateTime.Today;
				//Advertencia.DataLimiteConfirmacao = DateTime.Today.AddDays( Const.DIAS_DATA_LIMITE );
			}
			else
			{
				ImpostoUsuario umImpostoUsuario;
				if(ImpostoUsuarioDB.lerImpostoUsuario( db, m_id, out umImpostoUsuario) )
				{
					if(umImpostoUsuario == null )
					{
						MsgErro = Mensagens.ERR_IMPOSTO_USUARIO_NAO_ENCONTRADO;
						return;
					}
					ImpostoUsuario = umImpostoUsuario;
				}
				else
				{
					MsgErro = Mensagens.EXCEPTION_MSG_ERRO;
					return;
				}
			}
			ImpostoUsuario.ArrTipoImposto = TipoImpostoDB.lerTiposImposto(db);
			if (ImpostoUsuario.ArrTipoImposto == null)
			{
				MsgErro = Mensagens.EXCEPTION_MSG_ERRO;
				return;
			}
		}
		//----------------------------------------------------------------------
		#endregion
		//----------------------------------------------------------------------
	}
}