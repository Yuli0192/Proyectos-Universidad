package org.kayu 
{
	import org.flixel.FlxBasic;
	import org.flixel.FlxGroup;
	/**
	 * @author Yuliana Arias Meza, Katherine Oreamuno
	 */
	public class KYNivelInterfaz extends FlxGroup 
	{
		private var _anchoNivel:int;
		private var _largoNivel:int;
		
		public function KYNivelInterfaz() 
		{
			super();
		}
		
		public function agregarElemento(obj:FlxBasic):void{
			add(obj);
		}
		
		public function getCantElementos():Number {
			return length;
		}
		
		public function getLargoNivel():int 
		{
			return _largoNivel;
		}
		
		public function setLargoNivel(value:int):void 
		{
			_largoNivel = value;
		}
		
		public function getAnchoNivel():int 
		{
			return _anchoNivel;
		}
		
		public function setAnchoNivel(value:int):void 
		{
			_anchoNivel = value;
		}
	}

}