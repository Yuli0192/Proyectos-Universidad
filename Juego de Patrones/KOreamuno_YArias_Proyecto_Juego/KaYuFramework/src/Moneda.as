package
{
	import org.flixel.FlxSprite;
	import org.kayu.KYConsumible;
	
	/**
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class Moneda extends KYConsumible
	{
		[Embed(source="../assets/img/moneda.png")]
		private var pngMoneda:Class;
		
		public function Moneda(X:int, Y:int)
		{
			super(X * 34, Y * 30, pngMoneda);
			
			loadGraphic(pngMoneda, true, true, 34, 30);
						
			addAnimation("normal", [0, 1, 2, 3], 6, true);
			play("normal");
			solid = true;
		}
	
	}

}