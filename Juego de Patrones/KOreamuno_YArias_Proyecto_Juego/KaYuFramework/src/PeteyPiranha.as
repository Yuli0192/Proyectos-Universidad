package
{
	import org.flixel.FlxSprite;
	import org.kayu.KYEnemigo;
	
	public class PeteyPiranha extends KYEnemigo
	{
		[Embed(source="../assets/img/petey_piranha.png")]
		private var pngPeteyPiranha:Class;
		
		public function PeteyPiranha(X:int, Y:int)
		{
			super(X * 50, Y * 113, pngPeteyPiranha);
			
			loadGraphic(pngPeteyPiranha, true, true, 50, 113);
						
			addAnimation("normal", [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13], 10, true);
			play("normal");
			solid = true;
			
			//Tamaño de los bordes para colicionar.
			width = 20;
			
			//Regular la posicion de la imagen en los bordes para colicionar.
			offset.x = 15;
			
			//Como configuaramos un nuevo tamaño para los bordes de la colision, hay que sumar el offset
			//al punto X del objeto.
			x = x + offset.x;
			
			setInmovil(true);
		}
	}

}