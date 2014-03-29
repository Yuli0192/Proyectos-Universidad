package
{
	import org.flixel.*;
	import org.kayu.KYBloque;
	
	/**
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class Elevador extends KYBloque
	{
		[Embed(source="../assets/img/elevator.png")]
		private var pngElevador:Class;
		
		public var moveX:Boolean = false;
		public var moveY:Boolean = false;
		private var posicionInicial:FlxPoint;
		private var posicionFinal:FlxPoint;
		
		public function Elevador(X:Number, Y:Number, Width:Number, Height:Number, Speed:int = 40)
		{
			super(X * 16, Y * 16, pngElevador);
			
			posicionInicial = new FlxPoint(X * 16, Y * 16);
			posicionFinal = new FlxPoint((X + Width) * 16, (Y + Height) * 16);
			
			if (Width > 0)
			{
				moveX = true;
				velocity.x = Speed;
			}
			
			if (Height > 0)
			{
				moveY = true;
				velocity.y = Speed;
			}
			
			immovable = true;	//We want the elevator to be "solid" and not shift during collisions
			moves = true;
			allowCollisions = FlxObject.UP;
		}
		
		override public function update():void
		{
			//	Has platform reached the end of its movement?
			
			if (moveX)
			{
				if (x > posicionFinal.x)
				{
					//	Yes, so reverse the velocity to send it back up again
					x = posicionFinal.x;
					velocity.x = -velocity.x;
				}
				else if (x < posicionInicial.x)
				{
					//	If platform has returned to the top (start position) then reverse it
					x = posicionInicial.x;
					velocity.x = -velocity.x;
				}
			}
			
			if (moveY)
			{
				if (y > posicionFinal.y)
				{
					//	Yes, so reverse the velocity to send it back up again
					y = posicionFinal.y;
					velocity.y = -velocity.y;
				}
				else if (y < posicionInicial.y)
				{
					//	If platform has returned to the top (start position) then reverse it
					y = posicionInicial.y;
					velocity.y = -velocity.y;
				}
				
			}
			
		}
	}
}