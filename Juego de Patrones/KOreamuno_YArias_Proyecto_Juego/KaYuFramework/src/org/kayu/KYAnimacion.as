package org.kayu 
{
	import flash.events.KeyboardEvent;
	import org.flixel.FlxSprite;
	
	/**
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class KYAnimacion extends FlxSprite
	{
		public function KYAnimacion(px:Number = 0, py:Number = 0, pimagen:Class = null) 
		{
			super(px, py, pimagen);
		}
		
		public function setX(value:Number):void {
			x = value;
		}
		
		public function getX():Number {
			return x;
		}
		
		public function setY(value:Number): void {
			y = value;
		}
		
		public function getY():Number {
			return y;
		}
		
		
		
		public function setImagen(value:Class):void {
			loadGraphic(value);
		}
	}
}