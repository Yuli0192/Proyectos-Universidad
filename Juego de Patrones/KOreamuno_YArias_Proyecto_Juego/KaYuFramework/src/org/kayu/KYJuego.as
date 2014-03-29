package org.kayu 
{	
	import org.flixel.FlxG;
	import org.flixel.FlxGame;
	/**
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class KYJuego extends FlxGame
	{
		private var _debug:Boolean;
		private var _nivelActual:KYNivel;
		
		public function KYJuego() 
		{
			super.setInit(KYConfigJuego.getInstancia());
			setDebug(KYConfigJuego.getInstancia().getDebug());
		}
		
		public function iniciarJuego():void {
			super.startGame(getNivelActual());
		}
		
		public function getNivelActual():KYNivel 
		{
			return _nivelActual;
		}
		
		public function setNivelActual(value:KYNivel):void 
		{
			_nivelActual = value;
			_iState = getNivelActual().getEstadoActual();
		}
		
		public function getDebug():Boolean 
		{
			return FlxG.visualDebug;
		}
		
		public function setDebug(value:Boolean):void 
		{
			FlxG.visualDebug = value;
		}		
	}

}