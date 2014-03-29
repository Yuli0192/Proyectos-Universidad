package org.kayu 
{
	import org.flixel.FlxSound;
	/**
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class KYJugador extends KYAnimacion
	{
		private var _brincandoFX:FlxSound;
		private var _caminandoFX:FlxSound;
		
		public function KYJugador(x:Number, y:Number)
		{
			//	Como KYJuagador extiende de KYAnimacion se necesita pasar la posicion X y Y de Mario a la clase padre.
			super(x, y);
		}
		
		public function restart():void{}
		
		public function getCaminandoFX():FlxSound 
		{
			return _caminandoFX;
		}
		
		public function setCaminandoFX(value:FlxSound):void 
		{
			_caminandoFX = value;
		}
		
		public function getBrincandoFX():FlxSound 
		{
			return _brincandoFX;
		}
		
		public function setBrincandoFX(value:FlxSound):void 
		{
			_brincandoFX = value;
		}
		
		public function getWidth():Number {
			return width;
		}
		
		public function setWidth(pwidth:Number):void {
			width = pwidth;
		}
		
		public function getHeight():Number {
			return height;
		}
		
		public function setHeight(pheight:Number):void {
			height = pheight;
		}
	}

}