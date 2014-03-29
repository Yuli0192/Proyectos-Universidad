package
{
	import org.flixel.*;
	import org.flixel.plugin.photonstorm.*;
	import com.greensock.TweenMax;
	import org.kayu.KYEnemigo;

	/**
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class Goomba extends KYEnemigo
	{
		[Embed(source="../assets/img/goomba.png")]
		private var pngGoomba:Class;
		private var posicionGoomba:FlxPoint;
		
		public function Goomba(x:Number, y:Number)
		{
			//	Como Mario extiende de FlxSprite se necesita pasar la posicion X y Y de Goomba a la clase padre.
			super(x * 40, y * 40);
			
			posicionGoomba = new FlxPoint(x, y);
			
			//	Se carga la imagen de mario en el Sprite.
			loadGraphic(pngGoomba, true, true, 40, 40, true);
			
			//Las animaciones de Mario
			addAnimation("normal", [1, 2, 3, 4, 5, 6, 7, 8, 9], 5, true);
			play("normal");
			
			//	Enable the Controls plugin - you only need do this once (unless you destroy the plugin)
			if (FlxG.getPlugin(FlxControl) == null)
			{
				FlxG.addPlugin(new FlxControl);
			}
			
			//	Add this sprite to the FlxControl plugin and tell it we want the sprite to accelerate and decelerate smoothly
			FlxControl.create(this, FlxControlHandler.MOVEMENT_ACCELERATES, FlxControlHandler.STOPPING_DECELERATES, 1, true, false);
			
			//	Because we are using the MOVEMENT_ACCELERATES type the first value is the acceleration speed of the sprite
			//	Think of it as the time it takes to reach maximum velocity. A value of 100 means it would take 1 second. A value of 400 means it would take 0.25 of a second.
			FlxControl.player1.setMovementSpeed(450, 100, 1000, 1000, 1000, 100);
			
			//	Set a downward gravity of 400px/sec
			FlxControl.player1.setGravity(0, 1700);
			
			//	By default the sprite is facing to the right.
			//	Changing this tells Flixel to flip the sprite frames to show the left-facing ones instead.
			facing = FlxObject.RIGHT;
			
			setInmovil(false);
		}
		
		//	We don't actually kill the player at all, we just reset them
		public function restart():void
		{
			if (angle == 180) {
				angle = 0;
			}
			reset(posicionGoomba.x, posicionGoomba.y);
		}
		
		override public function kill():void
		{
			frame = 1;
			
			velocity.x = 0;
			velocity.y = 0;
			
			angle = 180;
			
			TweenMax.to(this, 1.5, { bezier: [ {x:"64", y:"-64"}, {x:"80", y:"200"} ], onComplete: restart } );
		}	
	}
}