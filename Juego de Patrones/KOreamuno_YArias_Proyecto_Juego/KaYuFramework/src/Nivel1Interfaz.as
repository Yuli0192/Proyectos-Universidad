package  
{
	import org.flixel.*;
	import org.kayu.KYNivelInterfaz;

	public class Nivel1Interfaz extends KYNivelInterfaz
	{
		[Embed(source="../assets/csv/mapCSV_Nivel1_Nubes.csv", mimeType="application/octet-stream")]
		public var csvNubes:Class;
		
		[Embed(source="../assets/csv/mapCSV_Nivel1_Map.csv", mimeType="application/octet-stream")]
		public var csvMapNivel:Class;
				
		[Embed(source="../assets/csv/mapCSV_Nivel1_Monedas.csv", mimeType="application/octet-stream")]
		public var csvMonedas:Class;
		
		[Embed(source="../assets/csv/mapCSV_Nivel1_Plantas.csv", mimeType="application/octet-stream")]
		public var csvPlantas:Class;
		
		[Embed(source="../assets/csv/mapCSV_Nivel1_Goomba.csv", mimeType="application/octet-stream")]
		public var csvGoombas:Class;
		
		[Embed(source="../assets/csv/mapCSV_Nivel1_Background.csv", mimeType="application/octet-stream")]
		public var csvFondoNivel:Class;
		
		[Embed(source="../assets/img/nubes.png")]
		public var pngNubes:Class;
		
		[Embed(source="../assets/img/tiles_nivel.png")]
		public var pngMapNivel:Class;
		
		[Embed(source="../assets/img/goomba.png")]
		public var pngGoomba:Class;
				
		[Embed(source="../assets/img/moneda.png")]
		public var pngMonedas:Class;
		
		[Embed(source="../assets/img/petey_piranha.png")]
		public var pngPeteyPiranhas:Class;
		
		[Embed(source="../assets/img/background.png")]
		public var pngFondoNivel:Class;
		
		private var objElevador1:Elevador;
		private var objElevador2:Elevador;
		
		public var mapNubes:FlxTilemap;
		public var mapNivel:FlxTilemap;
		public var mapFondoNivel:FlxTilemap;
		private var _groupPeteyPiranhas:FlxGroup;
		private var _groupGoombas:FlxGroup;
		private var _groupMonedas:FlxGroup;
		private var _totalMonedas:int;
				
		public function Nivel1Interfaz() 
		{
			super();
			
			mapNubes = new FlxTilemap;
			mapNubes.loadMap(new csvNubes, pngNubes, 64, 64);
			mapNubes.setTileProperties(0, FlxObject.NONE);
			mapNubes.setTileProperties(1, FlxObject.NONE);
			mapNubes.setTileProperties(2, FlxObject.NONE);
			mapNubes.scrollFactor.x = 0.9;
			
			mapFondoNivel = new FlxTilemap;
			mapFondoNivel.loadMap(new csvFondoNivel, pngFondoNivel, 100, 100);
			mapFondoNivel.setTileProperties(1, FlxObject.NONE);
			
			mapNivel = new FlxTilemap;
			mapNivel.loadMap(new csvMapNivel, pngMapNivel, 50, 50);
						
			setAnchoNivel(mapNivel.width);
			setLargoNivel(mapNivel.height);
			
			objElevador1 = new Elevador(26, 6, 10, 0);
			objElevador2 = new Elevador(82, 6, 0, 7);
			
			add(mapFondoNivel);
			add(mapNubes);
			add(mapNivel);
			add(objElevador1);
			add(objElevador2);
			
			agregarPeteyPiranhasDelCSV();
			agregarGoombasDelCSV();
			agregarMonedasDelCSV();
		}
		
		public function openExit():void
		{
			//	Removes the two blocking tiles on the right of the map and sets them to nothing, so the player can walk through
			mapNivel.setTile(98, 16, 0, true);
			mapNivel.setTile(99, 16, 0, true);
		}
		
		private function agregarMonedasDelCSV():void
		{
			var mapMonedas:FlxTilemap = new FlxTilemap();
			
			mapMonedas.loadMap(new csvMonedas, pngMonedas, 34, 30);
			
			setGroupMonedas(new FlxGroup());
			
			for (var ty:int = 0; ty < mapMonedas.heightInTiles; ty++)
			{
				for (var tx:int = 0; tx < mapMonedas.widthInTiles; tx++)
				{
					if (mapMonedas.getTile(tx, ty) == 1)
					{
						getGroupMonedas().add(new Moneda(tx, ty));
						setTotalMonedas(getTotalMonedas() + 1);
					}
				}
			}
		}		
		
		private function agregarPeteyPiranhasDelCSV():void
		{
			var mapPeteyPiranhas:FlxTilemap = new FlxTilemap();
			
			mapPeteyPiranhas.loadMap(new csvPlantas, pngPeteyPiranhas, 50, 113);
			
			setGroupPeteyPiranhas(new FlxGroup());
			
			for (var ty:int = 0; ty < mapPeteyPiranhas.heightInTiles; ty++)
			{
				for (var tx:int = 0; tx < mapPeteyPiranhas.widthInTiles; tx++)
				{
					if (mapPeteyPiranhas.getTile(tx, ty) == 1)
					{
						getGroupPeteyPiranhas().add(new PeteyPiranha(tx, ty));
					}
				}
			}
		}
		
		private function agregarGoombasDelCSV():void
		{
			var mapGoombas:FlxTilemap = new FlxTilemap();
			
			mapGoombas.loadMap(new csvGoombas, pngGoomba, 40, 40);
			
			setGroupGoombas(new FlxGroup());
			
			for (var ty:int = 0; ty < mapGoombas.heightInTiles; ty++)
			{
				for (var tx:int = 0; tx < mapGoombas.widthInTiles; tx++)
				{
					if (mapGoombas.getTile(tx, ty) == 1)
					{
						getGroupGoombas().add(new Goomba(tx, ty));
					}
				}
			}
		}
		
		public function getTotalMonedas():int 
		{
			return _totalMonedas;
		}
		
		public function setTotalMonedas(value:int):void 
		{
			_totalMonedas = value;
		}
		
		public function getGroupMonedas():FlxGroup 
		{
			return _groupMonedas;
		}
		
		public function setGroupMonedas(value:FlxGroup):void 
		{
			_groupMonedas = value;
		}
		
		public function getGroupPeteyPiranhas():FlxGroup 
		{
			return _groupPeteyPiranhas;
		}
		
		public function setGroupPeteyPiranhas(value:FlxGroup):void 
		{
			_groupPeteyPiranhas = value;
		}
		
		public function getGroupGoombas():FlxGroup 
		{
			return _groupGoombas;
		}
		
		public function setGroupGoombas(value:FlxGroup):void 
		{
			_groupGoombas = value;
		}
	}
}