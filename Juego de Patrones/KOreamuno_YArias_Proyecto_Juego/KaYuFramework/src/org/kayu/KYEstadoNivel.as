package org.kayu 
{
	import org.flixel.FlxState;
	
	/**
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class KYEstadoNivel extends FlxState

	{		
		public function KYEstadoNivel() 
		{
			super();
		}
		
		override public function create(objNivelActual:KYNivel):void { }
		
		public function cambiarEstado():void { }
		
	}

}