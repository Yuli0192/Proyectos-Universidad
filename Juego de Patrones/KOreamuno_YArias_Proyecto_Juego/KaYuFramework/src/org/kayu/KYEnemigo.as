package org.kayu 
{
	import org.flixel.FlxObject;
	/**
	 * ...
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class KYEnemigo extends KYAnimacion
	{
		private var _nombre:String;
		private var _vida:Number;
		private var _contadorX:Number;
		private var _inmovil:Boolean;
		
		public function KYEnemigo(px:Number = 0, py:Number = 0, pimagen:Class = null) 
		{
			super(px, py, pimagen);
			setContadorX(0);
		}
		
		public function getVida():Number 
		{
			return _vida;
		}
		
		public function setVida(value:Number):void 
		{
			_vida = value;
		}
		
		public function getNombre():String 
		{
			return _nombre;
		}
		
		public function setNombre(value:String):void 
		{
			_nombre = value;
		}
		
		public function setContadorX(value:Number):void 
		{
			_contadorX = value;
		}
		
		public function getContadorX():Number 
		{
			return _contadorX;
		}		
		
		override public function update():void
		{
			if (!getInmovil()) {
				if (getContadorX() < 100) {
					x++;
					setContadorX(getContadorX() + 1);
					facing = FlxObject.RIGHT;
				}else {
					if (getContadorX() < 200) {
						x--;
						setContadorX(getContadorX() + 1);
						facing = FlxObject.LEFT;
					}else {
						setContadorX(0);
					}
				}
			}
		}	
		
		public function getInmovil():Boolean 
		{
			return _inmovil;
		}
		
		public function setInmovil(value:Boolean):void 
		{
			_inmovil = value;
		}
	}

}