package org.kayu 
{
	/**
	 * ...
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class KYConfigJuego 
	{
		private var _anchoPantalla:Number;
		private var _largoPantalla:Number;
		private var _zoom:uint;
		private var _debug:Boolean;
		private static var _objConfig:KYConfigJuego;
		
		public function KYConfigJuego(obligarSin:ObligarSingleton) 
		{
			if (obligarSin != null) {
				setAnchoPantalla(1200);
				setLargoPantalla(600);
				setZoom(1);
				setDebug(false);
			}else {
				throw new Error("KYConfigJuego es un Singleton. Para acceder a una instancia hacedlo mediante KYConfigJuego.getInstancia()");
				return;
			}
		}
		
		/**
		 * Método estatico que se encarga de crear la instancia del Singleton.
		 * @return
		 */
		public static function getInstancia():KYConfigJuego {
			if (_objConfig == null) {
				_objConfig = new KYConfigJuego(new ObligarSingleton());
			}
			return _objConfig;
		}
		
		public function getAnchoPantalla():Number 
		{
			return _anchoPantalla;
		}
		
		public function setAnchoPantalla(value:Number):void 
		{
			_anchoPantalla = value;
		}
		
		public function getLargoPantalla():Number 
		{
			return _largoPantalla;
		}
		
		public function setLargoPantalla(value:Number):void 
		{
			_largoPantalla = value;
		}
		
		public function getZoom():uint 
		{
			return _zoom;
		}
		
		public function setZoom(value:uint):void 
		{
			_zoom = value;
		}
		
		public function getDebug():Boolean 
		{
			return _debug;
		}
		
		public function setDebug(value:Boolean):void 
		{
			_debug = value;
		}
	}
}

class ObligarSingleton{}