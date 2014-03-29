package org.kayu 
{
	/**
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class KYNivel 
	{
		private var _estadoActual:KYEstadoNivel;
		private var _interfaz:KYNivelInterfaz;
		
		public function KYNivel(pestadoActual:KYEstadoNivel, pinterfaz:KYNivelInterfaz) 
		{
			setEstadoActual(pestadoActual);
			setInterfaz(pinterfaz);
		}
		
		public function getEstadoActual():KYEstadoNivel 
		{
			return _estadoActual;
		}
		
		public function setEstadoActual(value:KYEstadoNivel):void 
		{
			_estadoActual = value;
		}
		
		public function getInterfaz():KYNivelInterfaz 
		{
			return _interfaz;
		}
		
		public function setInterfaz(value:KYNivelInterfaz):void 
		{
			_interfaz = value;
		}
	}

}