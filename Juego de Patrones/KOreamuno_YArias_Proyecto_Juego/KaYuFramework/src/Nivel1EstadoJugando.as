package  
{
	import org.flixel.*;
	import org.kayu.KYNivelJugando;
	import org.kayu.KYNivel;
	
	/**
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class Nivel1EstadoJugando extends KYNivelJugando
	{
		private var objMario:Mario;
		private var objTextPuntuacion:FlxText;
		private var starFX:FlxSound;
		private var _objInterfaz:Nivel1Interfaz;
		
		public function Nivel1EstadoJugando() 
		{}
		
		override public function create(objNivelActual:KYNivel):void
		{
			setObjInterfaz(Nivel1Interfaz(objNivelActual.getInterfaz()));
			starFX = new FlxSound();
			starFX.loadEmbedded(starSFX);
			
			objMario = new Mario(4, 120);
			
			objTextPuntuacion = new FlxText(0, 0, 100);
			objTextPuntuacion.color = 0xff000000;
			objTextPuntuacion.shadow = 0xff000000;
			objTextPuntuacion.scrollFactor.x = 0;
			objTextPuntuacion.scrollFactor.y = 0;
			objTextPuntuacion.size = 24;
			objTextPuntuacion.text = "0 / " + getObjInterfaz().getTotalMonedas();
			
			add(getObjInterfaz());
			add(objMario);
			add(getObjInterfaz().getGroupGoombas());
			add(getObjInterfaz().getGroupMonedas());
			add(getObjInterfaz().getGroupPeteyPiranhas());
			add(objTextPuntuacion);
			
			//	Tell flixel how big our game world is
			FlxG.worldBounds = new FlxRect(0, 0, getObjInterfaz().getAnchoNivel(), getObjInterfaz().getLargoNivel());
			
			//	Don't let the camera wander off the edges of the map
			FlxG.camera.setBounds(0, 0, getObjInterfaz().getAnchoNivel(), getObjInterfaz().getLargoNivel());
			
			//	The camera will follow the player
			FlxG.camera.follow(objMario, FlxCamera.STYLE_LOCKON);
			
			FlxG.playMusic(level1MusicMP3, 0.5);
		}
		
		override public function update():void
		{
			super.update();
			
			FlxG.overlap(objMario, getObjInterfaz().getGroupPeteyPiranhas(), colisionPeteyPiranha);
			FlxG.overlap(objMario, getObjInterfaz().getGroupGoombas(), colisionGoomba);
			FlxG.collide(getObjInterfaz().getGroupGoombas(), getObjInterfaz());
			FlxG.collide(objMario, getObjInterfaz());
			FlxG.overlap(objMario, getObjInterfaz().getGroupMonedas(), colisionMoneda);
			
		}
		
		override public function cambiarEstado():void
		{
			FlxG.switchState(new Nivel1EstadoInicial());
		}
		
		private function colisionGoomba(objColision:FlxObject, objGooba:FlxObject):void
		{
			Goomba(objGooba).kill();
		}
		
		private function colisionPeteyPiranha(objColision:FlxObject, objPeteyPiranha:FlxObject):void
		{
			Mario(objColision).kill();
		}
		
		private function colisionMoneda(objColision:FlxObject, objMoneda:FlxObject):void
		{
			objMoneda.kill();
			
			FlxG.score += 1;
			
			starFX.play(true);
			
			if (FlxG.score == getObjInterfaz().getTotalMonedas())
			{
				//	Opens the exit at the end of the level
				objTextPuntuacion.text = FlxG.score.toString() + " / " + getObjInterfaz().getTotalMonedas() + " EXIT OPEN!";
				cambiarEstado();
			}
			else
			{
				objTextPuntuacion.text = FlxG.score.toString() + " / " + getObjInterfaz().getTotalMonedas();
			}
		}
		
		public function getObjInterfaz():Nivel1Interfaz 
		{
			return _objInterfaz;
		}
		
		public function setObjInterfaz(value:Nivel1Interfaz):void 
		{
			_objInterfaz = value;
		}
		
	}

}