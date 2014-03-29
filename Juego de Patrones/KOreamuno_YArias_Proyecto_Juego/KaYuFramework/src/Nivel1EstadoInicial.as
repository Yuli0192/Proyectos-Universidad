package  
{
	import org.flixel.*;
	import org.flixel.plugin.photonstorm.*;
	import org.flixel.plugin.photonstorm.FX.CenterSlideFX;
	import org.flixel.plugin.photonstorm.FX.FloodFillFX;
	import org.kayu.KYNivelInicial;
	import org.kayu.KYNivel;
	
	public class Nivel1EstadoInicial extends KYNivelInicial
	{
		[Embed(source="../assets/img/portada_juego.png")]
		private var pngPortadaJuego:Class;
		
		private var objInterfazNivel:Nivel1Interfaz;
		private var objTitle:FlxSprite;
		private var objDolly:FlxSprite;
		private var objTexto:FlxText;
		private var objFloodfill:FloodFillFX;
		
		public function Nivel1EstadoInicial() 
		{
			super();
		}
		
		override public function create(objNivelActual:KYNivel):void
		{
			objInterfazNivel = Nivel1Interfaz(objNivelActual.getInterfaz());
			if (FlxG.getPlugin(FlxSpecialFX) == null)
			{
				FlxG.addPlugin(new FlxSpecialFX);
			}
			
			objFloodfill = FlxSpecialFX.floodFill();
			
			var t:FlxSprite = new FlxSprite(0, 0, pngPortadaJuego);
			
			objTitle = objFloodfill.create(t, 0, 0, t.width, t.height, 0, 1);
			objTitle.scrollFactor.x = 0;
			objTitle.scrollFactor.y = 0;
			
			objInterfazNivel = new Nivel1Interfaz();
			
			objTexto = new FlxText(0, 500, 420, "- PRESIONE CUALQUIER TECLA PARA CONTINUAR");
			objTexto.alignment = "center";
			objTexto.size = 24;
			objTexto.shadow = 0xff000000;
			objTexto.scrollFactor.x = 0;
			objTexto.scrollFactor.y = 0;
			
			objDolly = new FlxSprite(160, 170);
			objDolly.facing = FlxObject.RIGHT;
			
			FlxG.worldBounds = new FlxRect(0, 0, objInterfazNivel.getAnchoNivel(), objInterfazNivel.getLargoNivel());
			FlxG.camera.setBounds(0, 0, objInterfazNivel.getAnchoNivel(), objInterfazNivel.getLargoNivel());
			FlxG.camera.follow(objDolly, FlxCamera.STYLE_PLATFORMER);
			
			FlxG.playMusic(titleMusicMP3, 1);
			
			objFloodfill.start();
			
			add(objInterfazNivel);
			add(objInterfazNivel.getGroupGoombas());
			add(objInterfazNivel.getGroupPeteyPiranhas());
			add(objInterfazNivel.getGroupMonedas());
			add(objTitle);
			add(objTexto);
		}
		
		override public function update():void
		{
			super.update();
			
			if (FlxG.keys.any())
			{
				FlxG.fade(0xff000000, 2, cambiarEstado);
				FlxG.music.fadeOut(2);
			}
			
			if (objDolly.facing == FlxObject.RIGHT)
			{
				objDolly.x++;
				
				if (objDolly.x >= (objInterfazNivel.getAnchoNivel() - 160))
				{ 
					objDolly.facing = FlxObject.LEFT;
				}
			}
			else if (objDolly.facing == FlxObject.LEFT)
			{
				objDolly.x--;
				
				if (objDolly.x <= 0)
				{
					objDolly.facing = FlxObject.RIGHT;
				}
			}
		}
		
		override public function cambiarEstado():void
		{
			FlxG.switchState(new Nivel1EstadoJugando());
		}
		
		override public function destroy():void
		{
			FlxSpecialFX.clear();
			
			super.destroy();
		}
		
	}

}