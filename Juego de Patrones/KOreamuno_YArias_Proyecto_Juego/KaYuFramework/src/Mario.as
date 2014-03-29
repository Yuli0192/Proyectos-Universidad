package
{
	import org.flixel.*;
	import org.flixel.plugin.photonstorm.*;
	import com.greensock.TweenMax;
	import org.kayu.KYJugador;

	/**
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class Mario extends KYJugador
	{
		[Embed(source="../assets/img/mario.png")]
		private var pngMario:Class;
		private var posicionMario:FlxPoint;
		
		public function Mario(x:Number, y:Number)
		{
			//	Como Mario extiende de FlxSprite se necesita pasar la posicion X y Y de Mario a la clase padre.
			super(x, y);
			
			posicionMario = new FlxPoint(x, y);
			
			setBrincandoFX(new FlxSound());
			getBrincandoFX().loadEmbedded(jumpSFX);
			
			setCaminandoFX(new FlxSound());
			getCaminandoFX().loadEmbedded(walkSFX, true);
			
			//	Se carga la imagen de mario en el Sprite.
			loadGraphic(pngMario, true, true, 50, 50, true);
			
			//Tamaño de los bordes para colicionar.
			setWidth(30);
			setHeight(40);
			
			//Regular la posicion de la imagen en los bordes para colicionar.
			offset.x = 10;
			offset.y = 2;
			
			//Las animaciones de Mario
			addAnimation("normal", [0,1,2,3], 1, true);
			addAnimation("caminando", [50,51,52,53,54,55,56,57], 20, true);
			addAnimation("brincando", [60,61,62,63], 1, false);
			addAnimation("golpe", [100,101,102,103], 20, true);
			
			//	Enable the Controls plugin - you only need do this once (unless you destroy the plugin)
			if (FlxG.getPlugin(FlxControl) == null)
			{
				FlxG.addPlugin(new FlxControl);
			}
			
			//	Add this sprite to the FlxControl plugin and tell it we want the sprite to accelerate and decelerate smoothly
			FlxControl.create(this, FlxControlHandler.MOVEMENT_ACCELERATES, FlxControlHandler.STOPPING_DECELERATES, 1, true, false);
			
			//	Sprite will be controlled with the left and right cursor keys
			FlxControl.player1.setCursorControl(false, false, true, true);
			
			//	And SPACE BAR will make them brincando up to a maximum of 200 pixels (per second), only when touching the FLOOR
			FlxControl.player1.setJumpButton("SPACE", FlxControlHandler.KEYMODE_PRESSED, 1200, FlxObject.FLOOR, 1250, 1200);
			
			//	Because we are using the MOVEMENT_ACCELERATES type the first value is the acceleration speed of the sprite
			//	Think of it as the time it takes to reach maximum velocity. A value of 100 means it would take 1 second. A value of 400 means it would take 0.25 of a second.
			FlxControl.player1.setMovementSpeed(400, 100, 1000, 1000, 1000, 100);
			
			//	Set a downward gravity of 400px/sec
			FlxControl.player1.setGravity(0, 1500);
			
			FlxControl.player1.setSounds(getBrincandoFX(), null, getCaminandoFX());
			
			//	By default the sprite is facing to the right.
			//	Changing this tells Flixel to flip the sprite frames to show the left-facing ones instead.
			facing = FlxObject.RIGHT;
		}
		
		//	We don't actually kill the player at all, we just reset them
		override public function restart():void
		{
			if (angle == 180) {
				angle = 0;
			}
			reset(posicionMario.x, posicionMario.y);
		}
		
		override public function kill():void
		{
			play('golpe');
			FlxG.play(catty2SFX, 0.5, false, true);
			
			frame = 1;
			
			velocity.x = 0;
			velocity.y = 0;
			
			angle = 180;
			
			TweenMax.to(this, 1.5, { bezier: [ {x:"64", y:"-64"}, {x:"80", y:"200"} ], onComplete: restart } );
		}
		
		override public function update():void
		{
			super.update();
			
			if (x < 0)
			{
				x = 0;
			}
			
			//Cuando el golpea el agua?
			if (y > 920)
			{
				restart();
			}
			
			if (touching == FlxObject.FLOOR)
			{
				if (velocity.x != 0)
				{
					play("caminando");
				}
				else
				{
					play("normal");
				}
			}
			else if (velocity.y < 0)
			{
				play("brincando");
			}
		}
		
	}
}