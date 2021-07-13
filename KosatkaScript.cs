using GTA;
using GTA.Math;
using GTA.Native;
using iFruitAddon2;
using NativeUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CayoPericoHeistInSP
{
  public class KosatkaScript : Script
  {
    public string HeistLeaderChar;
    public string HeistLeadername;
    private CustomiFruit ifruit;
    public BlipColor SubmarineBlipColor;
    public Color SubmarineMarkerColor;
    public string MarkerColorString;
    public bool EnableMarkers;
    public bool HoldToEnterInterior;
    public List<Prop> Chests;
    public bool GotScreens;
    public int SubPurchased;
    public int EnterStatus;
    public int FlagID;
    public int SonarStation;
    public int GuidedMissiles;
    public int WeaponsUpgrade;
    public int SeaSparrowUpgrade;
    public int AvisaUpgrade;
    public int ToreadorUpgrade;
    public float KosatkaCost;
    public float ColorCost;
    public float FlagCost;
    public float SonarCost;
    public float GuidedMissileCost;
    public float WeaponWorkshopCost;
    public float SeaSparrowCost;
    public float AvisaCost;
    public float ToreadorCost;
    public int SubType;
    public bool SonarActive;
    public Blip PurchaseMarkerBlip;
    public Vector3 PurchaseMarker;
    private MenuPool modMenuPool;
    private UIMenu mainMenu;
    private UIMenu Options;
    private ScriptSettings Config;
    public Vector3 Spawn;
    public Vehicle Kosatka;
    public bool Created;
    public int Weapons;
    public int Livery;
    public Vector3 MOCPosSave;
    public Blip MOCBlip;
    public float X;
    public float Y;
    public int Tintscount;
    public float Z;
    public Vector3 ExitMoc;
    public bool IsInInterior;
    public Vector3 Gunlockerpos;
    public string VehicleToUse;
    private MenuPool modMenuPool2;
    private UIMenu mainMenu2;
    private UIMenu mainMenu3;
    private UIMenu Options2;
    public Camera EnterExitCam;
    public Vector3 CabOptions;
    public SaveCar SaveLoad;
    public SaveCar WheelsSaveLoad;
    public Vehicle VehicleinCargoBay;
    public VehicleColor CabPrimary;
    public VehicleColor CabSecondary;
    public VehicleColor TrailerPrimary;
    public VehicleColor TrailerSecondary;
    public bool SpawnedFromBunker;
    public bool ReadIni;
    public bool ResetMoc;
    public Vector3 Strawberry;
    public Vector3 Paleto;
    public Vector3 RatonCanyon;
    public Vector3 Chumash;
    public Vector3 GrapeSeed;
    public Vector3 GSD1;
    public Vector3 GSD2;
    public Vector3 GSD3;
    public Vector3 GSD4;
    public Vector3 GSD5;
    public Vector3 GSD6;
    public bool IsInDroneMode;
    public Vehicle Drone;
    public UIMenu DroneMenu;
    public Camera DroneCam;
    public Vector3 DroneCamPos;
    public Vector3 LastKnownPos;
    public int DroneInUse;
    public Vector3 SamLoc;
    public bool IsUsingSam;
    public int MissilesFired;
    public bool CanFire;
    public Prop DroneProp;
    public bool DronePropEnabled;
    public float VHeading;
    public bool SavedVehicle;
    public int BatteryPercent;
    public Prop Chair1;
    public Prop Chair2;
    public Prop Chair3;
    public Prop Chair4;
    public Prop Chair5;
    public Prop Chair6;
    public Prop Chair7;
    public Prop Chair8;
    public Prop Chair9;
    public Prop Chair10;
    public Prop Console3;
    public Prop PeriscopeProp;
    public bool PlayingConsoleIdleAnim_1;
    public bool PlayingConsoleIdleAnim_2;
    public bool PlayingConsoleIdleAnim_8;
    public int Chair1_Scene;
    public int Chair2_Scene;
    public int Chair8_Scene;
    public VehicleColor SeaSparrowPrimaryColor;
    public VehicleColor SeaSparrowSecondaryColor;
    public VehicleColor AvisaPrimaryColor;
    public VehicleColor AvisaSecondaryColor;
    public VehicleColor ToreadorPrimaryColor;
    public VehicleColor ToreadorSecondaryColor;
    public string MOCPosSavestring;
    public int Timer;
    public bool DisableTresurechests;
    public int SeasparrowWeapons;
    public bool ShowTreasureCollectioninSub;
    public UIResRectangle RectangleGUI;
    public List<UIMenu> GUIMenus;
    public bool toggledLines;
    public UIMenu FirstMenu;
    public UIMenu Menustuff;
    public UIMenu OptionsMenu;
    public UIMenu RequestBoat;
    public UIMenu WardrobeMainMenu;
    public Vehicle MainBoat;
    public float MissileSpeed;
    private Vector3 PlayerYachtPos1;
    private Vector3 PlayerYachtPos2;
    private Vector3 PlayerYachtPos3;
    private Vector3 PlayerYachtPos4;
    private Vector3 PlayerYachtPos5;
    private Vector3 PlayerYachtPos6;
    private Vector3 PlayerYachtPos7;
    private Vector3 PlayerYachtPos8;
    private Vector3 PlayerYachtPos9;
    private Vector3 PlayerYachtPos10;
    private Vector3 PlayerYachtPos11;
    private Vector3 PlayerYachtPos12;
    private Vector3 PlayerYachtPos13;
    private Vector3 PlayerYachtPos14;
    private Vector3 PlayerYachtPos15;
    private Vector3 PlayerYachtPos16;
    private Vector3 PlayerYachtPos17;
    private Vector3 PlayerYachtPos18;
    private Vector3 PlayerYachtPos19;
    private Vector3 PlayerYachtPos20;
    private Vector3 PlayerYachtPos21;
    private Vector3 PlayerYachtPos22;
    private Vector3 PlayerYachtPos23;
    private Vector3 PlayerYachtPos24;
    private Vector3 PlayerYachtPos25;
    private Vector3 PlayerYachtPos26;
    private Vector3 PlayerYachtPos27;
    private Vector3 PlayerYachtPos28;
    private Vector3 PlayerYachtPos29;
    private Vector3 PlayerYachtPos30;
    private Vector3 PlayerYachtPos31;
    private Vector3 PlayerYachtPos32;
    private Vector3 PlayerYachtPos33;
    private Vector3 PlayerYachtPos34;
    private Vector3 PlayerYachtPos35;
    private Vector3 PlayerYachtPos36;
    public List<string> YachtLocSring;
    public List<Vector3> YachtPos;
    public bool ReadyForRiseAnim;
    public bool usePrecision;
    public float PrecisionLevel;
    public float AmounttoDecrease;
    public bool IsInCab;
    public ScriptSettings CheckOcciConfig;
    public bool CreatedChairs;
    public int Scene1;
    public int PeriscopeScene1;
    public int SeatSittingin;
    public bool SittinginSeat;
    public bool SittinginSeat1;
    public bool SittinginSeat2;
    public Prop ExitChair;
    public Prop Console1;
    public Prop Console2;
    private Keys Key1;
    private UIMenu weaponsMenu;
    public Vector3 GunLockerMarker;
    public int GunLockerBought;
    private UIMenu MK2Pumpshotgun;
    private UIMenu MK2SNSPistol;
    private UIMenu MK2Revolver;
    private UIMenu Mk2SpecialCarbine;
    private UIMenu MK2Bullpup;
    private UIMenu MK2MarksmanRifle;
    private UIMenu MK2Pistol;
    private UIMenu MK2SMG;
    private UIMenu MK2LMG;
    private UIMenu MK2Carbine;
    private UIMenu MK2AssaultRifle;
    private UIMenu MK2Sniper;
    private MenuPool GunmodMenuPool;
    private UIMenu GunmainMenu;
    public int GunTintscount;
    public int LiveryColor;
    public bool Readocci;
    public bool Gunlockeron;
    public bool UsingPeriscope;
    public int PeriscopeMode;
    public bool CanUseInteriorPeriscope;
    public float screenaspectratio;
    public List<Prop> RDOBJ;
    public bool Chair1WaitingAnim;
    public bool Chair2WaitingAnim;
    public bool Chair8WaitingAnim;
    public bool UsingInteriorPeriscope;
    public int Scene2;
    public Prop Missile;
    public Prop Missile2;
    public bool PilotingMissile;
    public bool PilotingMissile2;
    public bool PilotingGuidedMissil3;
    public Prop GuidedMissileTarget;
    public int Scene3;
    public Vehicle Toreador;
    public Vehicle Avisa;
    public Vehicle Seasparrow;
    public bool CreatedInteriorVehicles;
    public bool CreatedPeriscope;
    public Prop HatchR02;
    public Prop HatchR01;
    public Prop HatchL02;
    public Prop HatchL01;
    public Prop Lift;
    public Prop HangerDL;
    public Prop HangerDR;
    public Prop DoorFirm;
    public int Check;
    public bool SeaSparrowOut;
    public bool AvisaOut;
    public bool ToreadorOut;
    public int SeaSparrowDestroyedTimer;
    public int AvisaDestroyedTimer;
    public int ToreadorDestroyedTimer;
    public float UpDownMoveAmt;
    public float LeftRightMoveAmt;
    public int SpawnTimer;
    public int Scene4;
    public int Scene5;
    public bool GotExitEnterProps;
    public bool UnderWater;
    public List<KosatkaScript.Wreck> UnderWaterWrecks;
    public int ScreensFound;
    public List<string> TopScreenNmaes;
    public List<string> BottomScreenNmaes;
    public List<Vector3> BottomScreenPos;
    public List<Vector3> BottomScreenRot;
    public List<Vector3> TopScreenPos;
    public List<Vector3> TopScreenRot;
    public bool PeriscopeUseMouseMovement;
    public Vector3 TargetPos;
    public Ped TargetPed;
    public Vehicle TargetVehicle;
    public Vector3 TargetCoord;
    public bool ReachedZCoord;
    public List<int> Fire__ids;
    public List<int> PTFX__ids;
    public List<flame> Flames;
    public bool RunningTargetingAlgorithm;
    public int Algorithmstage;
    public List<Vector3> TargetsMarkedListVec3;
    public List<Vector2> TargetsMarkedListVec2;
    public int TargetsMarked;
    public bool DepthControll;
    public float DepthControllY;
    public int MissileTimer;
    public int SubRiseAnim;
    public float FastTravelCost;
    public List<KosatkaScript.Wreck> UnderwaterChests;
    public bool DisplayChestBlipsOnFoot;
    public int ChestCollected;
    public bool PlayingRiseAnim;
    public int Num;
    public int MissileStationUsing;
    public WeaponTint Liv;
    public int ID_O;
    public string ID_C;
    public int Comp;
    public Model OldCharacter;
    public bool EnableChestGlow;
    public UIMenu Wardrobe;
    public Scaleform Duf_WhiteBoard_Title;
    public Scaleform Duf_WhiteBoard_Title2;
    public Scaleform Duf_WhiteBoard_Title3;
    public int LeftRightTimer;
    public int UpDownTimer;
    public Vector2 MousePos;
    public bool ReadyForEnterAnim;
    public int EnterAnim;
    public int HoldDelay;
    public int f_1362;
    public int f_1363;
    public int Local_348;
    public int f_1375;
    public string f_1374;
    public string f_1373;
    public int SwitchStage;
    public bool DrawTable;
    public bool BoatActive;

    public static void DrawScaleformTurret()
    {
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("ARENA_GUN_CAM_SCIFI");
      scaleform.Render2D();
    }

    public Vector3 ToVector3(string Name)
    {
      Vector3 vector3;
      // ISSUE: explicit constructor call
      ((Vector3) ref vector3).\u002Ector(0.0f, 0.0f, 0.0f);
      string[] separator = new string[3]{ "X:", "Y:", "Z:" };
      string[] strArray = Name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
      try
      {
        vector3 = new Vector3(float.Parse(strArray[0]), float.Parse(strArray[1]), float.Parse(strArray[2]));
      }
      catch (Exception ex)
      {
      }
      return vector3;
    }

    public static void DrawScaleformDrone()
    {
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("drone_cam");
      scaleform.Render2D();
    }

    public void LoadIniFile(string iniName)
    {
      try
      {
        this.Config = ScriptSettings.Load(iniName);
        this.VehicleToUse = (string) this.Config.GetValue<string>("Setup", "VehicleToUse", (M0) this.VehicleToUse);
        this.Livery = (int) this.Config.GetValue<int>("Setup", "Livery", (M0) this.Livery);
        this.Weapons = (int) this.Config.GetValue<int>("Setup", "Weapons", (M0) this.Weapons);
        this.MOCPosSave = (Vector3) this.Config.GetValue<Vector3>("Setup", "SavePosition", (M0) this.MOCPosSave);
        this.Spawn = this.MOCPosSave;
        this.X = (float) this.Config.GetValue<float>("Setup", "X", (M0) (double) this.X);
        this.Y = (float) this.Config.GetValue<float>("Setup", "Y", (M0) (double) this.Y);
        this.Z = (float) this.Config.GetValue<float>("Setup", "Z", (M0) (double) this.Z);
        this.VHeading = (float) this.Config.GetValue<float>("Setup", "VHeading", (M0) (double) this.VHeading);
        this.SubPurchased = (int) this.Config.GetValue<int>("Setup", "SubPurchased", (M0) this.SubPurchased);
        this.FlagID = (int) this.Config.GetValue<int>("Upgrades", "FlagID", (M0) this.FlagID);
        this.SonarStation = (int) this.Config.GetValue<int>("Upgrades", "SonarStation", (M0) this.SonarStation);
        this.GuidedMissiles = (int) this.Config.GetValue<int>("Upgrades", "GuidedMissiles", (M0) this.GuidedMissiles);
        this.WeaponsUpgrade = (int) this.Config.GetValue<int>("Upgrades", "WeaponsUpgrade", (M0) this.WeaponsUpgrade);
        this.SeaSparrowUpgrade = (int) this.Config.GetValue<int>("Upgrades", "SeaSparrowUpgrade", (M0) this.SeaSparrowUpgrade);
        this.AvisaUpgrade = (int) this.Config.GetValue<int>("Upgrades", "AvisaUpgrade", (M0) this.AvisaUpgrade);
        this.SonarActive = (bool) this.Config.GetValue<bool>("Upgrades", "SonarActive", (M0) (this.SonarActive ? 1 : 0));
        this.KosatkaCost = (float) this.Config.GetValue<float>("Prices", "KosatkaCost", (M0) (double) this.KosatkaCost);
        this.ColorCost = (float) this.Config.GetValue<float>("Prices", "ColorCost", (M0) (double) this.ColorCost);
        this.FlagCost = (float) this.Config.GetValue<float>("Prices", "FlagCost", (M0) (double) this.FlagCost);
        this.SonarCost = (float) this.Config.GetValue<float>("Prices", "SonarCost", (M0) (double) this.SonarCost);
        this.GuidedMissileCost = (float) this.Config.GetValue<float>("Prices", "GuidedMissileCost", (M0) (double) this.GuidedMissileCost);
        this.WeaponWorkshopCost = (float) this.Config.GetValue<float>("Prices", "WeaponWorkshopCost", (M0) (double) this.WeaponWorkshopCost);
        this.SeaSparrowCost = (float) this.Config.GetValue<float>("Prices", "SeaSparrowCost", (M0) (double) this.SeaSparrowCost);
        this.AvisaCost = (float) this.Config.GetValue<float>("Prices", "AvisaCost", (M0) (double) this.AvisaCost);
        this.ToreadorCost = (float) this.Config.GetValue<float>("Prices", "ToreadorCost", (M0) (double) this.ToreadorCost);
        this.FastTravelCost = (float) this.Config.GetValue<float>("Prices", "FastTravelCost", (M0) (double) this.FastTravelCost);
        this.SeaSparrowOut = (bool) this.Config.GetValue<bool>("Moonpool", "SeaSparrowOut", (M0) (this.SeaSparrowOut ? 1 : 0));
        this.AvisaOut = (bool) this.Config.GetValue<bool>("Moonpool", "AvisaOut", (M0) (this.AvisaOut ? 1 : 0));
        this.SeaSparrowDestroyedTimer = (int) this.Config.GetValue<int>("Moonpool", "SeaSparrowDestroyedTimer", (M0) this.SeaSparrowDestroyedTimer);
        this.AvisaDestroyedTimer = (int) this.Config.GetValue<int>("Moonpool", "AvisaDestroyedTimer", (M0) this.AvisaDestroyedTimer);
        this.SeaSparrowPrimaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Moonpool", "SeaSparrowPrimaryColor", (M0) this.SeaSparrowPrimaryColor);
        this.SeaSparrowSecondaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Moonpool", "SeaSparrowSecondaryColor", (M0) this.SeaSparrowSecondaryColor);
        this.AvisaPrimaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Moonpool", "AvisaPrimaryColor", (M0) this.AvisaPrimaryColor);
        this.AvisaSecondaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Moonpool", "AvisaSecondaryColor", (M0) this.AvisaSecondaryColor);
        this.SeasparrowWeapons = (int) this.Config.GetValue<int>("Moonpool", "SeasparrowWeapons", (M0) this.SeasparrowWeapons);
        this.ToreadorPrimaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Moonpool", "ToreadorPrimaryColor", (M0) this.ToreadorPrimaryColor);
        this.ToreadorSecondaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Moonpool", "ToreadorSecondaryColor", (M0) this.ToreadorSecondaryColor);
        this.DisplayChestBlipsOnFoot = (bool) this.Config.GetValue<bool>("TreasureChests", "DisplayChestBlipsOnFoot", (M0) (this.DisplayChestBlipsOnFoot ? 1 : 0));
        this.EnableChestGlow = (bool) this.Config.GetValue<bool>("TreasureChests", "EnableChestGlow", (M0) (this.EnableChestGlow ? 1 : 0));
        this.ChestCollected = (int) this.Config.GetValue<int>("TreasureChests", "ChestsCollected", (M0) this.ChestCollected);
        this.ShowTreasureCollectioninSub = (bool) this.Config.GetValue<bool>("TreasureChests", "ShowTreasureCollectioninSub", (M0) (this.ShowTreasureCollectioninSub ? 1 : 0));
        this.PeriscopeUseMouseMovement = (bool) this.Config.GetValue<bool>("Misc", "PeriscopeUseMouseMovement", (M0) (this.PeriscopeUseMouseMovement ? 1 : 0));
        this.MarkerColorString = (string) this.Config.GetValue<string>("Misc", "SubmarineMarkerColor", (M0) this.MarkerColorString);
        this.SubmarineBlipColor = (BlipColor) this.Config.GetValue<BlipColor>("Misc", "SubmarineBlipColor", (M0) this.SubmarineBlipColor);
        if (this.MarkerColorString.Contains("ARGB"))
        {
          string[] strArray = this.MarkerColorString.Split(new string[1]
          {
            "_"
          }, StringSplitOptions.None);
          this.SubmarineMarkerColor = Color.FromArgb(int.Parse(strArray[1]), int.Parse(strArray[2]), int.Parse(strArray[3]));
        }
        if (this.MarkerColorString.Contains("ARGB"))
          return;
        this.SubmarineMarkerColor = Color.FromName(this.MarkerColorString);
      }
      catch (Exception ex)
      {
        UI.Notify("~r~Error~w~: Kosatka.ini Failed To Load.");
      }
    }

    public void SetBanner(UIMenu menu) => menu.SetBannerType(this.RectangleGUI);

    public void CreateBanner()
    {
      this.RectangleGUI = new UIResRectangle();
      ((UIRectangle) this.RectangleGUI).Color = Color.FromArgb((int) byte.MaxValue, 0, 0, 0);
    }

    public void loadMenu(iFruitContact contact)
    {
      this.ifruit.Close(0);
      this.FirstMenu.Visible = !this.FirstMenu.Visible;
    }

    private void Setup()
    {
      this.CreateBanner();
      this.modMenuPool = new MenuPool();
      this.WardrobeMainMenu = new UIMenu("Kosatka", "Select an Option");
      this.OptionsMenu = new UIMenu("Kosatka", "Select an Option");
      this.FirstMenu = new UIMenu("Kosatka", "Select an Option");
      this.mainMenu = new UIMenu("Kosatka", "Select an Option");
      this.GUIMenus.Add(this.mainMenu);
      this.GUIMenus.Add(this.FirstMenu);
      this.GUIMenus.Add(this.OptionsMenu);
      this.modMenuPool.Add(this.OptionsMenu);
      this.modMenuPool.Add(this.FirstMenu);
      this.modMenuPool.Add(this.mainMenu);
      this.RequestBoat = this.modMenuPool.AddSubMenu(this.FirstMenu, "Request a Boat");
      this.mainMenu = this.modMenuPool.AddSubMenu(this.FirstMenu, "Modify/Buy Kosatka");
      this.Options = this.modMenuPool.AddSubMenu(this.mainMenu, "Options");
      this.GUIMenus.Add(this.Options);
      this.GUIMenus.Add(this.RequestBoat);
      this.GUIMenus.Add(this.mainMenu);
      this.modMenuPool2 = new MenuPool();
      this.mainMenu2 = new UIMenu("Vehicle Options", "Select an Option");
      this.GUIMenus.Add(this.mainMenu2);
      this.modMenuPool2.Add(this.mainMenu2);
      this.Options2 = this.modMenuPool2.AddSubMenu(this.mainMenu2, "Fast Travel");
      this.GUIMenus.Add(this.Options2);
      this.Wardrobe = this.modMenuPool2.AddSubMenu(this.WardrobeMainMenu, "Wardrobe");
      this.GUIMenus.Add(this.Wardrobe);
      this.PenthouseWareDrobe();
      this.LoadIniFile("scripts//CayoPericoInSp//Submarine.ini");
      this.SetupMarker();
      this.setupoptions();
      this.VehicleOptions();
      this.RequestABoat();
      this.PurchaseOptions();
      this.LoadIniFile("scripts//CayoPericoInSp//Submarine.ini");
      this.GunmodMenuPool = new MenuPool();
      this.GunmainMenu = new UIMenu("Gunlocker", "Select an Option");
      this.GUIMenus.Add(this.GunmainMenu);
      this.GunmodMenuPool.Add(this.GunmainMenu);
      this.weaponsMenu = this.GunmodMenuPool.AddSubMenu(this.GunmainMenu, "Weapons");
      this.GUIMenus.Add(this.weaponsMenu);
      this.SetupWeapons();
      for (int index = 0; index < this.GUIMenus.Count; ++index)
        this.SetBanner(this.GUIMenus[index]);
    }

    public void PurchaseOptions()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      KosatkaScript.\u003C\u003Ec__DisplayClass140_0 displayClass1400 = new KosatkaScript.\u003C\u003Ec__DisplayClass140_0()
      {
        \u003C\u003E4__this = this,
        Flagsint = new List<object>()
      };
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) -1);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 0);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 1);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 2);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 3);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 4);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 5);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 6);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 7);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 8);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 9);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 10);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 11);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 12);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 13);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 14);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 15);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 16);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 17);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 18);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 19);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 20);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 21);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 22);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 23);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 24);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 25);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 26);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 27);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 28);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 29);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 30);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 31);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 32);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 33);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 34);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 35);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 36);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 37);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 38);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 39);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 40);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 41);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 42);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 43);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 44);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 45);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flagsint.Add((object) 46);
      List<object> objectList1 = new List<object>();
      objectList1.Add((object) "No Flag");
      objectList1.Add((object) "Scotland");
      objectList1.Add((object) "USA");
      objectList1.Add((object) "France");
      objectList1.Add((object) "Italy");
      objectList1.Add((object) "Sweden");
      objectList1.Add((object) "Argentina");
      objectList1.Add((object) "EU");
      objectList1.Add((object) "Finland");
      objectList1.Add((object) "Netherlands");
      objectList1.Add((object) "Portugal");
      objectList1.Add((object) "South Korea");
      objectList1.Add((object) "Australia");
      objectList1.Add((object) "Germany");
      objectList1.Add((object) "Switzerland");
      objectList1.Add((object) "Belgium");
      objectList1.Add((object) "Turkey");
      objectList1.Add((object) "China");
      objectList1.Add((object) "Hungary");
      objectList1.Add((object) "New Zealand");
      objectList1.Add((object) "Puerto Rico");
      objectList1.Add((object) "Brazil");
      objectList1.Add((object) "Japan");
      objectList1.Add((object) "Jamaica");
      objectList1.Add((object) "Mexico");
      objectList1.Add((object) "Ireland");
      objectList1.Add((object) "Croatia");
      objectList1.Add((object) "Israel");
      objectList1.Add((object) "Nigeria");
      objectList1.Add((object) "Slovakia");
      objectList1.Add((object) "Spain");
      objectList1.Add((object) "Colombia");
      objectList1.Add((object) "Austria");
      objectList1.Add((object) "Wales");
      objectList1.Add((object) "Czech Republic");
      objectList1.Add((object) "Liechtenstein");
      objectList1.Add((object) "Palestine");
      objectList1.Add((object) "South Africa");
      objectList1.Add((object) "Canada");
      objectList1.Add((object) "United Kingdom");
      objectList1.Add((object) "Norway");
      objectList1.Add((object) "Russia");
      objectList1.Add((object) "England");
      objectList1.Add((object) "Denmark");
      objectList1.Add((object) "Malta");
      objectList1.Add((object) "Poland");
      objectList1.Add((object) "Slovenia");
      // ISSUE: reference to a compiler-generated field
      displayClass1400.listofColors = new List<object>();
      foreach (int num in (VehicleColor[]) Enum.GetValues(typeof (VehicleColor)))
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.listofColors.Add((object) (VehicleColor) 0);
        // ISSUE: reference to a compiler-generated field
        displayClass1400.listofColors.Add((object) (VehicleColor) 64);
        // ISSUE: reference to a compiler-generated field
        displayClass1400.listofColors.Add((object) (VehicleColor) 27);
        // ISSUE: reference to a compiler-generated field
        displayClass1400.listofColors.Add((object) (VehicleColor) 89);
        // ISSUE: reference to a compiler-generated field
        displayClass1400.listofColors.Add((object) (VehicleColor) 145);
        // ISSUE: reference to a compiler-generated field
        displayClass1400.listofColors.Add((object) (VehicleColor) 111);
        // ISSUE: reference to a compiler-generated field
        displayClass1400.listofColors.Add((object) (VehicleColor) 38);
        // ISSUE: reference to a compiler-generated field
        displayClass1400.listofColors.Add((object) (VehicleColor) 53);
        // ISSUE: reference to a compiler-generated field
        displayClass1400.listofColors.Add((object) (VehicleColor) 92);
        // ISSUE: reference to a compiler-generated field
        displayClass1400.listofColors.Add((object) (VehicleColor) 6);
        // ISSUE: reference to a compiler-generated field
        displayClass1400.listofColors.Add((object) (VehicleColor) num);
      }
      this.mainMenu.Clear();
      // ISSUE: reference to a compiler-generated field
      displayClass1400.KSub = new UIMenuItem("Kostaka ~g~$0");
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem(displayClass1400.KSub);
      if (this.SubPurchased == 0)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.KSub.Text = "Kostaka ~g~$" + this.KosatkaCost.ToString("N");
      }
      if (this.SubPurchased == 1)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.KSub.Text = "Kostaka ~g~$0";
      }
      this.mainMenu.AddItem(new UIMenuItem("-------------------------------------------------------------"));
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Flags = new UIMenuListItem("Flag ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem((UIMenuItem) displayClass1400.Flags);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.KFlag = new UIMenuItem("Flag ~g~" + this.FlagCost.ToString("N"));
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem(displayClass1400.KFlag);
      this.YachtPos.Add(new Vector3(0.0f, 0.0f, 0.0f));
      this.YachtPos.Add(this.PlayerYachtPos1);
      this.YachtPos.Add(this.PlayerYachtPos2);
      this.YachtPos.Add(this.PlayerYachtPos3);
      this.YachtPos.Add(this.PlayerYachtPos4);
      this.YachtPos.Add(this.PlayerYachtPos5);
      this.YachtPos.Add(this.PlayerYachtPos6);
      this.YachtPos.Add(this.PlayerYachtPos7);
      this.YachtPos.Add(this.PlayerYachtPos8);
      this.YachtPos.Add(this.PlayerYachtPos9);
      this.YachtPos.Add(this.PlayerYachtPos10);
      this.YachtPos.Add(this.PlayerYachtPos11);
      this.YachtPos.Add(this.PlayerYachtPos12);
      this.YachtPos.Add(this.PlayerYachtPos13);
      this.YachtPos.Add(this.PlayerYachtPos14);
      this.YachtPos.Add(this.PlayerYachtPos15);
      this.YachtPos.Add(this.PlayerYachtPos16);
      this.YachtPos.Add(this.PlayerYachtPos17);
      this.YachtPos.Add(this.PlayerYachtPos18);
      this.YachtPos.Add(this.PlayerYachtPos19);
      this.YachtPos.Add(this.PlayerYachtPos20);
      this.YachtPos.Add(this.PlayerYachtPos21);
      this.YachtPos.Add(this.PlayerYachtPos22);
      this.YachtPos.Add(this.PlayerYachtPos23);
      this.YachtPos.Add(this.PlayerYachtPos24);
      this.YachtPos.Add(this.PlayerYachtPos25);
      this.YachtPos.Add(this.PlayerYachtPos26);
      this.YachtPos.Add(this.PlayerYachtPos27);
      this.YachtPos.Add(this.PlayerYachtPos28);
      this.YachtPos.Add(this.PlayerYachtPos29);
      this.YachtPos.Add(this.PlayerYachtPos30);
      this.YachtPos.Add(this.PlayerYachtPos31);
      this.YachtPos.Add(this.PlayerYachtPos32);
      this.YachtPos.Add(this.PlayerYachtPos33);
      this.YachtPos.Add(this.PlayerYachtPos34);
      this.YachtPos.Add(this.PlayerYachtPos35);
      this.YachtPos.Add(this.PlayerYachtPos36);
      this.YachtPos.Add(new Vector3(3615.523f, -4779.021f, 5.433739f));
      this.YachtPos.Add(new Vector3(52.61766f, -3293.087f, -5f));
      this.YachtPos.Add(new Vector3(-3537.201f, 736.4623f, -5f));
      this.YachtPos.Add(new Vector3(-1748.002f, 5328.746f, -5f));
      this.YachtPos.Add(new Vector3(3802.629f, -5352.572f, 0.2f));
      this.YachtPos.Add(new Vector3(5640.316f, -6645.94f, 0.2f));
      this.YachtPos.Add(new Vector3(5861.699f, -4716.703f, 0.2f));
      this.YachtPos.Add(new Vector3(4584.821f, -3995.195f, 0.9f));
      this.YachtPos.Add(new Vector3(3347.001f, -4185.516f, 0.4f));
      this.YachtPos.Add(new Vector3(712.6099f, 3936.849f, 30.1f));
      this.YachtPos.Add(new Vector3(2125.483f, 4225.63f, 29.38f));
      this.YachtPos.Add(new Vector3(58.77f, 4152.88f, 29f));
      this.YachtLocSring.Add("");
      this.YachtLocSring.Add(" Zancudo River 1 ");
      this.YachtLocSring.Add("Zancudo River 2 ");
      this.YachtLocSring.Add("Zancudo River 3 ");
      this.YachtLocSring.Add("Zancudo Base 1 ");
      this.YachtLocSring.Add("Zancudo Base 2 ");
      this.YachtLocSring.Add("Zancudo Base 3 ");
      this.YachtLocSring.Add("North Chumash 1 ");
      this.YachtLocSring.Add("North Chumash 2 ");
      this.YachtLocSring.Add("North Chumash 3 ");
      this.YachtLocSring.Add("Vespucci Beach 1 ");
      this.YachtLocSring.Add("Vespucci Beach 2 ");
      this.YachtLocSring.Add("Vespucci Beach 3 ");
      this.YachtLocSring.Add("LSIA 1 ");
      this.YachtLocSring.Add("LSIA 2 ");
      this.YachtLocSring.Add("LSIA 3 ");
      this.YachtLocSring.Add("Docks 1 ");
      this.YachtLocSring.Add("Docks 2 ");
      this.YachtLocSring.Add("Docks 3 ");
      this.YachtLocSring.Add("Palomino Highlands 1 ");
      this.YachtLocSring.Add("Palomino Highlands 2 ");
      this.YachtLocSring.Add("Palomino Highlands 3 ");
      this.YachtLocSring.Add("Tavarium Mountains 1 ");
      this.YachtLocSring.Add("Tavarium Mountains 2 ");
      this.YachtLocSring.Add("Tavarium Mountains 3 ");
      this.YachtLocSring.Add("San Chianski Mountain Range 1 ");
      this.YachtLocSring.Add("San Chianski Mountain Range 2 ");
      this.YachtLocSring.Add("San Chianski Mountain Range 3 ");
      this.YachtLocSring.Add("Mount Gordo 1 ");
      this.YachtLocSring.Add("Mount Gordo 2 ");
      this.YachtLocSring.Add("Mount Gordo 3 ");
      this.YachtLocSring.Add("Propocio Beach 1 ");
      this.YachtLocSring.Add("Propocio Beach 2 ");
      this.YachtLocSring.Add("Propocio Beach 3 ");
      this.YachtLocSring.Add("Paleto Bay 1 ");
      this.YachtLocSring.Add("Paleto Bay 2 ");
      this.YachtLocSring.Add("Paleto Bay 3 ");
      this.YachtLocSring.Add("Summer Update Yacht");
      this.YachtLocSring.Add("Cayo Perico Update 1");
      this.YachtLocSring.Add("Cayo Perico Update 2");
      this.YachtLocSring.Add("Cayo Perico Update 3");
      this.YachtLocSring.Add("Cayo Perico Island 1");
      this.YachtLocSring.Add("Cayo Perico Island 2");
      this.YachtLocSring.Add("Cayo Perico Island 3");
      this.YachtLocSring.Add("Cayo Perico Island 4");
      this.YachtLocSring.Add("Cayo Perico Island 5");
      this.YachtLocSring.Add("Alamo Sea 1");
      this.YachtLocSring.Add("Alamo Sea 2");
      this.YachtLocSring.Add("Alamo Sea 3");
      List<object> objectList2 = new List<object>();
      foreach (string str in this.YachtLocSring)
        objectList2.Add((object) str);
      this.mainMenu.AddItem(new UIMenuItem("-------------------------------------------------------------"));
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Yloc = new UIMenuListItem("Location : ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem((UIMenuItem) displayClass1400.Yloc);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.ChangeLoc = new UIMenuItem("Request new Location  ~g~ $" + this.FastTravelCost.ToString("N"));
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem(displayClass1400.ChangeLoc);
      // ISSUE: method pointer
      this.mainMenu.OnItemSelect += new ItemSelectEvent((object) displayClass1400, __methodptr(\u003CPurchaseOptions\u003Eb__0));
      this.mainMenu.AddItem(new UIMenuItem("-------------------------------------------------------------"));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1400.CabColor1 = new UIMenuListItem("Primary Color ", displayClass1400.listofColors, 0);
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem((UIMenuItem) displayClass1400.CabColor1);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1400.CabColor2 = new UIMenuListItem("Secondary Color ", displayClass1400.listofColors, 0);
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem((UIMenuItem) displayClass1400.CabColor2);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.KColor = new UIMenuItem("Change Kosatka Color ~g~" + this.ColorCost.ToString("N"));
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem(displayClass1400.KColor);
      this.mainMenu.AddItem(new UIMenuItem("-------------------------------------------------------------"));
      // ISSUE: reference to a compiler-generated field
      displayClass1400.SStation = new UIMenuItem("Sonar Station ~g~$0");
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem(displayClass1400.SStation);
      if (this.SonarStation == 0)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.SStation.Text = "Sonar Station ~g~$" + this.SonarCost.ToString("N");
      }
      if (this.SonarStation == 1)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.SStation.Text = "Sonar Station ~g~$0";
      }
      // ISSUE: reference to a compiler-generated field
      displayClass1400.GMissile = new UIMenuItem("Guided Missile ~g~$0");
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem(displayClass1400.GMissile);
      if (this.GuidedMissiles == 0)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.GMissile.Text = "Guided Missile ~g~$" + this.GuidedMissileCost.ToString("N");
      }
      if (this.GuidedMissiles == 1)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.GMissile.Text = "Guided Missile ~g~$0";
      }
      // ISSUE: reference to a compiler-generated field
      displayClass1400.WUpgrade = new UIMenuItem("Weapon Workshop ~g~$0");
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem(displayClass1400.WUpgrade);
      if (this.WeaponsUpgrade == 0)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.WUpgrade.Text = "Weapon Workshop ~g~$" + this.WeaponWorkshopCost.ToString("N");
      }
      if (this.WeaponsUpgrade == 1)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.WUpgrade.Text = "Weapon Workshop ~g~$0";
      }
      this.mainMenu.AddItem(new UIMenuItem("-------------------------------------------------------------"));
      // ISSUE: reference to a compiler-generated field
      displayClass1400.SSparrow = new UIMenuItem("Sea Sparrow Upgrade ~g~$0");
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem(displayClass1400.SSparrow);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1400.SeaSparrowCabColor1 = new UIMenuListItem("Primary Color ", displayClass1400.listofColors, 0);
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem((UIMenuItem) displayClass1400.SeaSparrowCabColor1);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1400.SeaSparrowCabColor2 = new UIMenuListItem("Secondary Color ", displayClass1400.listofColors, 0);
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem((UIMenuItem) displayClass1400.SeaSparrowCabColor2);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.SSChamge = new UIMenuItem("Change Sea Sparrow Color ~g~" + this.ColorCost.ToString("N"));
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem(displayClass1400.SSChamge);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Wpc = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Wpc.Add((object) 0);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Wpc.Add((object) 350000);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Wpc.Add((object) 500000);
      List<object> objectList3 = new List<object>();
      objectList3.Add((object) "No Weapons");
      objectList3.Add((object) "Minigun");
      objectList3.Add((object) "Lock-On Missile");
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Wpid = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Wpid.Add((object) -1);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Wpid.Add((object) 0);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Wpid.Add((object) 1);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.SSW = new UIMenuListItem("Weapon ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem((UIMenuItem) displayClass1400.SSW);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.CsSW = new UIMenuItem("Weapons Upgrade  ~g~$0");
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem(displayClass1400.CsSW);
      // ISSUE: method pointer
      this.mainMenu.OnListChange += new ListChangedEvent((object) displayClass1400, __methodptr(\u003CPurchaseOptions\u003Eb__1));
      if (this.SeaSparrowUpgrade == 0)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.SSparrow.Text = "Sea Sparrow Upgrade ~g~$" + this.SeaSparrowCost.ToString("N");
      }
      if (this.SeaSparrowUpgrade == 1)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.SSparrow.Text = "Sea Sparrow Upgrade ~g~$0";
      }
      this.mainMenu.AddItem(new UIMenuItem("-------------------------------------------------------------"));
      // ISSUE: reference to a compiler-generated field
      displayClass1400.AUpgrade = new UIMenuItem("Avisa Upgrade ~g~$0");
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem(displayClass1400.AUpgrade);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1400.AvisaCabColor1 = new UIMenuListItem("Primary Color ", displayClass1400.listofColors, 0);
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem((UIMenuItem) displayClass1400.AvisaCabColor1);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1400.AvisaCabColor2 = new UIMenuListItem("Secondary Color ", displayClass1400.listofColors, 0);
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem((UIMenuItem) displayClass1400.AvisaCabColor2);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.AVChamge = new UIMenuItem("Change Avisa Color ~g~" + this.ColorCost.ToString("N"));
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem(displayClass1400.AVChamge);
      if (this.AvisaUpgrade == 0)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.AUpgrade.Text = "Avisa Upgrade ~g~$" + this.AvisaCost.ToString("N");
      }
      if (this.AvisaUpgrade == 1)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.AUpgrade.Text = "Avisa Upgrade ~g~$0";
      }
      this.mainMenu.AddItem(new UIMenuItem("-------------------------------------------------------------"));
      // ISSUE: reference to a compiler-generated field
      displayClass1400.TUpgrade = new UIMenuItem("Toreador Upgrade ~g~$0");
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem(displayClass1400.TUpgrade);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1400.ToreadorCabColor1 = new UIMenuListItem("Primary Color ", displayClass1400.listofColors, 0);
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem((UIMenuItem) displayClass1400.ToreadorCabColor1);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1400.ToreadorCabColor2 = new UIMenuListItem("Secondary Color ", displayClass1400.listofColors, 0);
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem((UIMenuItem) displayClass1400.ToreadorCabColor2);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.TCChamge = new UIMenuItem("Change Toreador Color ~g~" + this.ColorCost.ToString("N"));
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem(displayClass1400.TCChamge);
      if (this.ToreadorUpgrade == 0)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.TUpgrade.Text = "Toreador Upgrade ~g~$" + this.ToreadorCost.ToString("N");
      }
      if (this.ToreadorUpgrade == 1)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.TUpgrade.Text = "Toreador Upgrade ~g~$0";
      }
      // ISSUE: reference to a compiler-generated field
      displayClass1400.BColour = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass1400.BColour.Add((object) (BlipColor) 2);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.BColour.Add((object) (BlipColor) 3);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.BColour.Add((object) (BlipColor) 66);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.BColour.Add((object) (BlipColor) 1);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.BColour.Add((object) (BlipColor) 50);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.BColour.Add((object) (BlipColor) 61);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.BColour.Add((object) (BlipColor) 51);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.BColour.Add((object) (BlipColor) 0);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.BColour.Add((object) (BlipColor) 55);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.MColour = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass1400.MColour.Add((object) "Green");
      // ISSUE: reference to a compiler-generated field
      displayClass1400.MColour.Add((object) "Blue");
      // ISSUE: reference to a compiler-generated field
      displayClass1400.MColour.Add((object) "Yellow");
      // ISSUE: reference to a compiler-generated field
      displayClass1400.MColour.Add((object) "Red");
      // ISSUE: reference to a compiler-generated field
      displayClass1400.MColour.Add((object) "Purple");
      // ISSUE: reference to a compiler-generated field
      displayClass1400.MColour.Add((object) "Pink");
      // ISSUE: reference to a compiler-generated field
      displayClass1400.MColour.Add((object) "Orange");
      // ISSUE: reference to a compiler-generated field
      displayClass1400.MColour.Add((object) "White");
      // ISSUE: reference to a compiler-generated field
      displayClass1400.MColour.Add((object) "Gray");
      foreach (object name in Enum.GetNames(typeof (KnownColor)))
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1400.MColour.Add(name);
      }
      this.mainMenu.AddItem(new UIMenuItem("-------------------------------------------------------------"));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1400.MC = new UIMenuListItem("Marker Color : ", displayClass1400.MColour, 0);
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem((UIMenuItem) displayClass1400.MC);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1400.BC = new UIMenuListItem("Blip Color : ", displayClass1400.BColour, 0);
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem((UIMenuItem) displayClass1400.BC);
      // ISSUE: reference to a compiler-generated field
      displayClass1400.Setall = new UIMenuItem("Save Colours");
      // ISSUE: reference to a compiler-generated field
      this.mainMenu.AddItem(displayClass1400.Setall);
      this.SeaSparrowPrimaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Moonpool", "SeaSparrowPrimaryColor", (M0) this.SeaSparrowPrimaryColor);
      this.SeaSparrowSecondaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Moonpool", "SeaSparrowSecondaryColor", (M0) this.SeaSparrowSecondaryColor);
      this.AvisaPrimaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Moonpool", "AvisaPrimaryColor", (M0) this.AvisaPrimaryColor);
      this.AvisaSecondaryColor = (VehicleColor) this.Config.GetValue<VehicleColor>("Moonpool", "AvisaSecondaryColor", (M0) this.AvisaSecondaryColor);
      // ISSUE: method pointer
      this.mainMenu.OnItemSelect += new ItemSelectEvent((object) displayClass1400, __methodptr(\u003CPurchaseOptions\u003Eb__2));
    }

    public void RequestABoat()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      KosatkaScript.\u003C\u003Ec__DisplayClass141_0 displayClass1410 = new KosatkaScript.\u003C\u003Ec__DisplayClass141_0();
      // ISSUE: reference to a compiler-generated field
      displayClass1410.\u003C\u003E4__this = this;
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.RequestBoat, "Boat Options");
      this.GUIMenus.Add(uiMenu);
      this.GUIMenus.Add(uiMenu);
      // ISSUE: reference to a compiler-generated field
      displayClass1410.ReqDinghy = new UIMenuItem("Request Dingy : ~g~$35,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1410.ReqDinghy);
      // ISSUE: reference to a compiler-generated field
      displayClass1410.ReqWDinghy = new UIMenuItem("Request Weaponized Dingy : ~g~$95,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1410.ReqWDinghy);
      // ISSUE: reference to a compiler-generated field
      displayClass1410.ReqPT = new UIMenuItem("Request Patrol Boat : ~g~$135,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1410.ReqPT);
      // ISSUE: reference to a compiler-generated field
      displayClass1410.ReqAvisa = new UIMenuItem("Request Avisa : ~g~$0");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1410.ReqAvisa);
      // ISSUE: reference to a compiler-generated field
      displayClass1410.ReqToreador = new UIMenuItem("Request Toreador : ~g~$0");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1410.ReqToreador);
      // ISSUE: method pointer
      uiMenu.OnItemSelect += new ItemSelectEvent((object) displayClass1410, __methodptr(\u003CRequestABoat\u003Eb__0));
    }

    public void SetupDroneMenu()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      KosatkaScript.\u003C\u003Ec__DisplayClass142_0 displayClass1420 = new KosatkaScript.\u003C\u003Ec__DisplayClass142_0();
      // ISSUE: reference to a compiler-generated field
      displayClass1420.\u003C\u003E4__this = this;
      UIMenu uiMenu = this.modMenuPool2.AddSubMenu(this.DroneMenu, "Drone Menu");
      this.GUIMenus.Add(uiMenu);
      // ISSUE: reference to a compiler-generated field
      displayClass1420.Scout = new UIMenuItem("Use 'Scout' Drone");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1420.Scout);
      // ISSUE: reference to a compiler-generated field
      displayClass1420.Hunter = new UIMenuItem("Use 'Hunter' Drone");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1420.Hunter);
      // ISSUE: method pointer
      uiMenu.OnItemSelect += new ItemSelectEvent((object) displayClass1420, __methodptr(\u003CSetupDroneMenu\u003Eb__0));
    }

    public void SetupMarker()
    {
      if (Blip.op_Inequality(this.PurchaseMarkerBlip, (Blip) null))
        this.PurchaseMarkerBlip.Remove();
      if (Blip.op_Inequality(this.MOCBlip, (Blip) null))
        this.MOCBlip.Remove();
      this.MOCBlip = World.CreateBlip(this.Spawn);
      this.MOCBlip.Sprite = (BlipSprite) 760;
      this.MOCBlip.Color = this.SubmarineBlipColor;
      this.MOCBlip.Name = "Cayo Perico Heist Kosatka";
      this.MOCBlip.IsShortRange = true;
      this.PurchaseMarkerBlip = World.CreateBlip(this.PurchaseMarker);
      this.PurchaseMarkerBlip.Sprite = (BlipSprite) 428;
      this.PurchaseMarkerBlip.Color = this.SubmarineBlipColor;
      this.PurchaseMarkerBlip.Name = "Purchase Kosatka Submarine for Cayo Perico Hiest";
      this.PurchaseMarkerBlip.IsShortRange = true;
      if (this.SubPurchased != 0)
        return;
      this.MOCBlip.Alpha = 0;
    }

    public void SavePos()
    {
      ((Entity) this.Kosatka).Position = this.Spawn;
      this.MOCPosSave = ((Entity) this.Kosatka).Position;
      this.Spawn = this.MOCPosSave;
      this.X = (float) this.Spawn.X;
      this.Config.SetValue<float>("Setup", "X", (M0) (double) this.X);
      this.Y = (float) this.Spawn.Y;
      this.Config.SetValue<float>("Setup", "Y", (M0) (double) this.Y);
      this.Z = (float) this.Spawn.Z;
      this.Config.SetValue<float>("Setup", "Z", (M0) (double) this.Z);
      this.Config.SetValue<Vector3>("Setup", "SavePosition", (M0) this.MOCPosSave);
      this.Config.Save();
      this.VHeading = ((Entity) this.Kosatka).Heading;
      this.Config.SetValue<float>("Setup", "VHeading", (M0) (double) this.VHeading);
      this.Config.Save();
    }

    private void DisplayHelpTextThisFrame(string text)
    {
      Function.Call((Hash) -8860350453193909743L, new InputArgument[1]
      {
        InputArgument.op_Implicit("STRING")
      });
      Function.Call((Hash) 7789129354908300458L, new InputArgument[1]
      {
        InputArgument.op_Implicit(text)
      });
      Function.Call((Hash) 2562546386151446694L, new InputArgument[4]
      {
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(-1)
      });
    }

    private void DisplayHelpTextThisFrameNoSound(string text)
    {
      Function.Call((Hash) -8860350453193909743L, new InputArgument[1]
      {
        InputArgument.op_Implicit("STRING")
      });
      Function.Call((Hash) 7789129354908300458L, new InputArgument[1]
      {
        InputArgument.op_Implicit(text)
      });
      Function.Call((Hash) 2562546386151446694L, new InputArgument[4]
      {
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(-1)
      });
    }

    public void VehicleOptions()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      KosatkaScript.\u003C\u003Ec__DisplayClass186_0 displayClass1860 = new KosatkaScript.\u003C\u003Ec__DisplayClass186_0();
      // ISSUE: reference to a compiler-generated field
      displayClass1860.\u003C\u003E4__this = this;
      this.YachtPos.Add(new Vector3(0.0f, 0.0f, 0.0f));
      this.YachtPos.Add(this.PlayerYachtPos1);
      this.YachtPos.Add(this.PlayerYachtPos2);
      this.YachtPos.Add(this.PlayerYachtPos3);
      this.YachtPos.Add(this.PlayerYachtPos4);
      this.YachtPos.Add(this.PlayerYachtPos5);
      this.YachtPos.Add(this.PlayerYachtPos6);
      this.YachtPos.Add(this.PlayerYachtPos7);
      this.YachtPos.Add(this.PlayerYachtPos8);
      this.YachtPos.Add(this.PlayerYachtPos9);
      this.YachtPos.Add(this.PlayerYachtPos10);
      this.YachtPos.Add(this.PlayerYachtPos11);
      this.YachtPos.Add(this.PlayerYachtPos12);
      this.YachtPos.Add(this.PlayerYachtPos13);
      this.YachtPos.Add(this.PlayerYachtPos14);
      this.YachtPos.Add(this.PlayerYachtPos15);
      this.YachtPos.Add(this.PlayerYachtPos16);
      this.YachtPos.Add(this.PlayerYachtPos17);
      this.YachtPos.Add(this.PlayerYachtPos18);
      this.YachtPos.Add(this.PlayerYachtPos19);
      this.YachtPos.Add(this.PlayerYachtPos20);
      this.YachtPos.Add(this.PlayerYachtPos21);
      this.YachtPos.Add(this.PlayerYachtPos22);
      this.YachtPos.Add(this.PlayerYachtPos23);
      this.YachtPos.Add(this.PlayerYachtPos24);
      this.YachtPos.Add(this.PlayerYachtPos25);
      this.YachtPos.Add(this.PlayerYachtPos26);
      this.YachtPos.Add(this.PlayerYachtPos27);
      this.YachtPos.Add(this.PlayerYachtPos28);
      this.YachtPos.Add(this.PlayerYachtPos29);
      this.YachtPos.Add(this.PlayerYachtPos30);
      this.YachtPos.Add(this.PlayerYachtPos31);
      this.YachtPos.Add(this.PlayerYachtPos32);
      this.YachtPos.Add(this.PlayerYachtPos33);
      this.YachtPos.Add(this.PlayerYachtPos34);
      this.YachtPos.Add(this.PlayerYachtPos35);
      this.YachtPos.Add(this.PlayerYachtPos36);
      this.YachtPos.Add(new Vector3(3615.523f, -4779.021f, 5.433739f));
      this.YachtPos.Add(new Vector3(52.61766f, -3293.087f, -5f));
      this.YachtPos.Add(new Vector3(-3537.201f, 736.4623f, -5f));
      this.YachtPos.Add(new Vector3(-1748.002f, 5328.746f, -5f));
      this.YachtPos.Add(new Vector3(3802.629f, -5352.572f, 0.2f));
      this.YachtPos.Add(new Vector3(5640.316f, -6645.94f, 0.2f));
      this.YachtPos.Add(new Vector3(5861.699f, -4716.703f, 0.2f));
      this.YachtPos.Add(new Vector3(4584.821f, -3995.195f, 0.9f));
      this.YachtPos.Add(new Vector3(3347.001f, -4185.516f, 0.4f));
      this.YachtPos.Add(new Vector3(712.6099f, 3936.849f, 30.1f));
      this.YachtPos.Add(new Vector3(2125.483f, 4225.63f, 29.38f));
      this.YachtPos.Add(new Vector3(58.77f, 4152.88f, 29f));
      this.YachtLocSring.Add("");
      this.YachtLocSring.Add(" Zancudo River 1 ");
      this.YachtLocSring.Add("Zancudo River 2 ");
      this.YachtLocSring.Add("Zancudo River 3 ");
      this.YachtLocSring.Add("Zancudo Base 1 ");
      this.YachtLocSring.Add("Zancudo Base 2 ");
      this.YachtLocSring.Add("Zancudo Base 3 ");
      this.YachtLocSring.Add("North Chumash 1 ");
      this.YachtLocSring.Add("North Chumash 2 ");
      this.YachtLocSring.Add("North Chumash 3 ");
      this.YachtLocSring.Add("Vespucci Beach 1 ");
      this.YachtLocSring.Add("Vespucci Beach 2 ");
      this.YachtLocSring.Add("Vespucci Beach 3 ");
      this.YachtLocSring.Add("LSIA 1 ");
      this.YachtLocSring.Add("LSIA 2 ");
      this.YachtLocSring.Add("LSIA 3 ");
      this.YachtLocSring.Add("Docks 1 ");
      this.YachtLocSring.Add("Docks 2 ");
      this.YachtLocSring.Add("Docks 3 ");
      this.YachtLocSring.Add("Palomino Highlands 1 ");
      this.YachtLocSring.Add("Palomino Highlands 2 ");
      this.YachtLocSring.Add("Palomino Highlands 3 ");
      this.YachtLocSring.Add("Tavarium Mountains 1 ");
      this.YachtLocSring.Add("Tavarium Mountains 2 ");
      this.YachtLocSring.Add("Tavarium Mountains 3 ");
      this.YachtLocSring.Add("San Chianski Mountain Range 1 ");
      this.YachtLocSring.Add("San Chianski Mountain Range 2 ");
      this.YachtLocSring.Add("San Chianski Mountain Range 3 ");
      this.YachtLocSring.Add("Mount Gordo 1 ");
      this.YachtLocSring.Add("Mount Gordo 2 ");
      this.YachtLocSring.Add("Mount Gordo 3 ");
      this.YachtLocSring.Add("Propocio Beach 1 ");
      this.YachtLocSring.Add("Propocio Beach 2 ");
      this.YachtLocSring.Add("Propocio Beach 3 ");
      this.YachtLocSring.Add("Paleto Bay 1 ");
      this.YachtLocSring.Add("Paleto Bay 2 ");
      this.YachtLocSring.Add("Paleto Bay 3 ");
      this.YachtLocSring.Add("Summer Update Yacht");
      this.YachtLocSring.Add("Cayo Perico Update 1");
      this.YachtLocSring.Add("Cayo Perico Update 2");
      this.YachtLocSring.Add("Cayo Perico Update 3");
      this.YachtLocSring.Add("Cayo Perico Island 1");
      this.YachtLocSring.Add("Cayo Perico Island 2");
      this.YachtLocSring.Add("Cayo Perico Island 3");
      this.YachtLocSring.Add("Cayo Perico Island 4");
      this.YachtLocSring.Add("Cayo Perico Island 5");
      this.YachtLocSring.Add("Alamo Sea 1");
      this.YachtLocSring.Add("Alamo Sea 2");
      this.YachtLocSring.Add("Alamo Sea 3");
      List<object> objectList = new List<object>();
      foreach (string str in this.YachtLocSring)
        objectList.Add((object) str);
      // ISSUE: reference to a compiler-generated field
      displayClass1860.Yloc = new UIMenuListItem("Location : ", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      this.Options2.AddItem((UIMenuItem) displayClass1860.Yloc);
      // ISSUE: reference to a compiler-generated field
      displayClass1860.ChangeLoc = new UIMenuItem("Change Location  ~g~ $" + this.FastTravelCost.ToString("N"));
      // ISSUE: reference to a compiler-generated field
      this.Options2.AddItem(displayClass1860.ChangeLoc);
      // ISSUE: method pointer
      this.Options2.OnItemSelect += new ItemSelectEvent((object) displayClass1860, __methodptr(\u003CVehicleOptions\u003Eb__0));
    }

    public void setupoptions()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      KosatkaScript.\u003C\u003Ec__DisplayClass188_0 displayClass1880 = new KosatkaScript.\u003C\u003Ec__DisplayClass188_0();
      // ISSUE: reference to a compiler-generated field
      displayClass1880.\u003C\u003E4__this = this;
      List<object> objectList = new List<object>();
      for (int index = 0; index < this.Tintscount; ++index)
        objectList.Add((object) index);
      // ISSUE: reference to a compiler-generated field
      displayClass1880.listofColors = new List<object>();
      foreach (int num in (VehicleColor[]) Enum.GetValues(typeof (VehicleColor)))
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1880.listofColors.Add((object) (VehicleColor) num);
      }
      UIMenu uiMenu1 = this.modMenuPool.AddSubMenu(this.Options, "Options");
      this.GUIMenus.Add(uiMenu1);
      UIMenu uiMenu2 = this.modMenuPool.AddSubMenu(this.Options, "Colours");
      this.GUIMenus.Add(uiMenu2);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1880.CabColor1 = new UIMenuListItem("Primary Color ", displayClass1880.listofColors, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass1880.CabColor1);
      // ISSUE: reference to a compiler-generated field
      displayClass1880.GetCabColor1 = new UIMenuItem("Get Primary Color");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass1880.GetCabColor1);
      // ISSUE: reference to a compiler-generated field
      displayClass1880.GetCabColor2 = new UIMenuItem("Get Secondary Color");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass1880.GetCabColor2);
      // ISSUE: reference to a compiler-generated field
      displayClass1880.Options2 = new UIMenuItem("Enter Cargo Bay");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass1880.Options2);
      // ISSUE: reference to a compiler-generated field
      displayClass1880.Options3 = new UIMenuItem("AutoPilot");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass1880.Options3);
      // ISSUE: method pointer
      uiMenu2.OnItemSelect += new ItemSelectEvent((object) displayClass1880, __methodptr(\u003Csetupoptions\u003Eb__0));
      // ISSUE: method pointer
      uiMenu1.OnItemSelect += new ItemSelectEvent((object) displayClass1880, __methodptr(\u003Csetupoptions\u003Eb__1));
    }

    public void TeleportintoCab() => Game.Player.Character.SetIntoVehicle(this.Kosatka, (VehicleSeat) -1);

    public void SpawnMOC()
    {
      try
      {
        if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
          ((Entity) this.Kosatka).Delete();
        this.LoadIniFile("scripts//CayoPericoInSp//Submarine.ini");
        this.MOCPosSavestring = (string) this.Config.GetValue<string>("Setup", "SavePosition", (M0) this.MOCPosSavestring);
        this.MOCPosSave = this.ToVector3(this.MOCPosSavestring);
        this.Spawn = this.MOCPosSave;
        this.X = (float) this.Config.GetValue<float>("Setup", "X", (M0) (double) this.X);
        this.Y = (float) this.Config.GetValue<float>("Setup", "Y", (M0) (double) this.Y);
        this.Z = (float) this.Config.GetValue<float>("Setup", "Z", (M0) (double) this.Z);
        Script.Wait(10);
        this.Kosatka = World.CreateVehicle(this.RequestModel("KOSATKA"), new Vector3(this.X, this.Y, this.Z - 5f));
        this.Kosatka.PrimaryColor = this.CabPrimary;
        this.Kosatka.SecondaryColor = this.CabSecondary;
        this.WheelsSaveLoad.LoadIniFile("scripts//CayoPericoInSp//Submarine.ini");
        this.WheelsSaveLoad.SaveWithoutDelete();
        this.WheelsSaveLoad.Load(this.Kosatka);
        Function.Call((Hash) 5223808454466558881L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.Kosatka),
          InputArgument.op_Implicit(this.WheelsSaveLoad.WheelType)
        });
        this.Kosatka.WheelType = (VehicleWheelType) this.WheelsSaveLoad.WheelType;
        this.Kosatka.SetMod((VehicleMod) 23, this.WheelsSaveLoad.FrontWheelsId, true);
        this.Kosatka.SetMod((VehicleMod) 24, this.WheelsSaveLoad.BackWheelsId, true);
        this.WheelsSaveLoad.SavedVehicle = (Vehicle) null;
        this.Created = true;
        if (!Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
          return;
        ((Entity) this.Kosatka).Heading = this.VHeading;
      }
      catch (NullReferenceException ex)
      {
        UI.Notify("~r~Working Kosotka Submarine : Somthing has gone wrong with the mod please reload the mod, please try again, if this persitsts contact HKH191 on Discord ~w~");
      }
    }

    public Model RequestModel(string Name)
    {
      Model model;
      // ISSUE: explicit constructor call
      ((Model) ref model).\u002Ector(Name);
      ((Model) ref model).Request(250);
      if (((Model) ref model).IsInCdImage && ((Model) ref model).IsValid)
      {
        while (!((Model) ref model).IsLoaded)
          Script.Wait(50);
        return model;
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      return model;
    }

    public Model RequestModel(VehicleHash Name)
    {
      Model model;
      // ISSUE: explicit constructor call
      ((Model) ref model).\u002Ector(Name);
      ((Model) ref model).Request(250);
      if (((Model) ref model).IsInCdImage && ((Model) ref model).IsValid)
      {
        while (!((Model) ref model).IsLoaded)
          Script.Wait(50);
        return model;
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      return model;
    }

    public void CheckOcci(string iniName)
    {
      try
      {
        this.CheckOcciConfig = ScriptSettings.Load(iniName);
      }
      catch (Exception ex)
      {
        UI.Notify("~r~Error~w~: Kosatka.ini Failed To Load.");
      }
    }

    public static string LoadDict(string dict)
    {
      while (true)
      {
        if (Function.Call<bool>((Hash) -3444786327252301684L, new InputArgument[1]
        {
          InputArgument.op_Implicit(dict)
        }) == 0)
        {
          Function.Call((Hash) -3189321952077349130L, new InputArgument[1]
          {
            InputArgument.op_Implicit(dict)
          });
          Script.Yield();
        }
        else
          break;
      }
      return dict;
    }

    public void SetLivery(string Weapon, string Component) => Function.Call((Hash) -6925019757679945491L, new InputArgument[4]
    {
      InputArgument.op_Implicit((Ped) Function.Call<Ped>((Hash) -2879672645410256730L, Array.Empty<InputArgument>())),
      InputArgument.op_Implicit((int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
      {
        InputArgument.op_Implicit(Weapon)
      })),
      InputArgument.op_Implicit((int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
      {
        InputArgument.op_Implicit(Component)
      })),
      InputArgument.op_Implicit(this.LiveryColor)
    });

    public int GetLivery(string Weapon, string Component) => (int) Function.Call<int>((Hash) -1106196380401692883L, new InputArgument[3]
    {
      InputArgument.op_Implicit((Ped) Function.Call<Ped>((Hash) -2879672645410256730L, Array.Empty<InputArgument>())),
      InputArgument.op_Implicit((int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
      {
        InputArgument.op_Implicit(Weapon)
      })),
      InputArgument.op_Implicit((int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
      {
        InputArgument.op_Implicit(Component)
      }))
    });

    public bool CheckWeaponCamo(Weapon Weapon)
    {
      bool flag = false;
      if (Weapon.IsComponentActive((WeaponComponent) -1860492113))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 937772107))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1401650071))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 628662130))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -985047251))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -812944463))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1447352303))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -60338860))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 2088750491))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1513913454))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1179558480))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -979292288))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1371515465))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1190793877))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1497085720))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1803148180))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1975971886))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -268444834))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -574769446))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -882699739))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1468181474))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -974541230))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1272803094))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1080719624))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 792221348))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -452181427))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -746774737))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -2044296061))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -199171978))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1428075016))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1735153315))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1796459838))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -631911105))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1249283253))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -857707587))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1097543898))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1980349969))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1219453777))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1853459190))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -2074781016))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 457967755))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 235171324))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 42685294))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -687617715))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -130843390))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -977347227))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1507009185))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -378461067))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 329939175))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 643374672))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 807875052))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1401804168))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -847811454))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1413108537))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1815270123))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1869284448))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1931539634))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1624199183))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -26834113))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -210406055))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 423313640))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 276639596))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -991356863))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1682848301))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 996213771))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1214048550))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1550611612))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 368550800))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1769069349))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 24902297))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -228041614))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -584961562))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1153175946))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1301287696))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1597093459))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1769871776))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1827882671))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -474112444))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 387223451))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 617753366))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -222378256))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 8741501))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -601286203))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -511433605))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -655387818))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -282476598))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1739501925))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1178671645))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1069552225))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 11918884))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 176157112))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -220052855))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 288456487))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 398658626))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 628697006))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 925911836))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1222307441))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 552442715))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -648943513))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -996700057))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 940943685))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1263226800))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -328035840))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1224100642))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 899228776))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 616006309))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1561952511))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 572063080))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1170588613))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 966612367))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 259780317))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -403805974))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1973342474))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 691432737))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1996130345))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 987648331))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1455657812))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -431680535))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1668263084))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -847582310))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1308243489))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -92592218))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1122574335))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -494548326))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1420313469))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 730876697))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 109848390))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 583159708))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 593945703))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1928503603))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1142457062))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 520557834))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -737430213))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1125852043))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 886015732))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1262287139))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -295208411))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -544154504))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 172765678))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1982877449))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 2072122460))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) -1986220171))
        flag = true;
      if (Weapon.IsComponentActive((WeaponComponent) 1377355801))
        flag = true;
      return flag;
    }

    public void SetWeaponLivery(Weapon Weapon)
    {
      if (Weapon.IsComponentActive((WeaponComponent) -1860492113))
        this.SetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) 937772107))
        this.SetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 1401650071))
        this.SetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) 628662130))
        this.SetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) -985047251))
        this.SetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) -812944463))
        this.SetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) -1447352303))
        this.SetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -60338860))
        this.SetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) 2088750491))
        this.SetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) -1513913454))
        this.SetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) -1179558480))
        this.SetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) -979292288))
        this.SetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) -1371515465))
        this.SetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) -1190793877))
        this.SetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) -1497085720))
        this.SetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) -1803148180))
        this.SetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) -1975971886))
        this.SetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) -268444834))
        this.SetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -574769446))
        this.SetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) -882699739))
        this.SetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) -1468181474))
        this.SetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) -974541230))
        this.SetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) 1272803094))
        this.SetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) 1080719624))
        this.SetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 792221348))
        this.SetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) -452181427))
        this.SetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) -746774737))
        this.SetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) -2044296061))
        this.SetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) -199171978))
        this.SetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -1428075016))
        this.SetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) -1735153315))
        this.SetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) 1796459838))
        this.SetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) -631911105))
        this.SetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) 1249283253))
        this.SetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) -857707587))
        this.SetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) -1097543898))
        this.SetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) 1980349969))
        this.SetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) 1219453777))
        this.SetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) -1853459190))
        this.SetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) -2074781016))
        this.SetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) 457967755))
        this.SetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) 235171324))
        this.SetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) 42685294))
        this.SetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) -687617715))
        this.SetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) -130843390))
        this.SetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) -977347227))
        this.SetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) -1507009185))
        this.SetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) -378461067))
        this.SetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 329939175))
        this.SetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) 643374672))
        this.SetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) 807875052))
        this.SetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) -1401804168))
        this.SetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -847811454))
        this.SetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) -1413108537))
        this.SetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) 1815270123))
        this.SetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) -1869284448))
        this.SetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) 1931539634))
        this.SetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 1624199183))
        this.SetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) -26834113))
        this.SetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) -210406055))
        this.SetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) 423313640))
        this.SetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) 276639596))
        this.SetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -991356863))
        this.SetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) -1682848301))
        this.SetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) 996213771))
        this.SetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) -1214048550))
        this.SetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) 1550611612))
      {
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_SLIDE");
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO");
      }
      if (Weapon.IsComponentActive((WeaponComponent) 368550800))
      {
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_02_SLIDE");
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_02");
      }
      if (Weapon.IsComponentActive((WeaponComponent) -1769069349))
      {
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_03_SLIDE");
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_03");
      }
      if (Weapon.IsComponentActive((WeaponComponent) 24902297))
      {
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_04_SLIDE");
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_04");
      }
      if (Weapon.IsComponentActive((WeaponComponent) -228041614))
      {
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_05_SLIDE");
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_05");
      }
      if (Weapon.IsComponentActive((WeaponComponent) -584961562))
      {
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_06_SLIDE");
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_06");
      }
      if (Weapon.IsComponentActive((WeaponComponent) -1153175946))
      {
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_07_SLIDE");
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_07");
      }
      if (Weapon.IsComponentActive((WeaponComponent) 1301287696))
      {
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_08_SLIDE");
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_08");
      }
      if (Weapon.IsComponentActive((WeaponComponent) 1597093459))
      {
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_09_SLIDE");
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_09");
      }
      if (Weapon.IsComponentActive((WeaponComponent) 1769871776))
      {
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_10_SLIDE");
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_10");
      }
      if (Weapon.IsComponentActive((WeaponComponent) -1827882671))
      {
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_IND_01_SLIDE");
        this.SetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_IND_01");
      }
      if (Weapon.IsComponentActive((WeaponComponent) -474112444))
        this.SetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) 387223451))
        this.SetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 617753366))
        this.SetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) -222378256))
        this.SetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) 8741501))
        this.SetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) -601286203))
        this.SetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) -511433605))
        this.SetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -655387818))
        this.SetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) -282476598))
        this.SetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) 1739501925))
        this.SetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) 1178671645))
        this.SetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_IND_01r");
      if (Weapon.IsComponentActive((WeaponComponent) -1069552225))
        this.SetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) 11918884))
        this.SetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 176157112))
        this.SetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) -220052855))
        this.SetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) 288456487))
        this.SetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) 398658626))
        this.SetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) 628697006))
        this.SetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) 925911836))
        this.SetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) 1222307441))
        this.SetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) 552442715))
        this.SetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) -648943513))
        this.SetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) -996700057))
        this.SetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) 940943685))
        this.SetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 1263226800))
        this.SetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) -328035840))
        this.SetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) 1224100642))
        this.SetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) 899228776))
        this.SetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) 616006309))
        this.SetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -1561952511))
        this.SetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) 572063080))
        this.SetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) 1170588613))
        this.SetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) 966612367))
        this.SetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) 259780317))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) -403805974))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) -1973342474))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 691432737))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_02_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) 1996130345))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) 987648331))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_03_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) -1455657812))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) -431680535))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_04_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) -1668263084))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) -847582310))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_05_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) 1308243489))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) -92592218))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_06_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) 1122574335))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -494548326))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_07_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) 1420313469))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) 730876697))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_08_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) 109848390))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) 583159708))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_09_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) 593945703))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) -1928503603))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_10_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) 1142457062))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) 520557834))
        this.SetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_IND_01_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) -737430213))
        this.SetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) 1125852043))
        this.SetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 886015732))
        this.SetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) -1262287139))
        this.SetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) -295208411))
        this.SetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) -544154504))
        this.SetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) 172765678))
        this.SetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -1982877449))
        this.SetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) 2072122460))
        this.SetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) -1986220171))
        this.SetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_10");
      if (!Weapon.IsComponentActive((WeaponComponent) 1377355801))
        return;
      this.SetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_IND_01");
    }

    public int GetWeaponLivery(Weapon Weapon)
    {
      int num = 0;
      if (Weapon.IsComponentActive((WeaponComponent) -1860492113))
        num = this.GetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) 937772107))
        num = this.GetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 1401650071))
        num = this.GetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) 628662130))
        num = this.GetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) -985047251))
        num = this.GetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) -812944463))
        num = this.GetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) -1447352303))
        num = this.GetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -60338860))
        num = this.GetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) 2088750491))
        num = this.GetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) -1513913454))
        num = this.GetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) -1179558480))
        num = this.GetLivery("WEAPON_ASSAULTRIFLE_MK2", "COMPONENT_ASSAULTRIFLE_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) -979292288))
        num = this.GetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) -1371515465))
        num = this.GetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) -1190793877))
        num = this.GetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) -1497085720))
        num = this.GetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) -1803148180))
        num = this.GetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) -1975971886))
        num = this.GetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) -268444834))
        num = this.GetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -574769446))
        num = this.GetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) -882699739))
        num = this.GetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) -1468181474))
        num = this.GetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) -974541230))
        num = this.GetLivery("WEAPON_BULLPUPRIFLE_MK2", "COMPONENT_BULLPUPRIFLE_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) 1272803094))
        num = this.GetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) 1080719624))
        num = this.GetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 792221348))
        num = this.GetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) -452181427))
        num = this.GetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) -746774737))
        num = this.GetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) -2044296061))
        num = this.GetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) -199171978))
        num = this.GetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -1428075016))
        num = this.GetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) -1735153315))
        num = this.GetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) 1796459838))
        num = this.GetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) -631911105))
        num = this.GetLivery("WEAPON_CARBINERIFLE_MK2", "COMPONENT_CARBINERIFLE_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) 1249283253))
        num = this.GetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) -857707587))
        num = this.GetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) -1097543898))
        num = this.GetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) 1980349969))
        num = this.GetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) 1219453777))
        num = this.GetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) -1853459190))
        num = this.GetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) -2074781016))
        num = this.GetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) 457967755))
        num = this.GetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) 235171324))
        num = this.GetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) 42685294))
        num = this.GetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) -687617715))
        num = this.GetLivery("WEAPON_COMBATMG_MK2", "COMPONENT_COMBATMG_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) -130843390))
        num = this.GetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) -977347227))
        num = this.GetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) -1507009185))
        num = this.GetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) -378461067))
        num = this.GetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 329939175))
        num = this.GetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) 643374672))
        num = this.GetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) 807875052))
        num = this.GetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) -1401804168))
        num = this.GetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -847811454))
        num = this.GetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) -1413108537))
        num = this.GetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) 1815270123))
        num = this.GetLivery("WEAPON_HEAVYSNIPER_MK2", "COMPONENT_HEAVYSNIPER_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) -1869284448))
        num = this.GetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) 1931539634))
        num = this.GetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 1624199183))
        num = this.GetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) -26834113))
        num = this.GetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) -210406055))
        num = this.GetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) 423313640))
        num = this.GetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) 276639596))
        num = this.GetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -991356863))
        num = this.GetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) -1682848301))
        num = this.GetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) 996213771))
        num = this.GetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) -1214048550))
        num = this.GetLivery("WEAPON_MARKSMANRIFLE_MK2", "COMPONENT_MARKSMANRIFLE_MK2_CAMO_IND_01");
      int livery;
      if (Weapon.IsComponentActive((WeaponComponent) 1550611612))
      {
        livery = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_SLIDE");
        num = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO");
      }
      if (Weapon.IsComponentActive((WeaponComponent) 368550800))
      {
        livery = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_02_SLIDE");
        num = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_02");
      }
      if (Weapon.IsComponentActive((WeaponComponent) -1769069349))
      {
        livery = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_03_SLIDE");
        num = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_03");
      }
      if (Weapon.IsComponentActive((WeaponComponent) 24902297))
      {
        livery = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_04_SLIDE");
        num = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_04");
      }
      if (Weapon.IsComponentActive((WeaponComponent) -228041614))
      {
        livery = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_05_SLIDE");
        num = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_05");
      }
      if (Weapon.IsComponentActive((WeaponComponent) -584961562))
      {
        livery = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_06_SLIDE");
        num = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_06");
      }
      if (Weapon.IsComponentActive((WeaponComponent) -1153175946))
      {
        livery = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_07_SLIDE");
        num = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_07");
      }
      if (Weapon.IsComponentActive((WeaponComponent) 1301287696))
      {
        livery = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_08_SLIDE");
        num = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_08");
      }
      if (Weapon.IsComponentActive((WeaponComponent) 1597093459))
      {
        livery = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_09_SLIDE");
        num = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_09");
      }
      if (Weapon.IsComponentActive((WeaponComponent) 1769871776))
      {
        livery = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_10_SLIDE");
        num = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_10");
      }
      if (Weapon.IsComponentActive((WeaponComponent) -1827882671))
      {
        livery = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_IND_01_SLIDE");
        num = this.GetLivery("WEAPON_PISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_IND_01");
      }
      if (Weapon.IsComponentActive((WeaponComponent) -474112444))
        num = this.GetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) 387223451))
        num = this.GetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 617753366))
        num = this.GetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) -222378256))
        num = this.GetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) 8741501))
        num = this.GetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) -601286203))
        num = this.GetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) -511433605))
        num = this.GetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -655387818))
        num = this.GetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) -282476598))
        num = this.GetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) 1739501925))
        num = this.GetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) 1178671645))
        this.SetLivery("WEAPON_PUMPSHOTGUN_MK2", "COMPONENT_PUMPSHOTGUN_MK2_CAMO_IND_01r");
      if (Weapon.IsComponentActive((WeaponComponent) -1069552225))
        num = this.GetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) 11918884))
        num = this.GetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 176157112))
        num = this.GetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) -220052855))
        num = this.GetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) 288456487))
        num = this.GetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) 398658626))
        num = this.GetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) 628697006))
        num = this.GetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) 925911836))
        num = this.GetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) 1222307441))
        num = this.GetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) 552442715))
        num = this.GetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) -648943513))
        num = this.GetLivery("WEAPON_REVOLVER_MK2", "COMPONENT_REVOLVER_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) -996700057))
        num = this.GetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) 940943685))
        num = this.GetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 1263226800))
        num = this.GetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) -328035840))
        num = this.GetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) 1224100642))
        num = this.GetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) 899228776))
        num = this.GetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) 616006309))
        num = this.GetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -1561952511))
        num = this.GetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) 572063080))
        num = this.GetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) 1170588613))
        num = this.GetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) 966612367))
        num = this.GetLivery("WEAPON_SMG_MK2", "COMPONENT_SMG_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) 259780317))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) -403805974))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_PISTOL_MK2_CAMO_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) -1973342474))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 691432737))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_02_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) 1996130345))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) 987648331))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_03_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) -1455657812))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) -431680535))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_04_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) -1668263084))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) -847582310))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_05_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) 1308243489))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) -92592218))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_06_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) 1122574335))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -494548326))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_07_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) 1420313469))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) 730876697))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_08_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) 109848390))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) 583159708))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_09_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) 593945703))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) -1928503603))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_10_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) 1142457062))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_IND_01");
      if (Weapon.IsComponentActive((WeaponComponent) 520557834))
        num = this.GetLivery("WEAPON_SNSPISTOL_MK2", "COMPONENT_SNSPISTOL_MK2_CAMO_IND_01_SLIDE");
      if (Weapon.IsComponentActive((WeaponComponent) -737430213))
        num = this.GetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO");
      if (Weapon.IsComponentActive((WeaponComponent) 1125852043))
        num = this.GetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_02");
      if (Weapon.IsComponentActive((WeaponComponent) 886015732))
        num = this.GetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_03");
      if (Weapon.IsComponentActive((WeaponComponent) -1262287139))
        num = this.GetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_04");
      if (Weapon.IsComponentActive((WeaponComponent) -295208411))
        num = this.GetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_05");
      if (Weapon.IsComponentActive((WeaponComponent) -544154504))
        num = this.GetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_06");
      if (Weapon.IsComponentActive((WeaponComponent) 172765678))
        num = this.GetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_07");
      if (Weapon.IsComponentActive((WeaponComponent) -1982877449))
        num = this.GetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_08");
      if (Weapon.IsComponentActive((WeaponComponent) 2072122460))
        num = this.GetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_09");
      if (Weapon.IsComponentActive((WeaponComponent) -1986220171))
        num = this.GetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_10");
      if (Weapon.IsComponentActive((WeaponComponent) 1377355801))
        num = this.GetLivery("WEAPON_SPECIALCARBINE_MK2", "COMPONENT_SPECIALCARBINE_MK2_CAMO_IND_01");
      return num;
    }

    private void SetupWeapons()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      KosatkaScript.\u003C\u003Ec__DisplayClass235_0 displayClass2350 = new KosatkaScript.\u003C\u003Ec__DisplayClass235_0();
      // ISSUE: reference to a compiler-generated field
      displayClass2350.\u003C\u003E4__this = this;
      List<object> objectList1 = new List<object>();
      objectList1.Add((object) "Classic Black");
      objectList1.Add((object) "Classic Gray");
      objectList1.Add((object) "Classic Two-Tone");
      objectList1.Add((object) "Classic White");
      objectList1.Add((object) "Classic Beige");
      objectList1.Add((object) "Classic Green");
      objectList1.Add((object) "Classic Blue");
      objectList1.Add((object) "Classic Earth");
      objectList1.Add((object) "Classic Brown & Black");
      objectList1.Add((object) "Red Contrast");
      objectList1.Add((object) "Blue Contrast");
      objectList1.Add((object) "Yellow Contrast");
      objectList1.Add((object) "Orange Contrast");
      objectList1.Add((object) "Bold Pink");
      objectList1.Add((object) "Bold Purple & Yellow");
      objectList1.Add((object) "Bold Orange");
      objectList1.Add((object) "Bold Green & Purple");
      objectList1.Add((object) "Bold Red & Black");
      objectList1.Add((object) "Bold Green & Black");
      objectList1.Add((object) "Bold Cyan & Black");
      objectList1.Add((object) "Bold Yellow & Black");
      objectList1.Add((object) "Bold Red & White");
      objectList1.Add((object) "Bold Blue & White");
      objectList1.Add((object) "Metallic Gold");
      objectList1.Add((object) "Metallic Platinum");
      objectList1.Add((object) "Metallic Gray & Lilac");
      objectList1.Add((object) "Metallic Purple & Lime");
      objectList1.Add((object) "Metallic Red");
      objectList1.Add((object) "Metallic Green");
      objectList1.Add((object) "Metallic Blue");
      objectList1.Add((object) "Metallic White & Aqua");
      objectList1.Add((object) "Metallic Red & Yellow");
      List<object> objectList2 = new List<object>();
      objectList2.Add((object) "Grey");
      objectList2.Add((object) "Dark Grey");
      objectList2.Add((object) "Black");
      objectList2.Add((object) "White");
      objectList2.Add((object) "Blue ");
      objectList2.Add((object) "Cyan");
      objectList2.Add((object) "Aqua");
      objectList2.Add((object) "Cool Blue");
      objectList2.Add((object) "Dark Blue");
      objectList2.Add((object) "Royal Blue");
      objectList2.Add((object) "Plum");
      objectList2.Add((object) "Dark Purple");
      objectList2.Add((object) "Purple");
      objectList2.Add((object) "Red");
      objectList2.Add((object) "Wine Red");
      objectList2.Add((object) "Magenta");
      objectList2.Add((object) "Pink ");
      objectList2.Add((object) "Salmon");
      objectList2.Add((object) "Hot Pink");
      objectList2.Add((object) "Rust Orange ");
      objectList2.Add((object) "Brown");
      objectList2.Add((object) "Earth");
      objectList2.Add((object) "Orange");
      objectList2.Add((object) "Light Orange");
      objectList2.Add((object) "Dark Yellow");
      objectList2.Add((object) "Yellow");
      objectList2.Add((object) "Light Brown");
      objectList2.Add((object) "Lime Green");
      objectList2.Add((object) "Olive");
      objectList2.Add((object) "Moss");
      objectList2.Add((object) "Turquoise");
      objectList2.Add((object) "Dark Green");
      // ISSUE: reference to a compiler-generated field
      displayClass2350.CPrice = 34000f;
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Mk2Weapons = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Mk2Weapons.Add((object) (WeaponHash) 961495388);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Mk2Weapons.Add((object) (WeaponHash) -2066285827);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Mk2Weapons.Add((object) (WeaponHash) -86904375);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Mk2Weapons.Add((object) (WeaponHash) -608341376);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Mk2Weapons.Add((object) (WeaponHash) 177293209);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Mk2Weapons.Add((object) (WeaponHash) 1785463520);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Mk2Weapons.Add((object) (WeaponHash) -1075685676);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Mk2Weapons.Add((object) (WeaponHash) 1432025498);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Mk2Weapons.Add((object) (WeaponHash) -879347409);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Mk2Weapons.Add((object) (WeaponHash) 2024373456);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Mk2Weapons.Add((object) (WeaponHash) -2009644972);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Mk2Weapons.Add((object) (WeaponHash) -1768145561);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Components = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Components.Add((object) (WeaponComponent) -1101075946);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Components.Add((object) (WeaponComponent) -1323216997);
      UIMenu uiMenu1 = this.modMenuPool.AddSubMenu(this.weaponsMenu, "Mk2 Weapons (Advanced)");
      this.GUIMenus.Add(uiMenu1);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass2350.W = new UIMenuListItem("Weapon : ", displayClass2350.Mk2Weapons, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass2350.W);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass2350.C = new UIMenuListItem("Component  : ", displayClass2350.Components, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass2350.C);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Enable = new UIMenuItem("Enable Component : $" + displayClass2350.CPrice.ToString("N"));
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass2350.Enable);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.DIsable = new UIMenuItem("Disable Component");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass2350.DIsable);
      UIMenuItem uiMenuItem1 = new UIMenuItem("-------------------------------------------------------------");
      uiMenu1.AddItem(uiMenuItem1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.WT = new UIMenuListItem("Tint ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass2350.WT);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.getTintAV = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass2350.getTintAV);
      UIMenuItem uiMenuItem2 = new UIMenuItem("-------------------------------------------------------------");
      uiMenu1.AddItem(uiMenuItem2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.WT2 = new UIMenuListItem("Livery Tint ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass2350.WT2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.getTintAV2 = new UIMenuItem("Buy Livery Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass2350.getTintAV2);
      // ISSUE: method pointer
      uiMenu1.OnListChange += new ListChangedEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__0));
      // ISSUE: method pointer
      uiMenu1.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__1));
      UIMenu uiMenu2 = this.modMenuPool.AddSubMenu(this.weaponsMenu, "Scifi Weapons");
      this.GUIMenus.Add(uiMenu2);
      UIMenu uiMenu3 = this.modMenuPool.AddSubMenu(this.weaponsMenu, "Mk2 Weapons");
      this.GUIMenus.Add(uiMenu3);
      UIMenu uiMenu4 = this.modMenuPool.AddSubMenu(this.weaponsMenu, "Normal Weapons");
      this.GUIMenus.Add(uiMenu4);
      List<object> objectList3 = new List<object>();
      for (int index = 0; index < this.Tintscount; ++index)
        objectList3.Add((object) index);
      this.MK2Pumpshotgun = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Pump Shotgun");
      this.GUIMenus.Add(this.MK2Pumpshotgun);
      this.MK2Pumpshotgun = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Pump Shotgun");
      this.MK2SNSPistol = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 SNS Pistol");
      this.GUIMenus.Add(this.MK2SNSPistol);
      this.MK2SNSPistol = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 SNS Pistol");
      this.MK2Revolver = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Revolver");
      this.GUIMenus.Add(this.MK2Revolver);
      this.MK2Revolver = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Revolver");
      this.Mk2SpecialCarbine = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Special Carbine");
      this.GUIMenus.Add(this.Mk2SpecialCarbine);
      this.Mk2SpecialCarbine = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Special Carbine");
      this.MK2Bullpup = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Bullpup Rifle");
      this.GUIMenus.Add(this.MK2Bullpup);
      this.MK2Bullpup = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Bullpup Rifle");
      this.MK2MarksmanRifle = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Marksmans Rifle");
      this.GUIMenus.Add(this.MK2MarksmanRifle);
      this.MK2MarksmanRifle = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Marksmans Rifle");
      this.MK2Pistol = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Pistol");
      this.GUIMenus.Add(this.MK2Pistol);
      this.MK2Pistol = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Pistol");
      this.MK2SMG = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 SMG");
      this.GUIMenus.Add(this.MK2SMG);
      this.MK2SMG = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 SMG");
      this.MK2LMG = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 LMG");
      this.GUIMenus.Add(this.MK2LMG);
      this.MK2LMG = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 LMG");
      this.MK2Carbine = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Carbine");
      this.GUIMenus.Add(this.MK2Carbine);
      this.MK2Carbine = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Carbine");
      this.MK2AssaultRifle = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Assault Rifle");
      this.GUIMenus.Add(this.MK2AssaultRifle);
      this.MK2AssaultRifle = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Assault Rifle");
      this.MK2Sniper = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Sniper");
      this.GUIMenus.Add(this.MK2Sniper);
      this.MK2Sniper = this.modMenuPool.AddSubMenu(uiMenu3, "MK2 Sniper");
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2ShotgunP = new UIMenuItem("MK2 Pump Shotgun: $75,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(displayClass2350.mk2ShotgunP);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Shotgunclip = new UIMenuItem("Normal Shells : $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(displayClass2350.mk2Shotgunclip);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Shotgunclip1 = new UIMenuItem("Dragon's Breath Shells : $65,200");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(displayClass2350.mk2Shotgunclip1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Shotgunclip3 = new UIMenuItem("Flechette Shells: $75,140");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(displayClass2350.mk2Shotgunclip3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Shotgunclip2 = new UIMenuItem("Steel Buckshot Shells: $96,645");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(displayClass2350.mk2Shotgunclip2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Shotgunclip4 = new UIMenuItem("Explosive Shells: $145,850");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(displayClass2350.mk2Shotgunclip4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Shotgunsights = new UIMenuItem("Holographic Sight: $29,260");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(displayClass2350.mk2Shotgunsights);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Shotgunsights2 = new UIMenuItem("Small Scope: $39,920");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(displayClass2350.mk2Shotgunsights2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Shotgunsights3 = new UIMenuItem("Medium Scope: $50,785");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(displayClass2350.mk2Shotgunsights3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Shotgunflashlight = new UIMenuItem("Flashlight: $10,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(displayClass2350.mk2Shotgunflashlight);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2ShotgunSuppressor = new UIMenuItem("Suppressor: $45,860");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(displayClass2350.mk2ShotgunSuppressor);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Shotgunmuzzle = new UIMenuItem("Muzzle Brake: $37,650");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(displayClass2350.mk2Shotgunmuzzle);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.list1 = new UIMenuListItem("Tint ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem((UIMenuItem) displayClass2350.list1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.getTint1 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pumpshotgun.AddItem(displayClass2350.getTint1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Snspistol = new UIMenuItem("MK2 SNS Pistol: $35,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(displayClass2350.mk2Snspistol);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Snspistolclipn = new UIMenuItem("Default Clip: $8,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(displayClass2350.mk2Snspistolclipn);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Snspistolclipe = new UIMenuItem("Extended Clip: $18,300");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(displayClass2350.mk2Snspistolclipe);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Snspistolclip1 = new UIMenuItem("Tracer Rounds: $34,320");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(displayClass2350.mk2Snspistolclip1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Snspistolclip2 = new UIMenuItem("Incendiary Rounds: $41,700");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(displayClass2350.mk2Snspistolclip2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Snspistolclip3 = new UIMenuItem("Hollow Point Rounds : $47,580");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(displayClass2350.mk2Snspistolclip3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Snspistolclip4 = new UIMenuItem("Full Metal Jacket Rounds: $62,400");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(displayClass2350.mk2Snspistolclip4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Snspistolflash = new UIMenuItem("Flashlight: $7,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(displayClass2350.mk2Snspistolflash);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Snspistolscope1 = new UIMenuItem("Mounted Scope: $16,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(displayClass2350.mk2Snspistolscope1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Snspistolsuppressor = new UIMenuItem("Suppressor: $28,750");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(displayClass2350.mk2Snspistolsuppressor);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Snspistolcomp = new UIMenuItem("Compensator: $21,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(displayClass2350.mk2Snspistolcomp);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.list2 = new UIMenuListItem("Tint ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem((UIMenuItem) displayClass2350.list2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.getTint2 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2SNSPistol.AddItem(displayClass2350.getTint2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Revolver = new UIMenuItem("MK2 Revolver: $35,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(displayClass2350.mk2Revolver);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Revolverclip = new UIMenuItem("Normal Rounds: $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(displayClass2350.mk2Revolverclip);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Revolverclip1 = new UIMenuItem("Tracer Rounds: $31,460");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(displayClass2350.mk2Revolverclip1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Revolverclip2 = new UIMenuItem("Incendiary Rounds: $38,225");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(displayClass2350.mk2Revolverclip2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Revolverclip3 = new UIMenuItem("Hollow Point Rounds: $43,615");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(displayClass2350.mk2Revolverclip3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Revolverclip4 = new UIMenuItem("Full Metal Jacket Rounds: $57,200");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(displayClass2350.mk2Revolverclip4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Revolversights = new UIMenuItem("Holographic Sight: $16,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(displayClass2350.mk2Revolversights);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Revolversights1 = new UIMenuItem("Small Scope: $25,450");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(displayClass2350.mk2Revolversights1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Revolverflashlight = new UIMenuItem("Flashlight: $7,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(displayClass2350.mk2Revolverflashlight);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2RevolverComp = new UIMenuItem("Compensator: $21,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(displayClass2350.mk2RevolverComp);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.list3 = new UIMenuListItem("Tint ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem((UIMenuItem) displayClass2350.list3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.getTint3 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Revolver.AddItem(displayClass2350.getTint3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2SCarbine = new UIMenuItem("MK2 Special Carbine: $65,000");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(displayClass2350.mk2SCarbine);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2SCarbineclip = new UIMenuItem("Default Clip: $5,000");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(displayClass2350.mk2SCarbineclip);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2SCarbineclip1 = new UIMenuItem("Extended Clip: $26,450");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(displayClass2350.mk2SCarbineclip1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2SCarbineclip2 = new UIMenuItem("Tracer Rounds: $61,465");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(displayClass2350.mk2SCarbineclip2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2SCarbineclip3 = new UIMenuItem("Incendiary Rounds : $70,950");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(displayClass2350.mk2SCarbineclip3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2SCarbineclip4 = new UIMenuItem("Armor Piercing Rounds : $90,750");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(displayClass2350.mk2SCarbineclip4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2SCarbineclip5 = new UIMenuItem("Full Metal Jacket Rounds : $104,775");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(displayClass2350.mk2SCarbineclip5);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2SCarbineflash = new UIMenuItem("Flashlight: $10,500");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(displayClass2350.mk2SCarbineflash);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2SCarbinesight1 = new UIMenuItem("Holographic Sight: $19,600");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(displayClass2350.mk2SCarbinesight1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2SCarbinesight2 = new UIMenuItem("Small Scope: $23,730");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(displayClass2350.mk2SCarbinesight2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2SCarbinesight3 = new UIMenuItem("Large Scope: $34,020");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(displayClass2350.mk2SCarbinesight3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2SCarbinesupressor = new UIMenuItem("Suppressor : $40,250");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(displayClass2350.mk2SCarbinesupressor);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2SCarbinemuzzle = new UIMenuItem("Muzzle : $29,750");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(displayClass2350.mk2SCarbinemuzzle);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2SCarbinegrip = new UIMenuItem("Grip : $14,080");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(displayClass2350.mk2SCarbinegrip);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.list4 = new UIMenuListItem("Tint ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem((UIMenuItem) displayClass2350.list4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.getTint4 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.Mk2SpecialCarbine.AddItem(displayClass2350.getTint4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Bullpup = new UIMenuItem("MK2 Bullpup Rifle: $60,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.mk2Bullpup);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Bullpupclip1 = new UIMenuItem("Default Clip : $5,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.mk2Bullpupclip1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Bullpupclip2 = new UIMenuItem("Extended Clip : $22,100");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.mk2Bullpupclip2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Bullpupclip3 = new UIMenuItem("Tracer Rounds : $44,350");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.mk2Bullpupclip3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Bullpupclip4 = new UIMenuItem("Incendiary Rounds : $52,100");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.mk2Bullpupclip4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Bullpupclip5 = new UIMenuItem("Armor Piercing Rounds  : $87,320");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.mk2Bullpupclip5);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Bullpupclip6 = new UIMenuItem("Full Metal Jacket Rounds : $77,490");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.mk2Bullpupclip6);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Bullpupflash = new UIMenuItem("Flashlight  : $10,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.mk2Bullpupflash);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Bullpupsight1 = new UIMenuItem("Holographic Sight : $19,600");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.mk2Bullpupsight1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Bullpupsight2 = new UIMenuItem("Small Scope : $23,730");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.mk2Bullpupsight2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Bullpupsight3 = new UIMenuItem("Medium Scope : $34,020");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.mk2Bullpupsight3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2BullpupBarrel = new UIMenuItem("Heavy Barrel : $49,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.mk2BullpupBarrel);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2BullpupGrip = new UIMenuItem("Grip : $14,080");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.mk2BullpupGrip);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2Bullpupmuzzle = new UIMenuItem("Muzzle  : $29,750");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.mk2Bullpupmuzzle);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2BullpupSuppressor = new UIMenuItem("Suppressor  : $40,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.mk2BullpupSuppressor);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.list5 = new UIMenuListItem("Tint ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem((UIMenuItem) displayClass2350.list5);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.getTint5 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Bullpup.AddItem(displayClass2350.getTint5);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2marksman = new UIMenuItem("MK2 Marksman Rifle : $80,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(displayClass2350.mk2marksman);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2marksmanclip1 = new UIMenuItem("Default Clip : $5,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(displayClass2350.mk2marksmanclip1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2marksmanclip2 = new UIMenuItem("Extended Clip : $26,850");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(displayClass2350.mk2marksmanclip2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2marksmanclip3 = new UIMenuItem("Tracer Rounds : $49,775");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(displayClass2350.mk2marksmanclip3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2marksmanclip4 = new UIMenuItem("Incendiary Rounds : $57,295");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(displayClass2350.mk2marksmanclip4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2marksmanclip5 = new UIMenuItem("Armor Piercing Rounds  : $73,560");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(displayClass2350.mk2marksmanclip5);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2marksmanclip6 = new UIMenuItem("Full Metal Jacket Rounds : $85,570");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(displayClass2350.mk2marksmanclip6);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2marksmanflash = new UIMenuItem("Flashlight  : $11,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(displayClass2350.mk2marksmanflash);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2marksmansight1 = new UIMenuItem("Holographic Sight  : $11,485");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(displayClass2350.mk2marksmansight1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2marksmansight2 = new UIMenuItem("Large Scope  : $17,870");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(displayClass2350.mk2marksmansight2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2marksmansight3 = new UIMenuItem("Zoom Scope  : $27,150");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(displayClass2350.mk2marksmansight3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2marksmanGrip = new UIMenuItem("Grip  : $14,080");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(displayClass2350.mk2marksmanGrip);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2marksmanmuzzle = new UIMenuItem("Muzzle  : $44,620");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(displayClass2350.mk2marksmanmuzzle);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2marksmanSuppressor = new UIMenuItem("Suppressor  : $60,375");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(displayClass2350.mk2marksmanSuppressor);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.list6 = new UIMenuListItem("Tint ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem((UIMenuItem) displayClass2350.list6);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.getTint6 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2MarksmanRifle.AddItem(displayClass2350.getTint6);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2pistol = new UIMenuItem("MK2 Pistol : $20,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(displayClass2350.mk2pistol);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2pistolClip = new UIMenuItem("Default Clip : $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(displayClass2350.mk2pistolClip);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2pistolClip1 = new UIMenuItem("Extended Clip : $15,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(displayClass2350.mk2pistolClip1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2pistolClip2 = new UIMenuItem("Tracer Rounds : $32,850");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(displayClass2350.mk2pistolClip2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2pistolClip3 = new UIMenuItem("Incendiary Rounds : $34,750");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(displayClass2350.mk2pistolClip3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2pistolClip4 = new UIMenuItem("Hollow Point Rounds : $39,650");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(displayClass2350.mk2pistolClip4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2pistolClip5 = new UIMenuItem("Full Metal Jacket Rounds  : $52,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(displayClass2350.mk2pistolClip5);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2pistolSight1 = new UIMenuItem("Mounted Scope : $16,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(displayClass2350.mk2pistolSight1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2pistolflash = new UIMenuItem("Flashlight : $7,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(displayClass2350.mk2pistolflash);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2pistolsupp = new UIMenuItem("Suppressor : $28,750");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(displayClass2350.mk2pistolsupp);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2pistolcomp = new UIMenuItem("Compensator : $21,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(displayClass2350.mk2pistolcomp);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.list7 = new UIMenuListItem("Tint ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem((UIMenuItem) displayClass2350.list7);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.getTint7 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Pistol.AddItem(displayClass2350.getTint7);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2smg = new UIMenuItem("MK2 SMG : $25,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(displayClass2350.mk2smg);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2smgclip = new UIMenuItem("Default Clip : $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(displayClass2350.mk2smgclip);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2smgclip1 = new UIMenuItem("Extended Clip : $18,300");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(displayClass2350.mk2smgclip1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2smgClip2 = new UIMenuItem("Tracer Rounds : $28,600");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(displayClass2350.mk2smgClip2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2smgClip3 = new UIMenuItem("Incendiary Rounds : $34,750");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(displayClass2350.mk2smgClip3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2smgClip4 = new UIMenuItem("Hollow Point Rounds : $39,650");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(displayClass2350.mk2smgClip4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2smgClip5 = new UIMenuItem("Full Metal Jacket Rounds  : $52,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(displayClass2350.mk2smgClip5);
      this.MK2SMG.AddItem(new UIMenuItem("Flashlight : $7,500"));
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2smgsight1 = new UIMenuItem("Holographic Sight : $15,200");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(displayClass2350.mk2smgsight1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2smgsight2 = new UIMenuItem("Small Scope: $19,950");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(displayClass2350.mk2smgsight2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2smgsight3 = new UIMenuItem("Holographic Sight : $24,100");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(displayClass2350.mk2smgsight3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2smgsupp = new UIMenuItem("Suppressor  : $34,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(displayClass2350.mk2smgsupp);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2smgmuzzle = new UIMenuItem("Muzzle : $25,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(displayClass2350.mk2smgmuzzle);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2smgbarrel = new UIMenuItem("Barrel : $22,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(displayClass2350.mk2smgbarrel);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.list8 = new UIMenuListItem("Tint ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem((UIMenuItem) displayClass2350.list8);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.getTint8 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2SMG.AddItem(displayClass2350.getTint8);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2carbine = new UIMenuItem("MK2 Carbine : $35,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(displayClass2350.mk2carbine);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2carbineClip1 = new UIMenuItem("Default Clip: $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(displayClass2350.mk2carbineClip1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2carbineClip2 = new UIMenuItem("Extended Clip: $25,925");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(displayClass2350.mk2carbineClip2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2carbineClip3 = new UIMenuItem("Tracer Rounds: $44,700");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(displayClass2350.mk2carbineClip3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2carbineClip4 = new UIMenuItem("Incendiary Rounds : $51,600");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(displayClass2350.mk2carbineClip4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2carbineClip5 = new UIMenuItem("Armor Piercing Rounds: $66,000 ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(displayClass2350.mk2carbineClip5);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2carbineClip6 = new UIMenuItem("Full Metal Jacket Rounds: $76,200 ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(displayClass2350.mk2carbineClip6);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2carbineGrip = new UIMenuItem("Grip: $14,080 ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(displayClass2350.mk2carbineGrip);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2carbineFlash = new UIMenuItem("Flashlight: $10,500 ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(displayClass2350.mk2carbineFlash);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2carbineSight1 = new UIMenuItem("Holographic Sight: $19,600  ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(displayClass2350.mk2carbineSight1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2carbineSight2 = new UIMenuItem("Small Scope: $23,730 ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(displayClass2350.mk2carbineSight2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2carbineSight3 = new UIMenuItem("Large Scope: $34,020 ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(displayClass2350.mk2carbineSight3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2carbineSupp = new UIMenuItem("Suppressor: $40,250 ");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(displayClass2350.mk2carbineSupp);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.list9 = new UIMenuListItem("Tint ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem((UIMenuItem) displayClass2350.list9);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.getTint9 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Carbine.AddItem(displayClass2350.getTint9);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2AR = new UIMenuItem("MK2 Assault Rifle : $30,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(displayClass2350.mk2AR);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2ARClip1 = new UIMenuItem("Default Clip : $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(displayClass2350.mk2ARClip1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2ARClip2 = new UIMenuItem("Extended Clip: $22,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(displayClass2350.mk2ARClip2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2ARClip3 = new UIMenuItem("Tracer Rounds  : $42,700");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(displayClass2350.mk2ARClip3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2ARClip4 = new UIMenuItem("Incendiary Rounds  : $49,400");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(displayClass2350.mk2ARClip4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2ARClip5 = new UIMenuItem("Armor Piercing Rounds : $63,200");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(displayClass2350.mk2ARClip5);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2ARClip6 = new UIMenuItem("Full Metal Jacket Rounds  : $73,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(displayClass2350.mk2ARClip6);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2ARClipFlash = new UIMenuItem("Flashlight : $10,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(displayClass2350.mk2ARClipFlash);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2ARClipSight1 = new UIMenuItem("Holographic Sight : $19,600");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(displayClass2350.mk2ARClipSight1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2ARClipSight2 = new UIMenuItem("Small Scope : $23,730");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(displayClass2350.mk2ARClipSight2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2ARClipSight3 = new UIMenuItem("Large Scope : $33,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(displayClass2350.mk2ARClipSight3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2ARClipGrip = new UIMenuItem("Grip : $14,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(displayClass2350.mk2ARClipGrip);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2ARsuppressor = new UIMenuItem("Suppressor : $40,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(displayClass2350.mk2ARsuppressor);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.list10 = new UIMenuListItem("Tint ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem((UIMenuItem) displayClass2350.list10);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.getTint10 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2AssaultRifle.AddItem(displayClass2350.getTint10);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2lmg = new UIMenuItem("MK2 LMG : $95,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(displayClass2350.mk2lmg);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2lmgClip1 = new UIMenuItem("Default Clip : $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(displayClass2350.mk2lmgClip1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2lmgClip2 = new UIMenuItem("Extended Clip : $28,975");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(displayClass2350.mk2lmgClip2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2lmgClip3 = new UIMenuItem("Tracer Rounds : $57,100");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(displayClass2350.mk2lmgClip3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2lmgClip4 = new UIMenuItem("Incendiary Rounds : $64,650");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(displayClass2350.mk2lmgClip4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2lmgClip5 = new UIMenuItem("Armor Piercing Rounds : $82,550");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(displayClass2350.mk2lmgClip5);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2lmgClip6 = new UIMenuItem("Full Metal Jacket Rounds  : $94,950");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(displayClass2350.mk2lmgClip6);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2lmgGrip = new UIMenuItem("Grip : $20,180");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(displayClass2350.mk2lmgGrip);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2lmgSight1 = new UIMenuItem("Holographic Sight : $26,600");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(displayClass2350.mk2lmgSight1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2lmgSight2 = new UIMenuItem("Small Scope : $36,290");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(displayClass2350.mk2lmgSight2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2lmgSight3 = new UIMenuItem("Large Scope : $46,170");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(displayClass2350.mk2lmgSight3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2lmgMuzzle = new UIMenuItem("Flat Muzzle Brake : $40,375");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(displayClass2350.mk2lmgMuzzle);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2lmgBarrel = new UIMenuItem("Heavy Barrel : $66,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(displayClass2350.mk2lmgBarrel);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.list11 = new UIMenuListItem("Tint ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem((UIMenuItem) displayClass2350.list11);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.getTint11 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2LMG.AddItem(displayClass2350.getTint11);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2sniper = new UIMenuItem("MK2 Heavy Sniper : $100,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(displayClass2350.mk2sniper);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2sniperClip1 = new UIMenuItem("Default Clip : $0");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(displayClass2350.mk2sniperClip1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2sniperClip2 = new UIMenuItem("Extended Clip : $35,025");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(displayClass2350.mk2sniperClip2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2sniperClip3 = new UIMenuItem("Incendiary Rounds : $59,275");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(displayClass2350.mk2sniperClip3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2sniperClip4 = new UIMenuItem("Armor Piercing Rounds : $76,100");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(displayClass2350.mk2sniperClip4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2sniperClip5 = new UIMenuItem("Full Metal Jacket Rounds : $88,525");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(displayClass2350.mk2sniperClip5);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2sniperClip6 = new UIMenuItem("Explosive Rounds : $115,450");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(displayClass2350.mk2sniperClip6);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2sniperSight1 = new UIMenuItem("Zoom scope : $20.200");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(displayClass2350.mk2sniperSight1);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2sniperSight2 = new UIMenuItem("Advanced Scope : $32,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(displayClass2350.mk2sniperSight2);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2sniperSight3 = new UIMenuItem("Night Vision Scope : $57,400");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(displayClass2350.mk2sniperSight3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2sniperSight4 = new UIMenuItem("Thermal Scope : $69,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(displayClass2350.mk2sniperSight4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2sniperSupp = new UIMenuItem("Suppressor : $40,250");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(displayClass2350.mk2sniperSupp);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2sniperMuzzle = new UIMenuItem("Bell-End Muzzle Brake : $57,790");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(displayClass2350.mk2sniperMuzzle);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.mk2sniperBarrel = new UIMenuItem("Heavy Barrel : $27,500");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(displayClass2350.mk2sniperBarrel);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.list12 = new UIMenuListItem("Tint ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem((UIMenuItem) displayClass2350.list12);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.getTint12 = new UIMenuItem("Buy Tint: $10,000");
      // ISSUE: reference to a compiler-generated field
      this.MK2Sniper.AddItem(displayClass2350.getTint12);
      List<object> objectList4 = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass2350.allweaponhashes = (WeaponHash[]) Enum.GetValues(typeof (WeaponHash));
      // ISSUE: reference to a compiler-generated field
      for (int index = 0; index < displayClass2350.allweaponhashes.Length; ++index)
      {
        // ISSUE: reference to a compiler-generated field
        objectList4.Add((object) (WeaponHash) (int) (uint) displayClass2350.allweaponhashes[index]);
      }
      // ISSUE: reference to a compiler-generated field
      displayClass2350.list = new UIMenuListItem("Weapon: ", objectList4, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem((UIMenuItem) displayClass2350.list);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.getWeapon = new UIMenuItem("Buy Weapon : $10000");
      // ISSUE: reference to a compiler-generated field
      uiMenu4.AddItem(displayClass2350.getWeapon);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.RayGun = new UIMenuItem("Ray Gun : $100,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass2350.RayGun);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.UnholyHellbringer = new UIMenuItem("UnholyHellbringer : $250,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass2350.UnholyHellbringer);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.Widowmaker = new UIMenuItem("Widowmaker : $1,000,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass2350.Widowmaker);
      // ISSUE: method pointer
      uiMenu4.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__2));
      // ISSUE: method pointer
      uiMenu2.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__3));
      // ISSUE: method pointer
      this.MK2Sniper.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__4));
      // ISSUE: method pointer
      this.MK2LMG.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__5));
      // ISSUE: method pointer
      this.MK2Carbine.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__6));
      // ISSUE: method pointer
      this.MK2SMG.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__7));
      // ISSUE: method pointer
      this.MK2AssaultRifle.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__8));
      // ISSUE: method pointer
      this.MK2Pistol.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__9));
      // ISSUE: method pointer
      this.MK2Pumpshotgun.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__10));
      // ISSUE: method pointer
      this.MK2SNSPistol.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__11));
      // ISSUE: method pointer
      this.MK2Revolver.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__12));
      // ISSUE: method pointer
      this.Mk2SpecialCarbine.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__13));
      // ISSUE: method pointer
      this.MK2Bullpup.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__14));
      // ISSUE: method pointer
      this.MK2MarksmanRifle.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__15));
      UIMenu uiMenu5 = this.modMenuPool.AddSubMenu(this.weaponsMenu, "Cayo Perico Weapons");
      this.GUIMenus.Add(uiMenu5);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.PPistol = new UIMenuItem("Perico Pistol : $1,100,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass2350.PPistol);
      UIMenuItem uiMenuItem3 = new UIMenuItem("-------------------------------------------------------------");
      uiMenu5.AddItem(uiMenuItem3);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.MilitaryRifle = new UIMenuItem("Military Rifle : $397,500");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass2350.MilitaryRifle);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.MRDefaultClip = new UIMenuItem("Default Clip : $9,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass2350.MRDefaultClip);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.MRExtendedClip = new UIMenuItem("Extended Clip : $42,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass2350.MRExtendedClip);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.MRIronSights = new UIMenuItem("IronSights : $13,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass2350.MRIronSights);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.MRScope = new UIMenuItem("Scope : $15,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass2350.MRScope);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.MRFlash = new UIMenuItem("Flashlight : $23,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass2350.MRFlash);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.MRSupp = new UIMenuItem("Suppressor : $25,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass2350.MRSupp);
      UIMenuItem uiMenuItem4 = new UIMenuItem("-------------------------------------------------------------");
      uiMenu5.AddItem(uiMenuItem4);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.CShotgun = new UIMenuItem("Combat Shotgun : $295,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass2350.CShotgun);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.CSFlash = new UIMenuItem("Flashlight : $29,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass2350.CSFlash);
      // ISSUE: reference to a compiler-generated field
      displayClass2350.CSSupp = new UIMenuItem("Suppressor : $35,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu5.AddItem(displayClass2350.CSSupp);
      // ISSUE: method pointer
      uiMenu5.OnItemSelect += new ItemSelectEvent((object) displayClass2350, __methodptr(\u003CSetupWeapons\u003Eb__16));
    }

    public void ShowSubControlls()
    {
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL", Array.Empty<object>());
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", new object[1]
      {
        (object) 0
      });
      scaleform.CallFunction("CREATE_CONTAINER", Array.Empty<object>());
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 0,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(131),
          InputArgument.op_Implicit(0)
        }),
        (object) "Surface"
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 1,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(132),
          InputArgument.op_Implicit(0)
        }),
        (object) "Dive"
      });
      if (Game.CurrentInputMode == 0)
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 2,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(51),
            InputArgument.op_Implicit(0)
          }),
          (object) "Periscope"
        });
      if (Game.CurrentInputMode == 1)
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 2,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(44),
            InputArgument.op_Implicit(0)
          }),
          (object) "Periscope"
        });
      if (Game.CurrentInputMode == 0)
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 3,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(25),
            InputArgument.op_Implicit(0)
          }),
          (object) "Fire Torpedo"
        });
      if (Game.CurrentInputMode == 1)
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 3,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(80),
            InputArgument.op_Implicit(0)
          }),
          (object) "Fire Torpedo"
        });
      if (this.UsingPeriscope)
        ;
      if (this.UsingPeriscope)
      {
        if (!this.PeriscopeUseMouseMovement)
        {
          scaleform.CallFunction("SET_DATA_SLOT", new object[3]
          {
            (object) 4,
            (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(175),
              InputArgument.op_Implicit(0)
            }),
            (object) "Periscope Right"
          });
          scaleform.CallFunction("SET_DATA_SLOT", new object[3]
          {
            (object) 5,
            (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(174),
              InputArgument.op_Implicit(0)
            }),
            (object) "Periscope Left"
          });
        }
        if (this.PeriscopeUseMouseMovement)
        {
          scaleform.CallFunction("SET_DATA_SLOT", new object[3]
          {
            (object) 4,
            (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(1),
              InputArgument.op_Implicit(0)
            }),
            (object) "Periscope Left/Right"
          });
          scaleform.CallFunction("SET_DATA_SLOT", new object[3]
          {
            (object) 5,
            (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(0)
            }),
            (object) "Periscope Up/Down"
          });
        }
      }
      if (this.SonarStation == 1 && !this.UsingPeriscope)
      {
        if (Game.CurrentInputMode == 0)
          scaleform.CallFunction("SET_DATA_SLOT", new object[3]
          {
            (object) 6,
            (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(73),
              InputArgument.op_Implicit(0)
            }),
            (object) "Toggle Sonar"
          });
        if (Game.CurrentInputMode == 1)
          scaleform.CallFunction("SET_DATA_SLOT", new object[3]
          {
            (object) 6,
            (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(36),
              InputArgument.op_Implicit(0)
            }),
            (object) "Toggle Sonar"
          });
      }
      if (this.HoldToEnterInterior)
      {
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 7,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(75),
            InputArgument.op_Implicit(0)
          }),
          (object) "(Hold) Exit"
        });
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 8,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(75),
            InputArgument.op_Implicit(0)
          }),
          (object) "(Press) Enter Interior  "
        });
      }
      if (!this.HoldToEnterInterior)
      {
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 7,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(75),
            InputArgument.op_Implicit(0)
          }),
          (object) "(Press) Exit"
        });
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 8,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(75),
            InputArgument.op_Implicit(0)
          }),
          (object) "(Hold) Enter Interior  "
        });
      }
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", new object[1]
      {
        (object) -1
      });
      scaleform.Render2D();
    }

    public void ShowSubControlls2()
    {
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL", Array.Empty<object>());
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", new object[1]
      {
        (object) 0
      });
      scaleform.CallFunction("CREATE_CONTAINER", Array.Empty<object>());
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 0,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(131),
          InputArgument.op_Implicit(0)
        }),
        (object) "Surface"
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 1,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(132),
          InputArgument.op_Implicit(0)
        }),
        (object) "Dive"
      });
      if (Game.CurrentInputMode == 0)
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 3,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(25),
            InputArgument.op_Implicit(0)
          }),
          (object) "Fire Torpedo"
        });
      if (Game.CurrentInputMode == 1)
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 3,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(47),
            InputArgument.op_Implicit(0)
          }),
          (object) "Fire Torpedo"
        });
      if (this.UsingPeriscope)
      {
        if (!this.PeriscopeUseMouseMovement)
        {
          scaleform.CallFunction("SET_DATA_SLOT", new object[3]
          {
            (object) 4,
            (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(175),
              InputArgument.op_Implicit(0)
            }),
            (object) "Periscope Right"
          });
          scaleform.CallFunction("SET_DATA_SLOT", new object[3]
          {
            (object) 5,
            (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(174),
              InputArgument.op_Implicit(0)
            }),
            (object) "Periscope Left"
          });
        }
        if (this.PeriscopeUseMouseMovement)
        {
          scaleform.CallFunction("SET_DATA_SLOT", new object[3]
          {
            (object) 4,
            (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(1),
              InputArgument.op_Implicit(0)
            }),
            (object) "Periscope Left/Right"
          });
          scaleform.CallFunction("SET_DATA_SLOT", new object[3]
          {
            (object) 5,
            (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(0)
            }),
            (object) "Periscope Up/Down"
          });
        }
      }
      if (this.SonarStation == 1)
      {
        if (Game.CurrentInputMode == 0)
          scaleform.CallFunction("SET_DATA_SLOT", new object[3]
          {
            (object) 6,
            (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(73),
              InputArgument.op_Implicit(0)
            }),
            (object) "Toggle Sonar"
          });
        if (Game.CurrentInputMode == 1)
          scaleform.CallFunction("SET_DATA_SLOT", new object[3]
          {
            (object) 6,
            (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(36),
              InputArgument.op_Implicit(0)
            }),
            (object) "Toggle Sonar"
          });
      }
      if (this.HoldToEnterInterior)
      {
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 7,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(75),
            InputArgument.op_Implicit(0)
          }),
          (object) "(Hold) Exit"
        });
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 8,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(75),
            InputArgument.op_Implicit(0)
          }),
          (object) "(Press) Enter Interior  "
        });
      }
      if (!this.HoldToEnterInterior)
      {
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 7,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(75),
            InputArgument.op_Implicit(0)
          }),
          (object) "(Press) Exit"
        });
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 8,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(75),
            InputArgument.op_Implicit(0)
          }),
          (object) "(Hold) Enter Interior  "
        });
      }
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", new object[1]
      {
        (object) -1
      });
      scaleform.Render2D();
    }

    private Vector2 World3DToScreen2d(Vector3 pos)
    {
      OutputArgument outputArgument1 = new OutputArgument();
      OutputArgument outputArgument2 = new OutputArgument();
      Function.Call<bool>((Hash) 3812348786834502901L, new InputArgument[5]
      {
        InputArgument.op_Implicit((float) pos.X),
        InputArgument.op_Implicit((float) pos.Y),
        InputArgument.op_Implicit((float) pos.Z),
        (InputArgument) outputArgument1,
        (InputArgument) outputArgument2
      });
      return new Vector2((float) outputArgument1.GetResult<float>(), (float) outputArgument2.GetResult<float>());
    }

    private void drawSpriteRTA(
      string textureDict,
      string textureName,
      float screenX,
      float screenY,
      float width,
      float height,
      int r,
      int g,
      int b,
      int alpha,
      float Heading)
    {
      this.screenaspectratio = (float) Function.Call<float>((Hash) -1067213516044759673L, new InputArgument[1]
      {
        InputArgument.op_Implicit(true)
      });
      float num = 1.778f / this.screenaspectratio;
      Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
      {
        InputArgument.op_Implicit(textureDict),
        InputArgument.op_Implicit(0)
      });
      if (!(bool) Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
      {
        InputArgument.op_Implicit(textureDict)
      }))
        return;
      Function.Call((Hash) -1729472009930024816L, new InputArgument[12]
      {
        InputArgument.op_Implicit(textureDict),
        InputArgument.op_Implicit(textureName),
        InputArgument.op_Implicit(this.GetRatio(screenX)),
        InputArgument.op_Implicit(screenY),
        InputArgument.op_Implicit(width / 1280f * num),
        InputArgument.op_Implicit(height / 1280f),
        InputArgument.op_Implicit(Heading),
        InputArgument.op_Implicit(r),
        InputArgument.op_Implicit(g),
        InputArgument.op_Implicit(b),
        InputArgument.op_Implicit(alpha),
        InputArgument.op_Implicit(0)
      });
    }

    private void drawSpriteRTA2(
      string textureDict,
      string textureName,
      float screenX,
      float screenY,
      float width,
      float height,
      int r,
      int g,
      int b,
      int alpha,
      float Heading)
    {
      this.screenaspectratio = (float) Function.Call<float>((Hash) -1067213516044759673L, new InputArgument[1]
      {
        InputArgument.op_Implicit(true)
      });
      float num = 1.778f / this.screenaspectratio;
      Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
      {
        InputArgument.op_Implicit(textureDict),
        InputArgument.op_Implicit(0)
      });
      if (!(bool) Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
      {
        InputArgument.op_Implicit(textureDict)
      }))
        return;
      Function.Call((Hash) -1729472009930024816L, new InputArgument[12]
      {
        InputArgument.op_Implicit(textureDict),
        InputArgument.op_Implicit(textureName),
        InputArgument.op_Implicit(this.GetRatio(screenX)),
        InputArgument.op_Implicit(screenY),
        InputArgument.op_Implicit(width / 1280f * num),
        InputArgument.op_Implicit(height / 1280f),
        InputArgument.op_Implicit(Heading),
        InputArgument.op_Implicit(r),
        InputArgument.op_Implicit(g),
        InputArgument.op_Implicit(b),
        InputArgument.op_Implicit(alpha),
        InputArgument.op_Implicit(0)
      });
    }

    private void drawSprite2(
      string textureDict,
      string textureName,
      float screenX,
      float screenY,
      float width,
      float height,
      int r,
      int g,
      int b,
      int alpha,
      int alpha2)
    {
      Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
      {
        InputArgument.op_Implicit(textureDict),
        InputArgument.op_Implicit(0)
      });
      if (!(bool) Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
      {
        InputArgument.op_Implicit(textureDict)
      }))
        return;
      Function.Call((Hash) -1729472009930024816L, new InputArgument[12]
      {
        InputArgument.op_Implicit(textureDict),
        InputArgument.op_Implicit(textureName),
        InputArgument.op_Implicit(screenX),
        InputArgument.op_Implicit(screenY),
        InputArgument.op_Implicit(width),
        InputArgument.op_Implicit(height),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(r),
        InputArgument.op_Implicit(g),
        InputArgument.op_Implicit(b),
        InputArgument.op_Implicit(alpha),
        InputArgument.op_Implicit(alpha2)
      });
    }

    private void drawSprite2(
      string textureDict,
      string textureName,
      float screenX,
      float screenY,
      float width,
      float height,
      float r,
      int g,
      int b,
      int alpha,
      int alpha2)
    {
      Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
      {
        InputArgument.op_Implicit(textureDict),
        InputArgument.op_Implicit(0)
      });
      if (!(bool) Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
      {
        InputArgument.op_Implicit(textureDict)
      }))
        return;
      Function.Call((Hash) -1729472009930024816L, new InputArgument[12]
      {
        InputArgument.op_Implicit(textureDict),
        InputArgument.op_Implicit(textureName),
        InputArgument.op_Implicit(screenX),
        InputArgument.op_Implicit(screenY),
        InputArgument.op_Implicit(width),
        InputArgument.op_Implicit(height),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(r),
        InputArgument.op_Implicit(g),
        InputArgument.op_Implicit(b),
        InputArgument.op_Implicit(alpha),
        InputArgument.op_Implicit(alpha2)
      });
    }

    private void drawSprite3(
      string textureDict,
      string textureName,
      float screenX,
      float screenY,
      float width,
      float height,
      int r,
      int g,
      int b,
      int alpha)
    {
      this.screenaspectratio = (float) Function.Call<float>((Hash) -1067213516044759673L, new InputArgument[1]
      {
        InputArgument.op_Implicit(true)
      });
      float num = 1.778f / this.screenaspectratio;
      Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
      {
        InputArgument.op_Implicit(textureDict),
        InputArgument.op_Implicit(0)
      });
      if (!(bool) Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
      {
        InputArgument.op_Implicit(textureDict)
      }))
        return;
      Function.Call((Hash) -1729472009930024816L, new InputArgument[12]
      {
        InputArgument.op_Implicit(textureDict),
        InputArgument.op_Implicit(textureName),
        InputArgument.op_Implicit(this.GetRatio(screenX)),
        InputArgument.op_Implicit(screenY),
        InputArgument.op_Implicit(width / 1920f * num),
        InputArgument.op_Implicit(height / 1920f),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(r),
        InputArgument.op_Implicit(g),
        InputArgument.op_Implicit(b),
        InputArgument.op_Implicit(alpha),
        InputArgument.op_Implicit(0)
      });
    }

    private void drawSprite4(
      string textureDict,
      string textureName,
      float screenX,
      float screenY,
      float width,
      float height,
      int r,
      int g,
      int b,
      int alpha,
      float heading)
    {
      this.screenaspectratio = (float) Function.Call<float>((Hash) -1067213516044759673L, new InputArgument[1]
      {
        InputArgument.op_Implicit(true)
      });
      float num = 2.578f / this.screenaspectratio;
      Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
      {
        InputArgument.op_Implicit(textureDict),
        InputArgument.op_Implicit(0)
      });
      if (!(bool) Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
      {
        InputArgument.op_Implicit(textureDict)
      }))
        return;
      Function.Call((Hash) -1729472009930024816L, new InputArgument[12]
      {
        InputArgument.op_Implicit(textureDict),
        InputArgument.op_Implicit(textureName),
        InputArgument.op_Implicit(this.GetRatio(screenX)),
        InputArgument.op_Implicit(screenY),
        InputArgument.op_Implicit(width / 1920f * num),
        InputArgument.op_Implicit(height / 1920f),
        InputArgument.op_Implicit(heading),
        InputArgument.op_Implicit(r),
        InputArgument.op_Implicit(g),
        InputArgument.op_Implicit(b),
        InputArgument.op_Implicit(alpha),
        InputArgument.op_Implicit(0)
      });
    }

    public float GetRatio(float num) => (float) (0.5 - (0.5 - (double) num) / (double) this.screenaspectratio);

    public void DrawSpotlight(
      Color C,
      Vector3 pos,
      Vector3 Rot,
      float range,
      float brightness,
      float roundness)
    {
      Vector3 vector3_1 = pos;
      // ISSUE: explicit constructor call
      ((Vector3) ref vector3_1).\u002Ector((float) vector3_1.X, (float) vector3_1.Y, (float) vector3_1.Z);
      Vector3 vector3_2;
      // ISSUE: explicit constructor call
      ((Vector3) ref vector3_2).\u002Ector((float) Rot.X, (float) (Rot.Y - 90.0), (float) Rot.Z);
      World.DrawSpotLight(pos, vector3_2, C, range, brightness, 0.0f, 35f, 1f);
    }

    public float Get_RGB(Color C, string argb)
    {
      if (argb.Equals("a"))
        return (float) C.A;
      if (argb.Equals("r"))
        return (float) C.R;
      if (argb.Equals("g"))
        return (float) C.G;
      return argb.Equals("b") ? (float) C.B : (float) byte.MaxValue;
    }

    public void DrawLight(Color C, Vector3 pos, float range, float brightness)
    {
      this.Get_RGB(C, "r");
      this.Get_RGB(C, "g");
      this.Get_RGB(C, "b");
      Vector3 vector3_1 = pos;
      // ISSUE: explicit constructor call
      ((Vector3) ref vector3_1).\u002Ector((float) vector3_1.X, (float) vector3_1.Y, (float) (vector3_1.Z + 20.0));
      Vector3 vector3_2 = Vector3.op_Subtraction(pos, vector3_1);
      ((Vector3) ref vector3_2).Normalize();
      World.DrawSpotLight(vector3_1, vector3_2, C, range, brightness, 0.0f, 10f, 1f);
    }

    public void DrawSpotlight3(
      Color C,
      Vector3 pos,
      Vector3 Rot,
      float range,
      float brightness,
      float roundness)
    {
      Vector3 vector3 = pos;
      // ISSUE: explicit constructor call
      ((Vector3) ref vector3).\u002Ector((float) vector3.X, (float) vector3.Y, (float) vector3.Z);
      World.DrawSpotLightWithShadow(pos, new Vector3((float) Rot.X, (float) Rot.Y, (float) Rot.Z), C, range, brightness, 0.0f, 35f, 1f);
    }

    public static Vector3 DirectionToRotation(Vector3 dir, float RotationY)
    {
      Vector3 normalized1 = ((Vector3) ref dir).Normalized;
      Vector3 vector3_1;
      // ISSUE: explicit constructor call
      ((Vector3) ref vector3_1).\u002Ector((float) normalized1.X, (float) normalized1.Y, 0.0f);
      Vector3 vector3_2;
      // ISSUE: explicit constructor call
      ((Vector3) ref vector3_2).\u002Ector((float) normalized1.Z, ((Vector3) ref vector3_1).Length(), 0.0f);
      Vector3 normalized2 = ((Vector3) ref vector3_2).Normalized;
      return new Vector3((float) (System.Math.Atan2((double) normalized2.X, (double) normalized2.Y) * 57.2957801818848), RotationY, (float) (System.Math.Atan2((double) normalized1.X, (double) normalized1.Y) * -57.2957801818848));
    }

    private void SetRange(int handle, float range) => Function.Call((Hash) -2544088794899434175L, new InputArgument[2]
    {
      InputArgument.op_Implicit(handle),
      InputArgument.op_Implicit(range)
    });

    public void DisplayTargetingControls()
    {
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL", Array.Empty<object>());
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", new object[1]
      {
        (object) 0
      });
      scaleform.CallFunction("CREATE_CONTAINER", Array.Empty<object>());
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 0,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(131),
          InputArgument.op_Implicit(0)
        }),
        (object) "Surface"
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 1,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(132),
          InputArgument.op_Implicit(0)
        }),
        (object) "Dive"
      });
      scaleform.CallFunction("SET_DATA_SLOT", new object[3]
      {
        (object) 2,
        (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(24),
          InputArgument.op_Implicit(0)
        }),
        (object) "Fire Torpedo"
      });
      if (this.TargetsMarked >= 1)
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 4,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(24),
            InputArgument.op_Implicit(0)
          }),
          (object) "Un Mark Target"
        });
      if (this.TargetsMarked < 1)
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 4,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(24),
            InputArgument.op_Implicit(0)
          }),
          (object) "Mark Target"
        });
      if (this.SonarStation == 1)
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 6,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(36),
            InputArgument.op_Implicit(0)
          }),
          (object) "Toggle Sonar"
        });
      if (this.HoldToEnterInterior)
      {
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 7,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(75),
            InputArgument.op_Implicit(0)
          }),
          (object) "(Hold) Exit"
        });
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 8,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(75),
            InputArgument.op_Implicit(0)
          }),
          (object) "(Press) Enter Interior  "
        });
      }
      if (!this.HoldToEnterInterior)
      {
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 7,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(75),
            InputArgument.op_Implicit(0)
          }),
          (object) "(Press) Exit"
        });
        scaleform.CallFunction("SET_DATA_SLOT", new object[3]
        {
          (object) 8,
          (object) Function.Call<string>((Hash) 331533201183454215L, new InputArgument[3]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(75),
            InputArgument.op_Implicit(0)
          }),
          (object) "(Hold) Enter Interior  "
        });
      }
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", new object[1]
      {
        (object) -1
      });
      scaleform.Render2D();
    }

    public int PenthouseCheckClothes(int T, int RComp, int RDraw)
    {
      int num = 0;
      if (T == 1)
      {
        if ((bool) Function.Call<bool>((Hash) -1718696417760418019L, new InputArgument[3]
        {
          InputArgument.op_Implicit(Game.Player.Character),
          InputArgument.op_Implicit(RComp),
          InputArgument.op_Implicit(RDraw)
        }))
          num = (int) Function.Call<int>((Hash) 2834476523764480066L, new InputArgument[2]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(RComp)
          });
      }
      if (T == 2)
      {
        if ((bool) Function.Call<bool>((Hash) -1718696417760418019L, new InputArgument[3]
        {
          InputArgument.op_Implicit(Game.Player.Character),
          InputArgument.op_Implicit(RComp),
          InputArgument.op_Implicit(RDraw)
        }))
          num = (int) Function.Call<int>((Hash) -8110606195499570259L, new InputArgument[3]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(RComp),
            InputArgument.op_Implicit(RDraw)
          });
      }
      return num;
    }

    public void PenthouseSetoutfit(int i)
    {
      Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
      {
        InputArgument.op_Implicit(Game.Player.Character),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0)
      });
      if (Model.op_Inequality(((Entity) Game.Player.Character).Model, Model.op_Implicit((PedHash) 1885233650)))
        this.OldCharacter = ((Entity) Game.Player.Character).Model;
      Function.Call((Hash) -6164042450715612628L, new InputArgument[2]
      {
        InputArgument.op_Implicit(Game.Player.Character),
        InputArgument.op_Implicit(1.0)
      });
      Function.Call((Hash) 2328651364711703671L, new InputArgument[1]
      {
        InputArgument.op_Implicit(Game.Player.Character)
      });
      Model model;
      // ISSUE: explicit constructor call
      ((Model) ref model).\u002Ector((PedHash) 1885233650);
      ((Model) ref model).Request(500);
      if (((Model) ref model).IsInCdImage && ((Model) ref model).IsValid)
      {
        while (!((Model) ref model).IsLoaded)
          Script.Wait(100);
        Function.Call((Hash) 45540521788082230L, new InputArgument[2]
        {
          InputArgument.op_Implicit(Game.Player),
          InputArgument.op_Implicit(((Model) ref model).Hash)
        });
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      Ped character = Game.Player.Character;
      Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
      {
        InputArgument.op_Implicit(character),
        InputArgument.op_Implicit(-1),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(17)
      });
      bool flag = false;
      string idC = this.ID_C;
      if (i == 0)
      {
        if (idC.Equals("Outfit Default"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (!flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 1)
      {
        if (idC.Equals("Outfit Default"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(89),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(55),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(54),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Black"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(89),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(55),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(54),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 2 && idC.Equals("Outfit Default"))
      {
        if (!flag && !idC.Equals("Outfit Default"))
          UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num = new Random().Next(1, 100);
        if (num <= 25)
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(38),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        if (num > 25 && num <= 50)
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(112),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        if (num > 50 && num <= 75)
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        if (num > 75)
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(104),
            InputArgument.op_Implicit(25),
            InputArgument.op_Implicit(1)
          });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(17),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(34),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(69),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(125),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(68),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (i == 3)
      {
        if (idC.Equals("Blue"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Green"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Red"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("White"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Black") || idC.Equals("Outfit Default"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 4)
      {
        if (idC.Equals("Black"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("White"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(13),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(14),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(15),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Red"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(14),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 5)
      {
        if (idC.Equals("Black"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("White"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(13),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(14),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(15),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Red"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 6)
      {
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(134),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(147),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(167),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(113),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(90),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(286),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(135),
            InputArgument.op_Implicit(0)
          });
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(134),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(147),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(167),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(113),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(90),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(286),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(135),
            InputArgument.op_Implicit(0)
          });
        }
      }
      if (i == 7)
      {
        if (idC.Equals("Outfit Default"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (!flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 8)
      {
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (!flag)
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i != 9)
        return;
      if (idC.Equals("Outfit Default"))
      {
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (idC.Equals("Green"))
      {
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (idC.Equals("White"))
      {
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (idC.Equals("Blue"))
      {
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (idC.Equals("Black"))
      {
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (!flag)
      {
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
    }

    public void PenthouseWareDrobe()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      KosatkaScript.\u003C\u003Ec__DisplayClass342_0 displayClass3420 = new KosatkaScript.\u003C\u003Ec__DisplayClass342_0();
      // ISSUE: reference to a compiler-generated field
      displayClass3420.\u003C\u003E4__this = this;
      List<object> objectList1 = new List<object>();
      objectList1.Add((object) "Save");
      objectList1.Add((object) "Load");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Slots = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Slots.Add((object) "Slot1.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Slots.Add((object) "Slot2.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Slots.Add((object) "Slot3.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Slots.Add((object) "Slot4.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Slots.Add((object) "Slot5.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Slots.Add((object) "Slot6.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Slots.Add((object) "Slot7.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Slots.Add((object) "Slot8.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Slots.Add((object) "Slot9.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Slots.Add((object) "Slot10.ini");
      List<object> objectList2 = new List<object>()
      {
        (object) (WeaponHash) -1569615261,
        (object) (WeaponHash) -1716189206,
        (object) (WeaponHash) 1737195953,
        (object) (WeaponHash) 1317494643,
        (object) (WeaponHash) -102973651,
        (object) (WeaponHash) -656458692,
        (object) (WeaponHash) -581044007,
        (object) (WeaponHash) -1810795771,
        (object) (WeaponHash) 419712736,
        (object) (WeaponHash) -538741184,
        (object) (WeaponHash) 1141786504,
        (object) (WeaponHash) -1951375401
      };
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Colours = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Colours.Add((object) "Outfit Default");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Colours.Add((object) "Blue");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Colours.Add((object) "Green");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Colours.Add((object) "Red");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Colours.Add((object) "Orange");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Colours.Add((object) "Pink");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Colours.Add((object) "Purple");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Colours.Add((object) "White");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Colours.Add((object) "Black");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Outfits = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Outfits.Add((object) "Soldier");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Outfits.Add((object) "Cloaker");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Outfits.Add((object) "Hacker");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Outfits.Add((object) "Juggernaut");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Outfits.Add((object) "Arena War A");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Outfits.Add((object) "Arena War B");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Outfits.Add((object) "Space Marine");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Outfits.Add((object) "Commando");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Outfits.Add((object) "Space Suit");
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Outfits.Add((object) "Tron");
      List<object> objectList3 = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Draw = new List<object>();
      List<object> objectList4 = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Tex = new List<object>();
      for (int index = 0; index < 999; ++index)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass3420.Tex.Add((object) index);
        // ISSUE: reference to a compiler-generated field
        displayClass3420.Draw.Add((object) index);
        objectList4.Add((object) index);
        objectList3.Add((object) index);
      }
      List<object> objectList5 = new List<object>();
      objectList5.Add((object) " 0 FACE");
      objectList5.Add((object) "1 BEARD");
      objectList5.Add((object) "2 HAIRCUT");
      objectList5.Add((object) "3 SHIRT");
      objectList5.Add((object) "4 PANTS");
      objectList5.Add((object) "5 Hands / Gloves");
      objectList5.Add((object) "6 SHOES");
      objectList5.Add((object) "7 Eyes");
      objectList5.Add((object) "8 Accessories");
      objectList5.Add((object) "9 Mission Items/ Tasks");
      objectList5.Add((object) "10 Decals");
      objectList5.Add((object) "11 Collars and Inner Shirts");
      UIMenu uiMenu1 = this.modMenuPool.AddSubMenu(this.Wardrobe, "Change Outfit");
      this.GUIMenus.Add(uiMenu1);
      this.GUIMenus.Add(uiMenu1);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass3420.O = new UIMenuListItem("", displayClass3420.Outfits, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass3420.O);
      // ISSUE: reference to a compiler-generated field
      ((UIMenuItem) displayClass3420.O).Description = "While Using this outfit you will not be able to purchase anything due to being the MP male";
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass3420.C = new UIMenuListItem("Color : ", displayClass3420.Colours, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass3420.C);
      // ISSUE: reference to a compiler-generated field
      ((UIMenuItem) displayClass3420.C).Description = "Use this Colour Whenever possible or use Default";
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Set = new UIMenuItem("Wear Outfit ");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass3420.Set);
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Set.Description = "~y~ Warning ~w~ Lag is normal while applying outfits, simple alt tab out to avoid crash";
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Remove = new UIMenuItem("Remove Outift ");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass3420.Remove);
      UIMenu uiMenu2 = this.modMenuPool.AddSubMenu(this.Wardrobe, "Change Clothes");
      this.GUIMenus.Add(uiMenu2);
      this.GUIMenus.Add(uiMenu2);
      UIMenu uiMenu3 = this.modMenuPool.AddSubMenu(this.Wardrobe, "Save/Load Outfit");
      this.GUIMenus.Add(uiMenu3);
      this.GUIMenus.Add(uiMenu3);
      // ISSUE: reference to a compiler-generated field
      displayClass3420.SVL = new UIMenuListItem("Function ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass3420.SVL);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Sl = new UIMenuListItem("Slot ", displayClass3420.Slots, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass3420.Sl);
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Get = new UIMenuItem("Save");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass3420.Get);
      // ISSUE: method pointer
      uiMenu3.OnItemSelect += new ItemSelectEvent((object) displayClass3420, __methodptr(\u003CPenthouseWareDrobe\u003Eb__0));
      // ISSUE: method pointer
      uiMenu3.OnListChange += new ListChangedEvent((object) displayClass3420, __methodptr(\u003CPenthouseWareDrobe\u003Eb__1));
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Comp1 = new UIMenuListItem("", objectList5, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass3420.Comp1);
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Drawable = new UIMenuListItem("Item : ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass3420.Drawable);
      // ISSUE: reference to a compiler-generated field
      displayClass3420.Texture = new UIMenuListItem("Texture : ", objectList4, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass3420.Texture);
      // ISSUE: method pointer
      uiMenu1.OnItemSelect += new ItemSelectEvent((object) displayClass3420, __methodptr(\u003CPenthouseWareDrobe\u003Eb__2));
      // ISSUE: method pointer
      uiMenu1.OnListChange += new ListChangedEvent((object) displayClass3420, __methodptr(\u003CPenthouseWareDrobe\u003Eb__3));
      // ISSUE: method pointer
      uiMenu2.OnListChange += new ListChangedEvent((object) displayClass3420, __methodptr(\u003CPenthouseWareDrobe\u003Eb__4));
    }

    public void EnterAnimations(int I)
    {
      if (I == 1)
      {
        this.ReadyForEnterAnim = false;
        string dict = "anim@scripted@submarine@vehicle_trans@helipad";
        KosatkaScript.LoadDict(dict);
        this.DroneCam = World.CreateCamera(new Vector3(1557.997f, 404.82f, -49.68f), new Vector3(0.0f, 0.0f, -39f), 80f);
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        World.RenderingCamera = this.DroneCam;
        Game.Player.Character.SetIntoVehicle(this.Seasparrow, (VehicleSeat) -1);
        Vector3 vector3;
        // ISSUE: explicit constructor call
        ((Vector3) ref vector3).\u002Ector(1559.5f, 410.5084f, -50.66686f);
        this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
        {
          InputArgument.op_Implicit((float) vector3.X),
          InputArgument.op_Implicit((float) vector3.Y),
          InputArgument.op_Implicit((float) vector3.Z),
          InputArgument.op_Implicit(0.0),
          InputArgument.op_Implicit(0.0),
          InputArgument.op_Implicit(180),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 7696488426199063767L, new InputArgument[8]
        {
          InputArgument.op_Implicit(this.Scene3),
          InputArgument.op_Implicit((float) vector3.X),
          InputArgument.op_Implicit((float) vector3.Y),
          InputArgument.op_Implicit((float) vector3.Z),
          InputArgument.op_Implicit(0.0),
          InputArgument.op_Implicit(0.0),
          InputArgument.op_Implicit(180),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.Scene3),
          InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
          {
            InputArgument.op_Implicit(this.Scene3)
          }))
        });
        Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
        {
          InputArgument.op_Implicit(this.Seasparrow),
          InputArgument.op_Implicit(this.Scene3),
          InputArgument.op_Implicit("enter_seasparrow"),
          InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
          InputArgument.op_Implicit(16f),
          InputArgument.op_Implicit(-16f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1148846080)
        });
        Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
        {
          InputArgument.op_Implicit(this.Lift),
          InputArgument.op_Implicit(this.Scene3),
          InputArgument.op_Implicit("enter_platform"),
          InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
          InputArgument.op_Implicit(16f),
          InputArgument.op_Implicit(-16f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1148846080)
        });
        Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
        {
          InputArgument.op_Implicit(this.HangerDL),
          InputArgument.op_Implicit(this.Scene3),
          InputArgument.op_Implicit("enter_l_door"),
          InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
          InputArgument.op_Implicit(16f),
          InputArgument.op_Implicit(-16f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1148846080)
        });
        Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
        {
          InputArgument.op_Implicit(this.DroneCam),
          InputArgument.op_Implicit(this.Scene3),
          InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
          InputArgument.op_Implicit("enter_cam"),
          InputArgument.op_Implicit(16f),
          InputArgument.op_Implicit(-16f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1148846080)
        });
        Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
        {
          InputArgument.op_Implicit(this.DroneCam),
          InputArgument.op_Implicit(this.Scene3),
          InputArgument.op_Implicit("enter_cam"),
          InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
          InputArgument.op_Implicit(16f),
          InputArgument.op_Implicit(-16f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1148846080)
        });
        Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
        {
          InputArgument.op_Implicit(this.HangerDR),
          InputArgument.op_Implicit(this.Scene3),
          InputArgument.op_Implicit("enter_r_door"),
          InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
          InputArgument.op_Implicit(16f),
          InputArgument.op_Implicit(-16f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1148846080)
        });
        Script.Wait(8000);
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        this.DroneCam.Destroy();
      }
      if (I == 2)
      {
        this.ReadyForEnterAnim = false;
        ((Entity) Game.Player.Character).Position = new Vector3(1558.299f, 405.1266f, -54.17f);
        this.DroneCam = World.CreateCamera(new Vector3(1558.299f, 405.1266f, -54.17f), new Vector3(0.0f, 0.0f, -26f), 80f);
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        World.RenderingCamera = this.DroneCam;
        string dict = "anim@scripted@submarine@vehicle_trans@moonpool";
        KosatkaScript.LoadDict(dict);
        int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(1561.541f),
          InputArgument.op_Implicit(419.4447f),
          InputArgument.op_Implicit(-55.30978f)
        });
        ((Entity) this.HatchR01).IsVisible = true;
        ((Entity) this.HatchL01).IsVisible = true;
        ((Entity) this.Avisa).IsVisible = true;
        Function.Call((Hash) 5949884333633149191L, new InputArgument[3]
        {
          InputArgument.op_Implicit(this.HatchR01),
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit((int) Function.Call<int>((Hash) 5170871713518273099L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Game.Player.Character)
          }))
        });
        Function.Call((Hash) 5949884333633149191L, new InputArgument[3]
        {
          InputArgument.op_Implicit(this.HatchL01),
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit((int) Function.Call<int>((Hash) 5170871713518273099L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Game.Player.Character)
          }))
        });
        Function.Call((Hash) 5949884333633149191L, new InputArgument[3]
        {
          InputArgument.op_Implicit(this.Avisa),
          InputArgument.op_Implicit(num),
          InputArgument.op_Implicit((int) Function.Call<int>((Hash) 5170871713518273099L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Game.Player.Character)
          }))
        });
        Game.Player.Character.SetIntoVehicle(this.Avisa, (VehicleSeat) -1);
        Vector3 vector3;
        // ISSUE: explicit constructor call
        ((Vector3) ref vector3).\u002Ector(1563.666f, 413.979f, -54.9424f);
        this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
        {
          InputArgument.op_Implicit((float) vector3.X),
          InputArgument.op_Implicit((float) vector3.Y),
          InputArgument.op_Implicit((float) vector3.Z),
          InputArgument.op_Implicit(0.0),
          InputArgument.op_Implicit(0.0),
          InputArgument.op_Implicit(180),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 7696488426199063767L, new InputArgument[8]
        {
          InputArgument.op_Implicit(this.Scene3),
          InputArgument.op_Implicit((float) vector3.X),
          InputArgument.op_Implicit((float) vector3.Y),
          InputArgument.op_Implicit((float) vector3.Z),
          InputArgument.op_Implicit(0.0),
          InputArgument.op_Implicit(0.0),
          InputArgument.op_Implicit(180),
          InputArgument.op_Implicit(true)
        });
        Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.Scene3),
          InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
          {
            InputArgument.op_Implicit(this.Scene3)
          }))
        });
        Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
        {
          InputArgument.op_Implicit(this.Avisa),
          InputArgument.op_Implicit(this.Scene3),
          InputArgument.op_Implicit("avisa_enter_avisa"),
          InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
          InputArgument.op_Implicit(16f),
          InputArgument.op_Implicit(-16f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1148846080)
        });
        Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
        {
          InputArgument.op_Implicit(this.HatchR01),
          InputArgument.op_Implicit(this.Scene3),
          InputArgument.op_Implicit("avisa_enter_hatch_01r"),
          InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
          InputArgument.op_Implicit(16f),
          InputArgument.op_Implicit(-16f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1148846080)
        });
        Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
        {
          InputArgument.op_Implicit(this.HatchL01),
          InputArgument.op_Implicit(this.Scene3),
          InputArgument.op_Implicit("avisa_enter_hatch_01l"),
          InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
          InputArgument.op_Implicit(16f),
          InputArgument.op_Implicit(-16f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1148846080)
        });
        Script.Wait(5000);
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        this.DroneCam.Destroy();
      }
      if (I != 3)
        return;
      this.ReadyForEnterAnim = false;
      ((Entity) Game.Player.Character).IsVisible = false;
      Game.Player.CanControlCharacter = false;
      ((Entity) Game.Player.Character).Position = new Vector3(1558.299f, 419.4447f, -54.17f);
      this.DroneCam = World.CreateCamera(new Vector3(1558.299f, 419.4447f, -54.17f), new Vector3(0.0f, 0.0f, -115f), 80f);
      Function.Call((Hash) 569060033405794044L, new InputArgument[5]
      {
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(3000),
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(0)
      });
      World.RenderingCamera = this.DroneCam;
      string dict1 = "anim@scripted@submarine@vehicle_trans@moonpool";
      KosatkaScript.LoadDict(dict1);
      int num1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
      {
        InputArgument.op_Implicit(1561.541f),
        InputArgument.op_Implicit(419.7447f),
        InputArgument.op_Implicit(-55.30978f)
      });
      ((Entity) this.HatchR02).IsVisible = true;
      ((Entity) this.HatchL02).IsVisible = true;
      ((Entity) this.Toreador).IsVisible = true;
      Function.Call((Hash) 5949884333633149191L, new InputArgument[3]
      {
        InputArgument.op_Implicit(this.HatchR02),
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit((int) Function.Call<int>((Hash) 5170871713518273099L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Game.Player.Character)
        }))
      });
      Function.Call((Hash) 5949884333633149191L, new InputArgument[3]
      {
        InputArgument.op_Implicit(this.HatchL02),
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit((int) Function.Call<int>((Hash) 5170871713518273099L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Game.Player.Character)
        }))
      });
      Function.Call((Hash) 5949884333633149191L, new InputArgument[3]
      {
        InputArgument.op_Implicit(this.Toreador),
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit((int) Function.Call<int>((Hash) 5170871713518273099L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Game.Player.Character)
        }))
      });
      Vector3 vector3_1;
      // ISSUE: explicit constructor call
      ((Vector3) ref vector3_1).\u002Ector(1563.666f, 419.3f, -54.9424f);
      this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
      {
        InputArgument.op_Implicit((float) vector3_1.X),
        InputArgument.op_Implicit((float) vector3_1.Y),
        InputArgument.op_Implicit((float) vector3_1.Z),
        InputArgument.op_Implicit(0.0),
        InputArgument.op_Implicit(0.0),
        InputArgument.op_Implicit(180),
        InputArgument.op_Implicit(0)
      });
      Function.Call((Hash) 7696488426199063767L, new InputArgument[8]
      {
        InputArgument.op_Implicit(this.Scene3),
        InputArgument.op_Implicit((float) vector3_1.X),
        InputArgument.op_Implicit((float) vector3_1.Y),
        InputArgument.op_Implicit((float) vector3_1.Z),
        InputArgument.op_Implicit(0.0),
        InputArgument.op_Implicit(0.0),
        InputArgument.op_Implicit(180),
        InputArgument.op_Implicit(true)
      });
      Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
      {
        InputArgument.op_Implicit(this.Scene3),
        InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.Scene3)
        }))
      });
      Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
      {
        InputArgument.op_Implicit(this.Toreador),
        InputArgument.op_Implicit(this.Scene3),
        InputArgument.op_Implicit(KosatkaScript.LoadDict(dict1)),
        InputArgument.op_Implicit("toreador_enter_toreador"),
        InputArgument.op_Implicit(16f),
        InputArgument.op_Implicit(-16f),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1148846080)
      });
      Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
      {
        InputArgument.op_Implicit(this.Toreador),
        InputArgument.op_Implicit(this.Scene3),
        InputArgument.op_Implicit("toreador_enter_toreador"),
        InputArgument.op_Implicit(KosatkaScript.LoadDict(dict1)),
        InputArgument.op_Implicit(16f),
        InputArgument.op_Implicit(-16f),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1148846080)
      });
      Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
      {
        InputArgument.op_Implicit(this.HatchR02),
        InputArgument.op_Implicit(this.Scene3),
        InputArgument.op_Implicit("toreador_enter_hatch_02r"),
        InputArgument.op_Implicit(KosatkaScript.LoadDict(dict1)),
        InputArgument.op_Implicit(16f),
        InputArgument.op_Implicit(-16f),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1148846080)
      });
      Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
      {
        InputArgument.op_Implicit(this.HatchL02),
        InputArgument.op_Implicit(this.Scene3),
        InputArgument.op_Implicit("toreador_enter_hatch_02l"),
        InputArgument.op_Implicit(KosatkaScript.LoadDict(dict1)),
        InputArgument.op_Implicit(16f),
        InputArgument.op_Implicit(-16f),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1148846080)
      });
      Script.Wait(5000);
      Function.Call((Hash) 569060033405794044L, new InputArgument[5]
      {
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(3000),
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(0)
      });
      this.DroneCam.Destroy();
      ((Entity) Game.Player.Character).IsVisible = true;
      Game.Player.CanControlCharacter = true;
    }

    private void ChangeBlipPos(float x, float y, float z)
    {
      this.LoadIniFile("scripts//CayoPericoInSp//Submarine.ini");
      this.X = (float) this.Config.GetValue<float>("Setup", "X", (M0) (double) this.X);
      this.Y = (float) this.Config.GetValue<float>("Setup", "Y", (M0) (double) this.Y);
      this.Z = (float) this.Config.GetValue<float>("Setup", "Z", (M0) (double) this.Z);
    }

    private void func_4448(string sParam0, string sParam1)
    {
      this.f_1374 = sParam0;
      this.f_1373 = sParam1;
    }

    private string func_4445(int I)
    {
      switch (I)
      {
        case 1:
          return "2_BOOTUP";
        case 2:
          return "3_BOOTUP";
        case 3:
          return "4_BOOTUP";
        case 4:
          return "EL_RUBIO_1";
        case 5:
          return "EL_RUBIO_2";
        case 6:
          return "EL_RUBIO_3";
        case 7:
          return "EL_RUBIO_4";
        case 8:
          return "EL_RUBIO_5";
        case 9:
          return "EL_RUBIO_6";
        case 10:
          return "1_BOOTUP";
        case 11:
          return "EL_RUBIO";
        case 12:
          return "ISLAND";
        case 13:
          return "OPERATIONS";
        default:
          return "";
      }
    }

    private string func_4446(int I)
    {
      switch (I)
      {
        case 1:
          return "HS4_SUB_INT_BOOT";
        case 2:
          return "HS4_SUB_INT_BOOT_2";
        case 3:
          return "HS4_SUB_INT_BOOT_2";
        case 4:
          return "HS4_SUB_INT_EL_RUBIO_1";
        case 5:
          return "HS4_SUB_INT_EL_RUBIO_2";
        case 6:
          return "HS4_SUB_INT_EL_RUBIO_3";
        case 7:
          return "HS4_SUB_INT_EL_RUBIO_4";
        case 8:
          return "HS4_SUB_INT_EL_RUBIO_5";
        case 9:
          return "HS4_SUB_INT_EL_RUBIO_6";
        case 10:
          return "HS4_SUB_INT_BOOT";
        case 11:
          return "HS4_SUB_INT_EL_RUBIO";
        case 12:
          return "HS4_SUB_INT";
        case 13:
          return "HS4_SUB_INT_EL_RUBIO";
        default:
          return "";
      }
    }

    private void func_4443()
    {
      switch (this.f_1362)
      {
        case 0:
          Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
          {
            InputArgument.op_Implicit("HS4_SUB_INT"),
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
          {
            InputArgument.op_Implicit("HS4_SUB_INT_BOOT"),
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
          {
            InputArgument.op_Implicit("HS4_SUB_INT_BOOT_2"),
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
          {
            InputArgument.op_Implicit("HS4_SUB_INT_EL_RUBIO"),
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
          {
            InputArgument.op_Implicit("HS4_SUB_INT_EL_RUBIO_1"),
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
          {
            InputArgument.op_Implicit("HS4_SUB_INT_EL_RUBIO_2"),
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
          {
            InputArgument.op_Implicit("HS4_SUB_INT_EL_RUBIO_3"),
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
          {
            InputArgument.op_Implicit("HS4_SUB_INT_EL_RUBIO_4"),
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
          {
            InputArgument.op_Implicit("HS4_SUB_INT_EL_RUBIO_5"),
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
          {
            InputArgument.op_Implicit("HS4_SUB_INT_EL_RUBIO_6"),
            InputArgument.op_Implicit(false)
          });
          if (!(bool) Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
          {
            InputArgument.op_Implicit("HS4_SUB_INT_BOOT")
          }))
            break;
          this.f_1362 = 1;
          break;
        case 1:
          if (Function.Call<bool>((Hash) 8709077765568140980L, new InputArgument[1]
          {
            InputArgument.op_Implicit("submarine_table")
          }) == 0)
          {
            Function.Call((Hash) 6330303121102888163L, new InputArgument[2]
            {
              InputArgument.op_Implicit("submarine_table"),
              InputArgument.op_Implicit(false)
            });
            if (Function.Call<bool>((Hash) 1240548542186197656L, new InputArgument[1]
            {
              InputArgument.op_Implicit(771658040)
            }) == 0)
            {
              Function.Call((Hash) -666358852716118227L, new InputArgument[1]
              {
                InputArgument.op_Implicit(771658040)
              });
              if (this.f_1363 == -1)
                this.f_1363 = (int) Function.Call<int>((Hash) 1901777666213403707L, new InputArgument[1]
                {
                  InputArgument.op_Implicit("submarine_table")
                });
            }
          }
          this.f_1362 = 2;
          break;
        case 2:
          Function.Call((Hash) 6851435361686548753L, new InputArgument[1]
          {
            InputArgument.op_Implicit(this.f_1363)
          });
          Function.Call((Hash) -5140769974162915658L, new InputArgument[2]
          {
            InputArgument.op_Implicit(73),
            InputArgument.op_Implicit(73)
          });
          Function.Call((Hash) 7042254994863937538L, new InputArgument[1]
          {
            InputArgument.op_Implicit(4)
          });
          Function.Call((Hash) -4163807871305827379L, new InputArgument[1]
          {
            InputArgument.op_Implicit(true)
          });
          Function.Call((Hash) 3154009034243605640L, new InputArgument[11]
          {
            InputArgument.op_Implicit(this.f_1374),
            InputArgument.op_Implicit(this.f_1373),
            InputArgument.op_Implicit(0.5f),
            InputArgument.op_Implicit(0.75f),
            InputArgument.op_Implicit(1f),
            InputArgument.op_Implicit(0.5f),
            InputArgument.op_Implicit(0.0f),
            InputArgument.op_Implicit((int) byte.MaxValue),
            InputArgument.op_Implicit((int) byte.MaxValue),
            InputArgument.op_Implicit((int) byte.MaxValue),
            InputArgument.op_Implicit((int) byte.MaxValue)
          });
          Function.Call((Hash) -2043548732431581781L, Array.Empty<InputArgument>());
          Function.Call((Hash) 6851435361686548753L, new InputArgument[1]
          {
            InputArgument.op_Implicit((int) Function.Call<int>((Hash) 5976444026706024118L, Array.Empty<InputArgument>()))
          });
          break;
      }
    }

    private void func_4451()
    {
      this.f_1363 = -1;
      this.f_1362 = 0;
      if ((bool) Function.Call<bool>((Hash) 8709077765568140980L, new InputArgument[1]
      {
        InputArgument.op_Implicit("submarine_table")
      }))
        Function.Call((Hash) -1587800445777785388L, new InputArgument[1]
        {
          InputArgument.op_Implicit("submarine_table")
        });
      Function.Call((Hash) -4743226300950730747L, new InputArgument[1]
      {
        InputArgument.op_Implicit("HS4_SUB_INT")
      });
      Function.Call((Hash) -4743226300950730747L, new InputArgument[1]
      {
        InputArgument.op_Implicit("HS4_SUB_INT_BOOT")
      });
      Function.Call((Hash) -4743226300950730747L, new InputArgument[1]
      {
        InputArgument.op_Implicit("HS4_SUB_INT_BOOT_2")
      });
      Function.Call((Hash) -4743226300950730747L, new InputArgument[1]
      {
        InputArgument.op_Implicit("HS4_SUB_INT_EL_RUBIO")
      });
      Function.Call((Hash) -4743226300950730747L, new InputArgument[1]
      {
        InputArgument.op_Implicit("HS4_SUB_INT_EL_RUBIO_1")
      });
      Function.Call((Hash) -4743226300950730747L, new InputArgument[1]
      {
        InputArgument.op_Implicit("HS4_SUB_INT_EL_RUBIO_2")
      });
      Function.Call((Hash) -4743226300950730747L, new InputArgument[1]
      {
        InputArgument.op_Implicit("HS4_SUB_INT_EL_RUBIO_3")
      });
      Function.Call((Hash) -4743226300950730747L, new InputArgument[1]
      {
        InputArgument.op_Implicit("HS4_SUB_INT_EL_RUBIO_4")
      });
      Function.Call((Hash) -4743226300950730747L, new InputArgument[1]
      {
        InputArgument.op_Implicit("HS4_SUB_INT_EL_RUBIO_5")
      });
      Function.Call((Hash) -4743226300950730747L, new InputArgument[1]
      {
        InputArgument.op_Implicit("HS4_SUB_INT_EL_RUBIO_6")
      });
    }

    public KosatkaScript(bool b)
    {
      List<Vector3> vector3List1 = new List<Vector3>();
      vector3List1.Add(new Vector3(1557.546f, 385.9108f, -49.41318f));
      vector3List1.Add(new Vector3(1557.546f, 387.2964f, -49.41318f));
      vector3List1.Add(new Vector3(1557.546f, 388.6898f, -49.41318f));
      this.BottomScreenPos = vector3List1;
      List<Vector3> vector3List2 = new List<Vector3>();
      vector3List2.Add(new Vector3(-21.00364f, 4.67108f, 90.00001f));
      vector3List2.Add(new Vector3(-21.00364f, 4.67108f, 90.00001f));
      vector3List2.Add(new Vector3(-21.00364f, 4.67108f, 90.00001f));
      this.BottomScreenRot = vector3List2;
      List<Vector3> vector3List3 = new List<Vector3>();
      vector3List3.Add(new Vector3(1557.545f, 385.9062f, -48.79995f));
      vector3List3.Add(new Vector3(1557.545f, 388.6938f, -48.79995f));
      vector3List3.Add(new Vector3(1557.545f, 387.2964f, -48.79995f));
      this.TopScreenPos = vector3List3;
      List<Vector3> vector3List4 = new List<Vector3>();
      vector3List4.Add(new Vector3(24.99999f, 0.0f, 90f));
      vector3List4.Add(new Vector3(24.99999f, 0.0f, 90f));
      vector3List4.Add(new Vector3(24.99999f, 0.0f, 90f));
      this.TopScreenRot = vector3List4;
      this.Fire__ids = new List<int>();
      this.PTFX__ids = new List<int>();
      this.Flames = new List<flame>();
      this.TargetsMarkedListVec3 = new List<Vector3>();
      this.TargetsMarkedListVec2 = new List<Vector2>();
      this.FastTravelCost = 25000f;
      this.UnderwaterChests = new List<KosatkaScript.Wreck>()
      {
        new KosatkaScript.Wreck(new Vector3(3627.218f, 3118.456f, 3.571527f)),
        new KosatkaScript.Wreck(new Vector3(-1989.452f, -3029.289f, 14.91704f)),
        new KosatkaScript.Wreck(new Vector3(1802.174f, -2833.339f, 10.06799f)),
        new KosatkaScript.Wreck(new Vector3(2323.65f, -2312.211f, 5.886177f)),
        new KosatkaScript.Wreck(new Vector3(2756.198f, -1606.401f, 7.067998f)),
        new KosatkaScript.Wreck(new Vector3(2857.181f, -1347.317f, 20.70436f)),
        new KosatkaScript.Wreck(new Vector3(2820.673f, -742.4872f, 4.340725f)),
        new KosatkaScript.Wreck(new Vector3(3242.939f, -166.236f, 22.068f)),
        new KosatkaScript.Wreck(new Vector3(3034.932f, 629.8385f, 8.613461f)),
        new KosatkaScript.Wreck(new Vector3(3066.524f, 2211.626f, 8.836841f)),
        new KosatkaScript.Wreck(new Vector3(675.6005f, -2572.76f, -1.761607f)),
        new KosatkaScript.Wreck(new Vector3(460.0083f, -2382.176f, -12.22217f)),
        new KosatkaScript.Wreck(new Vector3(1869.524f, -2991.765f, -48.04036f)),
        new KosatkaScript.Wreck(new Vector3(1954.981f, -3124.962f, -63.49492f)),
        new KosatkaScript.Wreck(new Vector3(3191.391f, -341.7229f, -26.74596f)),
        new KosatkaScript.Wreck(new Vector3(3405.87f, -359.0591f, -15.92778f)),
        new KosatkaScript.Wreck(new Vector3(2996.604f, 859.8041f, 22.16932f)),
        new KosatkaScript.Wreck(new Vector3(3122.64f, 1160.947f, 22.16932f)),
        new KosatkaScript.Wreck(new Vector3(3098.468f, 2208.755f, -5.103413f)),
        new KosatkaScript.Wreck(new Vector3(3551.043f, 2521.731f, 11.16931f)),
        new KosatkaScript.Wreck(new Vector3(3876.409f, 3262.29f, 7.896586f)),
        new KosatkaScript.Wreck(new Vector3(4078.65f, 4207.494f, 24.26022f)),
        new KosatkaScript.Wreck(new Vector3(3698.24f, 4946.366f, 30.80568f)),
        new KosatkaScript.Wreck(new Vector3(3420.015f, 6092.364f, 7.896586f)),
        new KosatkaScript.Wreck(new Vector3(2583.754f, 6162.598f, 180.8962f)),
        new KosatkaScript.Wreck(new Vector3(1915.825f, 6663.769f, 5.896266f)),
        new KosatkaScript.Wreck(new Vector3(227.8274f, 7419.05f, 33.25991f)),
        new KosatkaScript.Wreck(new Vector3(-997.8561f, 6260.582f, 7.078086f)),
        new KosatkaScript.Wreck(new Vector3(-2167.71f, 5272.077f, 29.98718f)),
        new KosatkaScript.Wreck(new Vector3(3123.278f, 382.6383f, -14.78805f)),
        new KosatkaScript.Wreck(new Vector3(3262.35f, 363.7935f, -47.24261f)),
        new KosatkaScript.Wreck(new Vector3(3556.122f, 6207.496f, -4.653165f)),
        new KosatkaScript.Wreck(new Vector3(4194.689f, 4907.574f, -93.19861f)),
        new KosatkaScript.Wreck(new Vector3(4283.254f, 3447.733f, -17.73102f)),
        new KosatkaScript.Wreck(new Vector3(3922.172f, 2148.106f, -158.4583f)),
        new KosatkaScript.Wreck(new Vector3(2284.389f, 7043.417f, -83.57345f)),
        new KosatkaScript.Wreck(new Vector3(1885.554f, 7070.422f, -105.937f)),
        new KosatkaScript.Wreck(new Vector3(1665.364f, 6895.005f, -40.48246f)),
        new KosatkaScript.Wreck(new Vector3(2071.458f, 6989.618f, -72.84615f)),
        new KosatkaScript.Wreck(new Vector3(3217.882f, 6731.417f, -109.8461f)),
        new KosatkaScript.Wreck(new Vector3(-3558.63f, 593.506f, -58.3f)),
        new KosatkaScript.Wreck(new Vector3(-3505.052f, 88.627f, -64.88f)),
        new KosatkaScript.Wreck(new Vector3(-2172.868f, -1139.021f, -91.153f)),
        new KosatkaScript.Wreck(new Vector3(-2037.608f, -1421.93f, -48.6f)),
        new KosatkaScript.Wreck(new Vector3(-1470.488f, -3593.157f, -23.7f)),
        new KosatkaScript.Wreck(new Vector3(780.59f, -3684.003f, -47.52f)),
        new KosatkaScript.Wreck(new Vector3(1634.931f, -3305.762f, -53.15f)),
        new KosatkaScript.Wreck(new Vector3(1906.335f, -2720.134f, -21.304f)),
        new KosatkaScript.Wreck(new Vector3(2368.771f, -2423.731f, -28.6f)),
        new KosatkaScript.Wreck(new Vector3(3048.597f, -945.331f, -18.8f)),
        new KosatkaScript.Wreck(new Vector3(3404.571f, -393.1751f, -12.5f)),
        new KosatkaScript.Wreck(new Vector3(3101.398f, 756.8558f, -29.304f)),
        new KosatkaScript.Wreck(new Vector3(3168.827f, 1434.529f, -22.6f)),
        new KosatkaScript.Wreck(new Vector3(3678.703f, 1954.792f, -156.032f)),
        new KosatkaScript.Wreck(new Vector3(4003.746f, 2992.854f, -39.57f)),
        new KosatkaScript.Wreck(new Vector3(4266.282f, 4627.863f, -3.2f)),
        new KosatkaScript.Wreck(new Vector3(3754.398f, 5567.347f, -75.84f)),
        new KosatkaScript.Wreck(new Vector3(3493.113f, 5906.778f, -6.122f)),
        new KosatkaScript.Wreck(new Vector3(3644.141f, 6272.838f, -75.75f)),
        new KosatkaScript.Wreck(new Vector3(3152.674f, 6860.745f, -82.66f)),
        new KosatkaScript.Wreck(new Vector3(2680.816f, 7014.85f, -91.94f)),
        new KosatkaScript.Wreck(new Vector3(2396.833f, 6830.155f, -32.7f)),
        new KosatkaScript.Wreck(new Vector3(940.92f, 7273.47f, -42.3f)),
        new KosatkaScript.Wreck(new Vector3(364.925f, 7649.916f, -133f)),
        new KosatkaScript.Wreck(new Vector3(-642.25f, 6972.255f, -19.133f)),
        new KosatkaScript.Wreck(new Vector3(-938.0897f, 6564.289f, -30.21f)),
        new KosatkaScript.Wreck(new Vector3(-1993.81f, 5573.522f, -81.48f)),
        new KosatkaScript.Wreck(new Vector3(-2886.146f, 4515.774f, -153.66f)),
        new KosatkaScript.Wreck(new Vector3(-3339.279f, 3927.047f, -64.03f)),
        new KosatkaScript.Wreck(new Vector3(-3250.212f, 2278.011f, -52.49f)),
        new KosatkaScript.Wreck(new Vector3(-3620.479f, 1052.24f, -17.76f)),
        new KosatkaScript.Wreck(new Vector3(-3620.479f, 1052.24f, -17.76f))
      };
      this.DisplayChestBlipsOnFoot = true;
      this.MousePos = new Vector2(0.5f, 0.5f);
      this.SwitchStage = 11;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Tick += new EventHandler(this.OnTick);
      this.Aborted += new EventHandler(this.OnShutdown);
      this.LoadIniFile("scripts//CayoPericoInSp//Submarine.ini");
    }

    public KosatkaScript()
    {
      List<Vector3> vector3List1 = new List<Vector3>();
      vector3List1.Add(new Vector3(1557.546f, 385.9108f, -49.41318f));
      vector3List1.Add(new Vector3(1557.546f, 387.2964f, -49.41318f));
      vector3List1.Add(new Vector3(1557.546f, 388.6898f, -49.41318f));
      this.BottomScreenPos = vector3List1;
      List<Vector3> vector3List2 = new List<Vector3>();
      vector3List2.Add(new Vector3(-21.00364f, 4.67108f, 90.00001f));
      vector3List2.Add(new Vector3(-21.00364f, 4.67108f, 90.00001f));
      vector3List2.Add(new Vector3(-21.00364f, 4.67108f, 90.00001f));
      this.BottomScreenRot = vector3List2;
      List<Vector3> vector3List3 = new List<Vector3>();
      vector3List3.Add(new Vector3(1557.545f, 385.9062f, -48.79995f));
      vector3List3.Add(new Vector3(1557.545f, 388.6938f, -48.79995f));
      vector3List3.Add(new Vector3(1557.545f, 387.2964f, -48.79995f));
      this.TopScreenPos = vector3List3;
      List<Vector3> vector3List4 = new List<Vector3>();
      vector3List4.Add(new Vector3(24.99999f, 0.0f, 90f));
      vector3List4.Add(new Vector3(24.99999f, 0.0f, 90f));
      vector3List4.Add(new Vector3(24.99999f, 0.0f, 90f));
      this.TopScreenRot = vector3List4;
      this.Fire__ids = new List<int>();
      this.PTFX__ids = new List<int>();
      this.Flames = new List<flame>();
      this.TargetsMarkedListVec3 = new List<Vector3>();
      this.TargetsMarkedListVec2 = new List<Vector2>();
      this.FastTravelCost = 25000f;
      this.UnderwaterChests = new List<KosatkaScript.Wreck>()
      {
        new KosatkaScript.Wreck(new Vector3(3627.218f, 3118.456f, 3.571527f)),
        new KosatkaScript.Wreck(new Vector3(-1989.452f, -3029.289f, 14.91704f)),
        new KosatkaScript.Wreck(new Vector3(1802.174f, -2833.339f, 10.06799f)),
        new KosatkaScript.Wreck(new Vector3(2323.65f, -2312.211f, 5.886177f)),
        new KosatkaScript.Wreck(new Vector3(2756.198f, -1606.401f, 7.067998f)),
        new KosatkaScript.Wreck(new Vector3(2857.181f, -1347.317f, 20.70436f)),
        new KosatkaScript.Wreck(new Vector3(2820.673f, -742.4872f, 4.340725f)),
        new KosatkaScript.Wreck(new Vector3(3242.939f, -166.236f, 22.068f)),
        new KosatkaScript.Wreck(new Vector3(3034.932f, 629.8385f, 8.613461f)),
        new KosatkaScript.Wreck(new Vector3(3066.524f, 2211.626f, 8.836841f)),
        new KosatkaScript.Wreck(new Vector3(675.6005f, -2572.76f, -1.761607f)),
        new KosatkaScript.Wreck(new Vector3(460.0083f, -2382.176f, -12.22217f)),
        new KosatkaScript.Wreck(new Vector3(1869.524f, -2991.765f, -48.04036f)),
        new KosatkaScript.Wreck(new Vector3(1954.981f, -3124.962f, -63.49492f)),
        new KosatkaScript.Wreck(new Vector3(3191.391f, -341.7229f, -26.74596f)),
        new KosatkaScript.Wreck(new Vector3(3405.87f, -359.0591f, -15.92778f)),
        new KosatkaScript.Wreck(new Vector3(2996.604f, 859.8041f, 22.16932f)),
        new KosatkaScript.Wreck(new Vector3(3122.64f, 1160.947f, 22.16932f)),
        new KosatkaScript.Wreck(new Vector3(3098.468f, 2208.755f, -5.103413f)),
        new KosatkaScript.Wreck(new Vector3(3551.043f, 2521.731f, 11.16931f)),
        new KosatkaScript.Wreck(new Vector3(3876.409f, 3262.29f, 7.896586f)),
        new KosatkaScript.Wreck(new Vector3(4078.65f, 4207.494f, 24.26022f)),
        new KosatkaScript.Wreck(new Vector3(3698.24f, 4946.366f, 30.80568f)),
        new KosatkaScript.Wreck(new Vector3(3420.015f, 6092.364f, 7.896586f)),
        new KosatkaScript.Wreck(new Vector3(2583.754f, 6162.598f, 180.8962f)),
        new KosatkaScript.Wreck(new Vector3(1915.825f, 6663.769f, 5.896266f)),
        new KosatkaScript.Wreck(new Vector3(227.8274f, 7419.05f, 33.25991f)),
        new KosatkaScript.Wreck(new Vector3(-997.8561f, 6260.582f, 7.078086f)),
        new KosatkaScript.Wreck(new Vector3(-2167.71f, 5272.077f, 29.98718f)),
        new KosatkaScript.Wreck(new Vector3(3123.278f, 382.6383f, -14.78805f)),
        new KosatkaScript.Wreck(new Vector3(3262.35f, 363.7935f, -47.24261f)),
        new KosatkaScript.Wreck(new Vector3(3556.122f, 6207.496f, -4.653165f)),
        new KosatkaScript.Wreck(new Vector3(4194.689f, 4907.574f, -93.19861f)),
        new KosatkaScript.Wreck(new Vector3(4283.254f, 3447.733f, -17.73102f)),
        new KosatkaScript.Wreck(new Vector3(3922.172f, 2148.106f, -158.4583f)),
        new KosatkaScript.Wreck(new Vector3(2284.389f, 7043.417f, -83.57345f)),
        new KosatkaScript.Wreck(new Vector3(1885.554f, 7070.422f, -105.937f)),
        new KosatkaScript.Wreck(new Vector3(1665.364f, 6895.005f, -40.48246f)),
        new KosatkaScript.Wreck(new Vector3(2071.458f, 6989.618f, -72.84615f)),
        new KosatkaScript.Wreck(new Vector3(3217.882f, 6731.417f, -109.8461f)),
        new KosatkaScript.Wreck(new Vector3(-3558.63f, 593.506f, -58.3f)),
        new KosatkaScript.Wreck(new Vector3(-3505.052f, 88.627f, -64.88f)),
        new KosatkaScript.Wreck(new Vector3(-2172.868f, -1139.021f, -91.153f)),
        new KosatkaScript.Wreck(new Vector3(-2037.608f, -1421.93f, -48.6f)),
        new KosatkaScript.Wreck(new Vector3(-1470.488f, -3593.157f, -23.7f)),
        new KosatkaScript.Wreck(new Vector3(780.59f, -3684.003f, -47.52f)),
        new KosatkaScript.Wreck(new Vector3(1634.931f, -3305.762f, -53.15f)),
        new KosatkaScript.Wreck(new Vector3(1906.335f, -2720.134f, -21.304f)),
        new KosatkaScript.Wreck(new Vector3(2368.771f, -2423.731f, -28.6f)),
        new KosatkaScript.Wreck(new Vector3(3048.597f, -945.331f, -18.8f)),
        new KosatkaScript.Wreck(new Vector3(3404.571f, -393.1751f, -12.5f)),
        new KosatkaScript.Wreck(new Vector3(3101.398f, 756.8558f, -29.304f)),
        new KosatkaScript.Wreck(new Vector3(3168.827f, 1434.529f, -22.6f)),
        new KosatkaScript.Wreck(new Vector3(3678.703f, 1954.792f, -156.032f)),
        new KosatkaScript.Wreck(new Vector3(4003.746f, 2992.854f, -39.57f)),
        new KosatkaScript.Wreck(new Vector3(4266.282f, 4627.863f, -3.2f)),
        new KosatkaScript.Wreck(new Vector3(3754.398f, 5567.347f, -75.84f)),
        new KosatkaScript.Wreck(new Vector3(3493.113f, 5906.778f, -6.122f)),
        new KosatkaScript.Wreck(new Vector3(3644.141f, 6272.838f, -75.75f)),
        new KosatkaScript.Wreck(new Vector3(3152.674f, 6860.745f, -82.66f)),
        new KosatkaScript.Wreck(new Vector3(2680.816f, 7014.85f, -91.94f)),
        new KosatkaScript.Wreck(new Vector3(2396.833f, 6830.155f, -32.7f)),
        new KosatkaScript.Wreck(new Vector3(940.92f, 7273.47f, -42.3f)),
        new KosatkaScript.Wreck(new Vector3(364.925f, 7649.916f, -133f)),
        new KosatkaScript.Wreck(new Vector3(-642.25f, 6972.255f, -19.133f)),
        new KosatkaScript.Wreck(new Vector3(-938.0897f, 6564.289f, -30.21f)),
        new KosatkaScript.Wreck(new Vector3(-1993.81f, 5573.522f, -81.48f)),
        new KosatkaScript.Wreck(new Vector3(-2886.146f, 4515.774f, -153.66f)),
        new KosatkaScript.Wreck(new Vector3(-3339.279f, 3927.047f, -64.03f)),
        new KosatkaScript.Wreck(new Vector3(-3250.212f, 2278.011f, -52.49f)),
        new KosatkaScript.Wreck(new Vector3(-3620.479f, 1052.24f, -17.76f)),
        new KosatkaScript.Wreck(new Vector3(-3620.479f, 1052.24f, -17.76f))
      };
      this.DisplayChestBlipsOnFoot = true;
      this.MousePos = new Vector2(0.5f, 0.5f);
      this.SwitchStage = 11;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.ifruit = new CustomiFruit()
      {
        CenterButtonColor = Color.Orange,
        LeftButtonColor = Color.LimeGreen,
        RightButtonColor = Color.Purple,
        CenterButtonIcon = (SoftKeyIcon) 19,
        LeftButtonIcon = (SoftKeyIcon) 17,
        RightButtonIcon = (SoftKeyIcon) 16
      };
      this.ifruit.SetWallpaper(new Wallpaper("char_facebook"));
      this.ifruit.SetWallpaper(Wallpaper.BadgerDefault);
      iFruitContact iFruitContact = new iFruitContact("Kosatka Options");
      // ISSUE: method pointer
      iFruitContact.Answered += new ContactAnsweredEvent((object) this, __methodptr(loadMenu));
      iFruitContact.DialTimeout = 3000;
      iFruitContact.Active = true;
      iFruitContact.Icon = ContactIcon.DialASub;
      iFruitContact.Name = "Kosatka Options";
      ((List<iFruitContact>) this.ifruit.Contacts).Add(iFruitContact);
      Function.Call((Hash) -5184338789570016586L, new InputArgument[1]
      {
        InputArgument.op_Implicit("core")
      });
      Function.Call((Hash) 7798175403732277905L, new InputArgument[1]
      {
        InputArgument.op_Implicit("core")
      });
      Function.Call((Hash) -5184338789570016586L, new InputArgument[1]
      {
        InputArgument.op_Implicit("core")
      });
      Function.Call((Hash) 7798175403732277905L, new InputArgument[1]
      {
        InputArgument.op_Implicit("core")
      });
      Function.Call((Hash) -5184338789570016586L, new InputArgument[1]
      {
        InputArgument.op_Implicit("core")
      });
      Function.Call((Hash) 7798175403732277905L, new InputArgument[1]
      {
        InputArgument.op_Implicit("core")
      });
      Function.Call((Hash) -5184338789570016586L, new InputArgument[1]
      {
        InputArgument.op_Implicit("core")
      });
      Function.Call((Hash) 7798175403732277905L, new InputArgument[1]
      {
        InputArgument.op_Implicit("core")
      });
      this.SaveLoad = new SaveCar();
      this.Tick += new EventHandler(this.OnTick);
      this.Aborted += new EventHandler(this.OnShutdown);
      this.LoadIniFile("scripts//CayoPericoInSp//Submarine.ini");
      this.Spawn = new Vector3(this.X, this.Y, this.Z);
      this.MOCPosSave = new Vector3(this.X, this.Y, this.Z);
      this.Setup();
      this.Created = false;
    }

    public static Vector3 GenerateSpawnPos(
      Vector3 desiredPos,
      KosatkaScript.Nodetype roadtype,
      bool sidewalk)
    {
      Vector3 zero = Vector3.Zero;
      bool flag = false;
      OutputArgument outputArgument = new OutputArgument();
      int num1 = 1;
      int num2 = 0;
      if (roadtype == KosatkaScript.Nodetype.AnyRoad)
        num2 = 1;
      if (roadtype == KosatkaScript.Nodetype.Road)
        num2 = 0;
      if (roadtype == KosatkaScript.Nodetype.Offroad)
      {
        num2 = 1;
        flag = true;
      }
      if (roadtype == KosatkaScript.Nodetype.Water)
        num2 = 3;
      int num3 = (int) Function.Call<int>((Hash) 2510518586829603349L, new InputArgument[7]
      {
        InputArgument.op_Implicit((float) desiredPos.X),
        InputArgument.op_Implicit((float) desiredPos.Y),
        InputArgument.op_Implicit((float) desiredPos.Z),
        InputArgument.op_Implicit(num1),
        InputArgument.op_Implicit(num2),
        InputArgument.op_Implicit(300f),
        InputArgument.op_Implicit(300f)
      });
      if (flag)
      {
        while (true)
        {
          if (Function.Call<bool>((Hash) 5715191804072465017L, new InputArgument[1]
          {
            InputArgument.op_Implicit(num3)
          }) == null && num1 < 500)
          {
            ++num1;
            num3 = (int) Function.Call<int>((Hash) 2510518586829603349L, new InputArgument[7]
            {
              InputArgument.op_Implicit((float) desiredPos.X),
              InputArgument.op_Implicit((float) desiredPos.Y),
              InputArgument.op_Implicit((float) desiredPos.Z),
              InputArgument.op_Implicit(num1),
              InputArgument.op_Implicit(num2),
              InputArgument.op_Implicit(300f),
              InputArgument.op_Implicit(300f)
            });
          }
          else
            break;
        }
      }
      Function.Call((Hash) 8084282276450675138L, new InputArgument[2]
      {
        InputArgument.op_Implicit(num3),
        (InputArgument) outputArgument
      });
      Vector3 vector3 = (Vector3) outputArgument.GetResult<Vector3>();
      if (sidewalk)
        vector3 = World.GetNextPositionOnSidewalk(vector3);
      return vector3;
    }

    public void GetSpawnPoint()
    {
    }

    public static void TextNotification(
      string avatar,
      string author,
      string title,
      string message)
    {
      Function.Call((Hash) 7477453855356397301L, new InputArgument[3]
      {
        InputArgument.op_Implicit(-1),
        InputArgument.op_Implicit("CONFIRM_BEEP"),
        InputArgument.op_Implicit("HUD_MINI_GAME_SOUNDSET")
      });
      Function.Call((Hash) 2316831480196236324L, new InputArgument[1]
      {
        InputArgument.op_Implicit("STRING")
      });
      Function.Call((Hash) 7789129354908300458L, new InputArgument[1]
      {
        InputArgument.op_Implicit(message)
      });
      int num = (int) Function.Call<int>((Hash) 2075484565200204495L, new InputArgument[6]
      {
        InputArgument.op_Implicit(avatar),
        InputArgument.op_Implicit(avatar),
        InputArgument.op_Implicit(true),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(title),
        InputArgument.op_Implicit(author)
      });
    }

    private void OnTick(object sender, EventArgs e)
    {
      if (Game.Player.Name.ToUpper().Equals("CRUELMC"))
        return;
      if (this.BoatActive && Entity.op_Inequality((Entity) this.MainBoat, (Entity) null))
      {
        if (!((Entity) this.MainBoat).IsAlive)
        {
          this.BoatActive = false;
          KosatkaScript.TextNotification(this.HeistLeaderChar, this.HeistLeadername.ToString(), this.MainBoat.FriendlyName + " was destoryed!", "Your " + this.MainBoat.FriendlyName + ", you will have to order a new one from your phone");
          ((Entity) this.MainBoat).MarkAsNoLongerNeeded();
        }
        if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, ((Entity) this.MainBoat).Position) > 1200.0)
        {
          this.BoatActive = false;
          ((Entity) this.MainBoat).Delete();
        }
      }
      this.ifruit.Update();
      if (this.IsInInterior && !this.UsingInteriorPeriscope)
      {
        if (!this.CreatedPeriscope && (double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1561.519f, 388.7829f, -48.59f)) < 30.0)
        {
          Vector3 position = ((Entity) Game.Player.Character).Position;
          if (Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit((float) position.X),
            InputArgument.op_Implicit((float) position.Y),
            InputArgument.op_Implicit((float) position.Z)
          }) > 0)
          {
            if (Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
            {
              InputArgument.op_Implicit(1560f),
              InputArgument.op_Implicit(400f),
              InputArgument.op_Implicit(-50f)
            }) == Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
            {
              InputArgument.op_Implicit((float) position.X),
              InputArgument.op_Implicit((float) position.Y),
              InputArgument.op_Implicit((float) position.Z)
            }))
            {
              if (Entity.op_Inequality((Entity) this.PeriscopeProp, (Entity) null))
                ((Entity) this.PeriscopeProp).Delete();
              this.PeriscopeProp = World.CreateProp(this.RequestModel("h4_int_lev_sub_periscope_h_up"), new Vector3(1561.519f, 388.7829f, -49.59f), new Vector3(0.0f, 0.0f, 180f), false, false);
              Script.Wait(1);
              ((Entity) this.PeriscopeProp).Position = new Vector3(1561.519f, 388.7829f, -48f);
              this.CreatedPeriscope = true;
            }
          }
        }
        if (this.CreatedPeriscope && (double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1561.519f, 388.7829f, -48.59f)) > 30.0)
        {
          if (Entity.op_Inequality((Entity) this.PeriscopeProp, (Entity) null))
            ((Entity) this.PeriscopeProp).Delete();
          this.CreatedPeriscope = false;
        }
      }
      if (this.IsInInterior && (double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1561.083f, 385.89f, -50f)) < 3.0)
      {
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Switch Table Screen");
        if (Game.IsControlJustPressed(2, (Control) 51))
        {
          this.f_1362 = 0;
          ++this.SwitchStage;
          if (this.SwitchStage < 11)
            this.SwitchStage = 11;
          if (this.SwitchStage > 13)
            this.SwitchStage = 11;
          this.DrawTable = true;
        }
      }
      if (this.DrawTable)
      {
        if (this.f_1362 == 0)
          this.func_4451();
        this.func_4448(this.func_4446(this.SwitchStage), this.func_4445(this.SwitchStage));
        this.func_4443();
      }
      if (this.GotScreens && (double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1557.546f, 387.2964f, -49.41318f)) > 30.0)
        this.GotScreens = false;
      if (!this.GotScreens && (double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1557.546f, 387.2964f, -49.41318f)) < 30.0)
      {
        Vector3 position = ((Entity) Game.Player.Character).Position;
        if (Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit((float) position.X),
          InputArgument.op_Implicit((float) position.Y),
          InputArgument.op_Implicit((float) position.Z)
        }) > 0)
        {
          if (Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(1560f),
            InputArgument.op_Implicit(400f),
            InputArgument.op_Implicit(-50f)
          }) == Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit((float) position.X),
            InputArgument.op_Implicit((float) position.Y),
            InputArgument.op_Implicit((float) position.Z)
          }))
          {
            Prop[] nearbyProps1 = World.GetNearbyProps(new Vector3(1557.546f, 387.2964f, -49.41318f), 30f, this.RequestModel("h4_prop_screen_top_sonar"));
            for (int index = 0; index < nearbyProps1.Length; ++index)
            {
              if (index != 3 && (uint) index > 0U)
                ((Entity) nearbyProps1[index]).Alpha = 0;
            }
            Prop[] nearbyProps2 = World.GetNearbyProps(new Vector3(1557.546f, 387.2964f, -49.41318f), 30f, this.RequestModel("h4_prop_sub_screen_top_offline"));
            for (int index = 0; index < nearbyProps2.Length; ++index)
            {
              if (index == 2)
                ((Entity) nearbyProps2[index]).Alpha = 0;
              if (index != 2)
                ((Entity) nearbyProps2[index]).Alpha = 0;
            }
            Prop[] nearbyProps3 = World.GetNearbyProps(new Vector3(1557.546f, 387.2964f, -49.41318f), 30f, this.RequestModel("h4_prop_screen_top_missile_ready"));
            for (int index = 0; index < nearbyProps3.Length; ++index)
            {
              if (index == 0)
                ((Entity) nearbyProps3[index]).IsVisible = false;
              if (index != 1 && index != 3 && (uint) index > 0U)
                ((Entity) nearbyProps3[index]).Alpha = 0;
            }
            Prop[] nearbyProps4 = World.GetNearbyProps(new Vector3(1557.546f, 387.2964f, -49.41318f), 30f, this.RequestModel("h4_prop_screen_top_missile_active"));
            for (int index = 0; index < nearbyProps4.Length; ++index)
            {
              if (index != 0 && index != 5)
                ((Entity) nearbyProps4[index]).Alpha = 0;
            }
            Prop[] nearbyProps5 = World.GetNearbyProps(new Vector3(1557.546f, 387.2964f, -49.41318f), 30f, this.RequestModel("h4_prop_screen_btm_offline"));
            for (int index = 0; index < nearbyProps5.Length; ++index)
            {
              if (index == 0)
                ((Entity) nearbyProps5[index]).Alpha = 0;
              if ((uint) index > 0U)
                ((Entity) nearbyProps5[index]).Alpha = 0;
            }
            Prop[] nearbyProps6 = World.GetNearbyProps(new Vector3(1557.546f, 387.2964f, -49.41318f), 30f, this.RequestModel("h4_prop_screen_btm_missile_reload"));
            for (int index = 0; index < nearbyProps6.Length; ++index)
            {
              if (index == 1)
              {
                ((Entity) nearbyProps6[index]).Alpha = 0;
                World.DrawMarker((MarkerType) 28, new Vector3(10000f, 10000f, 10000f), Vector3.Zero, Vector3.Zero, new Vector3(0.15f, 0.15f, 0.15f), Color.Red);
              }
              if (index != 1)
                ((Entity) nearbyProps6[index]).Alpha = 0;
            }
            Prop[] nearbyProps7 = World.GetNearbyProps(new Vector3(1557.546f, 387.2964f, -49.41318f), 30f, this.RequestModel("h4_prop_screen_btm_missile_ready"));
            for (int index = 0; index < nearbyProps7.Length; ++index)
            {
              if (index != 0)
                ;
              if (index != 1)
                ;
              if (index != 0 && index != 1)
                ((Entity) nearbyProps7[index]).Alpha = 0;
            }
            Prop[] nearbyProps8 = World.GetNearbyProps(new Vector3(1557.546f, 387.2964f, -49.41318f), 30f, this.RequestModel("h4_prop_screen_btm_missile_active"));
            for (int index = 0; index < nearbyProps8.Length; ++index)
            {
              if (index == 1)
              {
                ((Entity) nearbyProps8[1]).Alpha = 0;
                World.DrawMarker((MarkerType) 28, new Vector3(10000f, 10000f, 10000f), Vector3.Zero, Vector3.Zero, new Vector3(0.15f, 0.15f, 0.15f), Color.Brown);
              }
              if (index == 2)
                World.DrawMarker((MarkerType) 28, new Vector3(10000f, 10000f, 10000f), Vector3.Zero, Vector3.Zero, new Vector3(0.15f, 0.15f, 0.15f), Color.DarkMagenta);
              if (index != 1 && index != 2)
                ((Entity) nearbyProps8[index]).Alpha = 0;
            }
            Prop[] nearbyProps9 = World.GetNearbyProps(new Vector3(1557.546f, 387.2964f, -49.41318f), 30f, this.RequestModel("h4_prop_screen_bottom_sonar"));
            for (int index = 0; index < nearbyProps9.Length; ++index)
            {
              if (index != 2 && index != 0 && index != 3)
                ((Entity) nearbyProps9[index]).Alpha = 0;
            }
          }
        }
      }
      if (!Game.Player.Name.ToUpper().Equals("CINNBARGNU"))
        ;
      if (!this.GotExitEnterProps && this.IsInInterior && (this.CreatedInteriorVehicles && (double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1557.997f, 404.82f, -49.68f)) < 30.0))
      {
        Script.Wait(1000);
        foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_r_02a")))
          this.HatchR02 = nearbyProp;
        foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_r_01a")))
          this.HatchR01 = nearbyProp;
        foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_l_01a")))
          this.HatchL01 = nearbyProp;
        foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_l_02a")))
          this.HatchL02 = nearbyProp;
        foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_lift_platfom")))
          this.Lift = nearbyProp;
        foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_int_sub_lift_doors_r")))
          this.HangerDR = nearbyProp;
        foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_int_sub_lift_doors_l")))
          this.HangerDL = nearbyProp;
        if (Entity.op_Inequality((Entity) this.HatchR02, (Entity) null) && Entity.op_Inequality((Entity) this.HatchR01, (Entity) null) && (Entity.op_Inequality((Entity) this.HatchL01, (Entity) null) && Entity.op_Inequality((Entity) this.HatchL02, (Entity) null)) && (Entity.op_Inequality((Entity) this.Lift, (Entity) null) && Entity.op_Inequality((Entity) this.HangerDR, (Entity) null)) && Entity.op_Inequality((Entity) this.HangerDL, (Entity) null))
        {
          if (this.SeaSparrowUpgrade == 1 && !this.SeaSparrowOut)
          {
            if (Entity.op_Inequality((Entity) this.Seasparrow, (Entity) null))
              ((Entity) this.Seasparrow).Delete();
            this.Seasparrow = World.CreateVehicle(this.RequestModel("SEASPARROW3"), new Vector3(1561.547f, 411.2735f, -51.1282f), 178f);
            this.Seasparrow.IsDriveable = false;
            ((Entity) this.Seasparrow).IsInvincible = true;
            ((Entity) this.Seasparrow).FreezePosition = true;
            this.Seasparrow.PrimaryColor = this.SeaSparrowPrimaryColor;
            this.Seasparrow.SecondaryColor = this.SeaSparrowSecondaryColor;
            Function.Call((Hash) 2245783831530643834L, new InputArgument[2]
            {
              InputArgument.op_Implicit(((Entity) this.Seasparrow).Handle),
              InputArgument.op_Implicit(0)
            });
            this.Seasparrow.SetMod((VehicleMod) 10, this.SeasparrowWeapons, true);
          }
          if (this.AvisaUpgrade == 1 && !this.AvisaOut)
          {
            if (Entity.op_Inequality((Entity) this.Avisa, (Entity) null))
              ((Entity) this.Avisa).Delete();
            this.Avisa = World.CreateVehicle(this.RequestModel("AVISA"), new Vector3(1561.525f, 410.06f, -56.5991f), -178f);
            this.Avisa.IsDriveable = false;
            ((Entity) this.Avisa).IsInvincible = true;
            ((Entity) this.Avisa).FreezePosition = true;
            this.Avisa.PrimaryColor = this.AvisaPrimaryColor;
            this.Avisa.SecondaryColor = this.AvisaSecondaryColor;
          }
          if (this.ToreadorUpgrade == 1 && !this.ToreadorOut)
          {
            if (Entity.op_Inequality((Entity) this.Toreador, (Entity) null))
              ((Entity) this.Toreador).Delete();
            this.Toreador = World.CreateVehicle(this.RequestModel("Toreador"), new Vector3(1561.381f, 416.9739f, -55f), 180f);
            this.Toreador.IsDriveable = true;
            ((Entity) this.Toreador).IsInvincible = true;
            ((Entity) this.Toreador).FreezePosition = false;
            this.Toreador.PrimaryColor = this.ToreadorPrimaryColor;
            this.Toreador.SecondaryColor = this.ToreadorSecondaryColor;
          }
          this.GotExitEnterProps = true;
        }
      }
      if (this.GotExitEnterProps && (double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1557.997f, 404.82f, -49.68f)) > 30.0)
        this.GotExitEnterProps = false;
      if (File.Exists("scripts\\WorkingKosatkaSubmarine.dll"))
        this.DisableTresurechests = true;
      if (!File.Exists("scripts\\WorkingKosatkaSubmarine.dll"))
        this.DisableTresurechests = false;
      if (!this.DisableTresurechests)
      {
        foreach (KosatkaScript.Wreck underwaterChest in this.UnderwaterChests)
        {
          if (Entity.op_Inequality((Entity) Game.Player.Character.CurrentVehicle, (Entity) this.Kosatka) && underwaterChest.Created && (double) World.GetDistance(((Entity) Game.Player.Character).Position, underwaterChest.L) >= 50.0)
          {
            if (Blip.op_Inequality(underwaterChest.Blip, (Blip) null))
              underwaterChest.Blip.Remove();
            underwaterChest.Created = false;
          }
          if (Entity.op_Inequality((Entity) underwaterChest.Chest, (Entity) null) && !underwaterChest.Created && (this.DisplayChestBlipsOnFoot && (double) World.GetDistance(((Entity) Game.Player.Character).Position, underwaterChest.L) < 50.0))
          {
            if (Blip.op_Inequality(underwaterChest.Blip, (Blip) null))
              underwaterChest.Blip.Remove();
            underwaterChest.Created = true;
            underwaterChest.Blip = World.CreateBlip(underwaterChest.L);
            underwaterChest.Blip.Sprite = (BlipSprite) 618;
            underwaterChest.Blip.Name = "Underwater Chest";
            underwaterChest.Blip.Scale = 0.6f;
            underwaterChest.Blip.Color = (BlipColor) 66;
          }
          if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, underwaterChest.L) < 200.0 && !underwaterChest.CreatedChest)
          {
            if (underwaterChest.SecondaryProps.Count > 0)
            {
              foreach (Prop secondaryProp in underwaterChest.SecondaryProps)
              {
                if (Entity.op_Inequality((Entity) secondaryProp, (Entity) null))
                  ((Entity) secondaryProp).Delete();
              }
              underwaterChest.SecondaryProps.Clear();
            }
            if (Entity.op_Inequality((Entity) underwaterChest.Coin, (Entity) null))
              ((Entity) underwaterChest.Coin).Delete();
            if (Entity.op_Inequality((Entity) underwaterChest.Chest, (Entity) null))
              ((Entity) underwaterChest.Chest).Delete();
            if (Entity.op_Inequality((Entity) underwaterChest.GoldCoins, (Entity) null))
              ((Entity) underwaterChest.GoldCoins).Delete();
            underwaterChest.UnderwaterChestScene = 0;
            underwaterChest.CreatedChest = true;
            Vector3 l = underwaterChest.L;
            // ISSUE: explicit constructor call
            ((Vector3) ref l).\u002Ector((float) l.X, (float) l.Y, World.GetGroundHeight(l) + 0.05f);
            int num = new Random().Next(0, 400);
            if (num <= 100)
              underwaterChest.Type = 1;
            if (num > 100 && num <= 200)
              underwaterChest.Type = 2;
            if (num > 200 && num <= 300)
              underwaterChest.Type = 3;
            if (num > 300 && num <= 400)
              underwaterChest.Type = 4;
            if (underwaterChest.Type == 1)
            {
              underwaterChest.Chest = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), new Vector3((float) l.X, (float) l.Y, (float) l.Z), false, false);
              underwaterChest.GoldCoins = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), new Vector3((float) l.X, (float) l.Y, (float) l.Z), true, false);
              Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
              {
                InputArgument.op_Implicit(underwaterChest.GoldCoins),
                InputArgument.op_Implicit(underwaterChest.Chest),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(1)
              });
            }
            if (underwaterChest.Type == 2)
            {
              underwaterChest.Chest = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), new Vector3((float) l.X, (float) l.Y, (float) l.Z), false, false);
              Script.Wait(10);
              Prop prop1 = World.CreateProp(this.RequestModel("ch_prop_gold_bar_01a"), ((Entity) underwaterChest.Chest).GetOffsetInWorldCoords(new Vector3(0.1f, 0.6f, 0.6f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
              ((Entity) prop1).FreezePosition = true;
              underwaterChest.SecondaryProps.Add(prop1);
              Prop prop2 = World.CreateProp(this.RequestModel("ch_prop_gold_bar_01a"), ((Entity) underwaterChest.Chest).GetOffsetInWorldCoords(new Vector3(0.2f, 0.6f, 0.6f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
              ((Entity) prop2).FreezePosition = true;
              underwaterChest.SecondaryProps.Add(prop2);
              Prop prop3 = World.CreateProp(this.RequestModel("ch_prop_gold_bar_01a"), ((Entity) underwaterChest.Chest).GetOffsetInWorldCoords(new Vector3(-0.2f, 0.6f, 0.6f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
              ((Entity) prop3).FreezePosition = true;
              underwaterChest.SecondaryProps.Add(prop3);
              Prop prop4 = World.CreateProp(this.RequestModel("ch_prop_gold_bar_01a"), ((Entity) underwaterChest.Chest).GetOffsetInWorldCoords(new Vector3(-0.1f, 0.6f, 0.6f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
              ((Entity) prop4).FreezePosition = true;
              underwaterChest.SecondaryProps.Add(prop4);
              Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
              {
                InputArgument.op_Implicit(prop1),
                InputArgument.op_Implicit(underwaterChest.Chest),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0.05f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.1f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
              {
                InputArgument.op_Implicit(prop2),
                InputArgument.op_Implicit(underwaterChest.Chest),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0.15f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.1f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
              {
                InputArgument.op_Implicit(prop3),
                InputArgument.op_Implicit(underwaterChest.Chest),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(-0.15f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.1f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
              {
                InputArgument.op_Implicit(prop4),
                InputArgument.op_Implicit(underwaterChest.Chest),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(-0.05f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.1f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(0)
              });
            }
            if (underwaterChest.Type == 3)
            {
              underwaterChest.Chest = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), new Vector3((float) l.X, (float) l.Y, (float) l.Z), false, false);
              Script.Wait(10);
              Prop prop1 = World.CreateProp(this.RequestModel("ch_prop_vault_dimaondbox_01a"), ((Entity) underwaterChest.Chest).GetOffsetInWorldCoords(new Vector3(0.1f, 0.6f, 0.6f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
              ((Entity) prop1).FreezePosition = true;
              underwaterChest.SecondaryProps.Add(prop1);
              Prop prop2 = World.CreateProp(this.RequestModel("ch_prop_vault_dimaondbox_01a"), ((Entity) underwaterChest.Chest).GetOffsetInWorldCoords(new Vector3(0.2f, 0.6f, 0.6f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
              ((Entity) prop2).FreezePosition = true;
              underwaterChest.SecondaryProps.Add(prop2);
              Prop prop3 = World.CreateProp(this.RequestModel("ch_prop_vault_dimaondbox_01a"), ((Entity) underwaterChest.Chest).GetOffsetInWorldCoords(new Vector3(-0.2f, 0.6f, 0.6f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
              ((Entity) prop3).FreezePosition = true;
              underwaterChest.SecondaryProps.Add(prop3);
              Prop prop4 = World.CreateProp(this.RequestModel("ch_prop_vault_dimaondbox_01a"), ((Entity) underwaterChest.Chest).GetOffsetInWorldCoords(new Vector3(-0.1f, 0.6f, 0.6f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
              ((Entity) prop4).FreezePosition = true;
              underwaterChest.SecondaryProps.Add(prop4);
              Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
              {
                InputArgument.op_Implicit(prop1),
                InputArgument.op_Implicit(underwaterChest.Chest),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0.05f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.1f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
              {
                InputArgument.op_Implicit(prop2),
                InputArgument.op_Implicit(underwaterChest.Chest),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0.15f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.1f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
              {
                InputArgument.op_Implicit(prop3),
                InputArgument.op_Implicit(underwaterChest.Chest),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(-0.15f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.1f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
              {
                InputArgument.op_Implicit(prop4),
                InputArgument.op_Implicit(underwaterChest.Chest),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(-0.05f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.1f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(0)
              });
            }
            if (underwaterChest.Type == 4)
            {
              underwaterChest.Chest = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), new Vector3((float) l.X, (float) l.Y, (float) l.Z), false, false);
              Script.Wait(10);
              Prop prop1 = World.CreateProp(this.RequestModel("ch_prop_20dollar_pile_01a"), ((Entity) underwaterChest.Chest).GetOffsetInWorldCoords(new Vector3(0.1f, 0.6f, 0.6f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
              ((Entity) prop1).FreezePosition = true;
              underwaterChest.SecondaryProps.Add(prop1);
              Prop prop2 = World.CreateProp(this.RequestModel("ch_prop_20dollar_pile_01a"), ((Entity) underwaterChest.Chest).GetOffsetInWorldCoords(new Vector3(0.2f, 0.6f, 0.6f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
              ((Entity) prop2).FreezePosition = true;
              underwaterChest.SecondaryProps.Add(prop2);
              Prop prop3 = World.CreateProp(this.RequestModel("ch_prop_20dollar_pile_01a"), ((Entity) underwaterChest.Chest).GetOffsetInWorldCoords(new Vector3(-0.2f, 0.6f, 0.6f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
              ((Entity) prop3).FreezePosition = true;
              underwaterChest.SecondaryProps.Add(prop3);
              Prop prop4 = World.CreateProp(this.RequestModel("ch_prop_20dollar_pile_01a"), ((Entity) underwaterChest.Chest).GetOffsetInWorldCoords(new Vector3(-0.1f, 0.6f, 0.6f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
              ((Entity) prop4).FreezePosition = true;
              underwaterChest.SecondaryProps.Add(prop4);
              Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
              {
                InputArgument.op_Implicit(prop1),
                InputArgument.op_Implicit(underwaterChest.Chest),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0.05f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.1f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
              {
                InputArgument.op_Implicit(prop2),
                InputArgument.op_Implicit(underwaterChest.Chest),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0.15f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.1f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
              {
                InputArgument.op_Implicit(prop3),
                InputArgument.op_Implicit(underwaterChest.Chest),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(-0.15f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.1f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
              {
                InputArgument.op_Implicit(prop4),
                InputArgument.op_Implicit(underwaterChest.Chest),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(-0.05f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.1f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0.0f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(0)
              });
            }
            ((Entity) underwaterChest.Chest).FreezePosition = true;
            if (this.EnableChestGlow)
            {
              if (Pickup.op_Inequality(underwaterChest.Pickup, (Pickup) null))
                underwaterChest.Pickup.Delete();
              underwaterChest.Pickup = World.CreatePickup((PickupType) 513448440, ((Entity) underwaterChest.Chest).Position, ((Entity) underwaterChest.Chest).Rotation, this.RequestModel("h4_prop_h4_chest_01a"), 1);
              ((Entity) underwaterChest.Chest).Alpha = 0;
            }
            Script.Wait(10);
            underwaterChest.RobbingChest = true;
          }
          if (underwaterChest.CreatedChest)
          {
            if (underwaterChest.RobbingChest)
            {
              if (Entity.op_Inequality((Entity) underwaterChest.Chest, (Entity) null))
              {
                if (this.EnableChestGlow && (double) World.GetDistance(((Entity) Game.Player.Character).Position, ((Entity) underwaterChest.Chest).Position) < 5.25 && Pickup.op_Inequality(underwaterChest.Pickup, (Pickup) null))
                {
                  ((Entity) underwaterChest.Chest).Alpha = (int) byte.MaxValue;
                  underwaterChest.Pickup.Delete();
                }
                if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, ((Entity) underwaterChest.Chest).Position) < 2.25 && underwaterChest.UnderwaterChestScene == 0)
                  this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Open Chest");
              }
              if (Entity.op_Inequality((Entity) underwaterChest.Chest, (Entity) null) && Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.Player.Character).Position, ((Entity) underwaterChest.Chest).Position) < 2.25)
              {
                if (Blip.op_Inequality(underwaterChest.Blip, (Blip) null))
                  underwaterChest.Blip.Remove();
                Vector3 position = ((Entity) Game.Player.Character).Position;
                if (underwaterChest.Type == 1)
                {
                  if (Entity.op_Inequality((Entity) underwaterChest.Coin, (Entity) null))
                    ((Entity) underwaterChest.Coin).Delete();
                  underwaterChest.Coin = World.CreateProp(this.RequestModel("h4_prop_h4_gold_coin_01a"), new Vector3((float) position.X, (float) position.Y, (float) (position.Z + 0.100000001490116)), true, false);
                }
                Game.Player.Character.Weapons.Give((WeaponHash) -1569615261, 1, true, true);
                Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
                string dict = "";
                if (Game.Player.Character.IsSwimming)
                {
                  underwaterChest.WasSwimming = true;
                  dict = "anim@scripted@heist@ig21_chest_underwater@male@";
                }
                if (!Game.Player.Character.IsSwimming)
                {
                  underwaterChest.WasSwimming = false;
                  dict = "anim@scripted@heist@ig20_chest_land@male@";
                }
                string str = "action_male";
                KosatkaScript.LoadDict(dict);
                underwaterChest.UnderwaterChestScene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) underwaterChest.Chest).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) underwaterChest.Chest).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) underwaterChest.Chest).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(((Entity) underwaterChest.Chest).Heading),
                  InputArgument.op_Implicit(2)
                });
                Game.Player.Character.Weapons.Give((WeaponHash) -1569615261, 1, true, true);
                Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
                Function.Call((Hash) -1249422255215503276L, new InputArgument[10]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(underwaterChest.UnderwaterChestScene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(str),
                  InputArgument.op_Implicit(3000.0),
                  InputArgument.op_Implicit(-2.0),
                  InputArgument.op_Implicit(128),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080),
                  InputArgument.op_Implicit(0)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(underwaterChest.UnderwaterChestScene),
                  InputArgument.op_Implicit(0.0)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[10]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(underwaterChest.UnderwaterChestScene),
                  InputArgument.op_Implicit(str),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(3000.0),
                  InputArgument.op_Implicit(-2f),
                  InputArgument.op_Implicit(-2f),
                  InputArgument.op_Implicit(((Entity) underwaterChest.Chest).Heading - 90f),
                  InputArgument.op_Implicit(1148846080),
                  InputArgument.op_Implicit(0)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[10]
                {
                  InputArgument.op_Implicit(underwaterChest.Chest),
                  InputArgument.op_Implicit(underwaterChest.UnderwaterChestScene),
                  InputArgument.op_Implicit("action_chest"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(3000.0),
                  InputArgument.op_Implicit(-2f),
                  InputArgument.op_Implicit(-2f),
                  InputArgument.op_Implicit(((Entity) underwaterChest.Chest).Heading - 90f),
                  InputArgument.op_Implicit(1148846080),
                  InputArgument.op_Implicit(0)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[10]
                {
                  InputArgument.op_Implicit(underwaterChest.Coin),
                  InputArgument.op_Implicit(underwaterChest.UnderwaterChestScene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("action_goldcoin"),
                  InputArgument.op_Implicit(3000.0),
                  InputArgument.op_Implicit(-2.0),
                  InputArgument.op_Implicit(128),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080),
                  InputArgument.op_Implicit(0)
                });
                if (underwaterChest.Type == 1)
                  Function.Call((Hash) -4073751461268206970L, new InputArgument[10]
                  {
                    InputArgument.op_Implicit(underwaterChest.Coin),
                    InputArgument.op_Implicit(underwaterChest.UnderwaterChestScene),
                    InputArgument.op_Implicit("action_goldcoin"),
                    InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                    InputArgument.op_Implicit(3000.0),
                    InputArgument.op_Implicit(-2f),
                    InputArgument.op_Implicit(-2f),
                    InputArgument.op_Implicit(((Entity) underwaterChest.Chest).Heading - 90f),
                    InputArgument.op_Implicit(1148846080),
                    InputArgument.op_Implicit(0)
                  });
                Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
                {
                  InputArgument.op_Implicit(underwaterChest.Coin),
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(Game.Player.Character.GetBoneIndex((Bone) 28422)),
                  InputArgument.op_Implicit(0.0f),
                  InputArgument.op_Implicit(0.0f),
                  InputArgument.op_Implicit(0.0f),
                  InputArgument.op_Implicit(0.0f),
                  InputArgument.op_Implicit(0.0f),
                  InputArgument.op_Implicit(0.0f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(2),
                  InputArgument.op_Implicit(1)
                });
                if (underwaterChest.Type == 1)
                {
                  Function.Call((Hash) -1249422255215503276L, new InputArgument[10]
                  {
                    InputArgument.op_Implicit(underwaterChest.GoldCoins),
                    InputArgument.op_Implicit(underwaterChest.UnderwaterChestScene),
                    InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                    InputArgument.op_Implicit("action_goldpile"),
                    InputArgument.op_Implicit(3000.0),
                    InputArgument.op_Implicit(-2.0),
                    InputArgument.op_Implicit(128),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(1148846080),
                    InputArgument.op_Implicit(0)
                  });
                  Function.Call((Hash) -4073751461268206970L, new InputArgument[10]
                  {
                    InputArgument.op_Implicit(underwaterChest.GoldCoins),
                    InputArgument.op_Implicit(underwaterChest.UnderwaterChestScene),
                    InputArgument.op_Implicit("action_goldpile"),
                    InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                    InputArgument.op_Implicit(3000.0),
                    InputArgument.op_Implicit(-2f),
                    InputArgument.op_Implicit(-2f),
                    InputArgument.op_Implicit(((Entity) underwaterChest.Chest).Heading - 90f),
                    InputArgument.op_Implicit(1148846080),
                    InputArgument.op_Implicit(0)
                  });
                }
              }
              int num1;
              if (Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
              {
                InputArgument.op_Implicit(underwaterChest.UnderwaterChestScene)
              }) >= 1058853216)
                num1 = Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(underwaterChest.UnderwaterChestScene)
                }) <= 1059353216 ? 1 : 0;
              else
                num1 = 0;
              if (num1 != 0)
              {
                Vector3 position = ((Entity) Game.Player.Character).Position;
                if (Entity.op_Inequality((Entity) underwaterChest.Coin, (Entity) null))
                  ((Entity) underwaterChest.Coin).Delete();
                underwaterChest.Coin = World.CreateProp(this.RequestModel("h4_prop_h4_gold_coin_01a"), new Vector3((float) position.X, (float) position.Y, (float) (position.Z + 0.100000001490116)), true, false);
              }
              if (underwaterChest.Type != 1)
              {
                if (underwaterChest.WasSwimming)
                {
                  int num2;
                  if (Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(underwaterChest.UnderwaterChestScene)
                  }) >= 1054853216)
                    num2 = Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                    {
                      InputArgument.op_Implicit(underwaterChest.UnderwaterChestScene)
                    }) <= 1055353216 ? 1 : 0;
                  else
                    num2 = 0;
                  if (num2 != 0)
                    Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
                    {
                      InputArgument.op_Implicit(underwaterChest.SecondaryProps[0]),
                      InputArgument.op_Implicit(Game.Player.Character),
                      InputArgument.op_Implicit(Game.Player.Character.GetBoneIndex((Bone) 28422)),
                      InputArgument.op_Implicit(0.0f),
                      InputArgument.op_Implicit(0.0f),
                      InputArgument.op_Implicit(0.0f),
                      InputArgument.op_Implicit(0.0f),
                      InputArgument.op_Implicit(0.0f),
                      InputArgument.op_Implicit(0.0f),
                      InputArgument.op_Implicit(0),
                      InputArgument.op_Implicit(0),
                      InputArgument.op_Implicit(0),
                      InputArgument.op_Implicit(0),
                      InputArgument.op_Implicit(2),
                      InputArgument.op_Implicit(1)
                    });
                }
                if (!underwaterChest.WasSwimming)
                {
                  int num2;
                  if (Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(underwaterChest.UnderwaterChestScene)
                  }) >= 1051853216)
                    num2 = Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                    {
                      InputArgument.op_Implicit(underwaterChest.UnderwaterChestScene)
                    }) <= 1052353216 ? 1 : 0;
                  else
                    num2 = 0;
                  if (num2 != 0)
                    Function.Call((Hash) 7753999234533660383L, new InputArgument[15]
                    {
                      InputArgument.op_Implicit(underwaterChest.SecondaryProps[3]),
                      InputArgument.op_Implicit(Game.Player.Character),
                      InputArgument.op_Implicit(Game.Player.Character.GetBoneIndex((Bone) 28422)),
                      InputArgument.op_Implicit(0.0f),
                      InputArgument.op_Implicit(0.0f),
                      InputArgument.op_Implicit(0.0f),
                      InputArgument.op_Implicit(0.0f),
                      InputArgument.op_Implicit(0.0f),
                      InputArgument.op_Implicit(0.0f),
                      InputArgument.op_Implicit(0),
                      InputArgument.op_Implicit(0),
                      InputArgument.op_Implicit(0),
                      InputArgument.op_Implicit(0),
                      InputArgument.op_Implicit(2),
                      InputArgument.op_Implicit(1)
                    });
                }
              }
              if (Game.Player.Character.IsSwimming)
                ;
              if (Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
              {
                InputArgument.op_Implicit(underwaterChest.UnderwaterChestScene)
              }) >= 1065353216)
              {
                if (Entity.op_Inequality((Entity) underwaterChest.Coin, (Entity) null))
                  ((Entity) underwaterChest.Coin).Delete();
                if (underwaterChest.Type != 1)
                {
                  if (Game.Player.Character.IsSwimming && Entity.op_Inequality((Entity) underwaterChest.SecondaryProps[0], (Entity) null))
                    ((Entity) underwaterChest.SecondaryProps[0]).Delete();
                  if (!Game.Player.Character.IsSwimming && Entity.op_Inequality((Entity) underwaterChest.SecondaryProps[3], (Entity) null))
                    ((Entity) underwaterChest.SecondaryProps[3]).Delete();
                }
                ++this.ChestCollected;
                this.Config.SetValue<int>("TreasureChests", "ChestsCollected", (M0) this.ChestCollected);
                this.Config.Save();
                if (underwaterChest.Type == 1)
                  Game.Player.Money += 35000;
                if (underwaterChest.Type == 2)
                  Game.Player.Money += 75000;
                if (underwaterChest.Type == 3)
                  Game.Player.Money += 85000;
                if (underwaterChest.Type == 4)
                  Game.Player.Money += 25000;
                underwaterChest.UnderwaterChestScene = 0;
                underwaterChest.RobbingChest = false;
                Game.Player.Character.Task.ClearAll();
              }
            }
            if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, underwaterChest.L) > 200.0)
            {
              underwaterChest.WasSwimming = false;
              if (underwaterChest.SecondaryProps.Count > 0)
              {
                foreach (Prop secondaryProp in underwaterChest.SecondaryProps)
                {
                  if (Entity.op_Inequality((Entity) secondaryProp, (Entity) null))
                    ((Entity) secondaryProp).Delete();
                }
                underwaterChest.SecondaryProps.Clear();
              }
              underwaterChest.UnderwaterChestScene = 0;
              underwaterChest.RobbingChest = false;
              if (Entity.op_Inequality((Entity) underwaterChest.Coin, (Entity) null))
                ((Entity) underwaterChest.Coin).Delete();
              if (Entity.op_Inequality((Entity) underwaterChest.Chest, (Entity) null))
                ((Entity) underwaterChest.Chest).Delete();
              if (Entity.op_Inequality((Entity) underwaterChest.GoldCoins, (Entity) null))
                ((Entity) underwaterChest.GoldCoins).Delete();
              underwaterChest.CreatedChest = false;
            }
          }
        }
      }
      if (this.IsInInterior)
      {
        if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1563.548f, 400.1665f, -50.29f)) < 55.0)
        {
          if (this.Duf_WhiteBoard_Title3 == null)
            this.Duf_WhiteBoard_Title3 = new Scaleform("PLAYER_NAME_03");
          Vector3 vector3;
          // ISSUE: explicit constructor call
          ((Vector3) ref vector3).\u002Ector(1563.548f, 400.1665f, -50.29f);
          this.Duf_WhiteBoard_Title3.CallFunction("SET_PLAYER_NAME", new object[1]
          {
            (object) ("Chests Found : " + this.ChestCollected.ToString())
          });
          this.Duf_WhiteBoard_Title3.Render3D(Vector3.op_Addition(vector3, new Vector3(0.0f, 0.0f, 1.5f)), new Vector3(0.0f, 87f, 90f), new Vector3(6f, 4f, 2f));
        }
        if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1558.204f, 380.8241f, -53.28f)) < 1.25)
        {
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Access Wardrobe");
          if (Game.IsControlJustPressed(2, (Control) 51) && !this.Wardrobe.Visible)
            this.Wardrobe.Visible = true;
          if (this.mainMenu.Visible)
            this.modMenuPool.CloseAllMenus();
          if (this.FirstMenu.Visible)
            this.modMenuPool.CloseAllMenus();
        }
        if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1558.728f, 382.82f, -53.28f)) < 1.25)
        {
          this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Sleep");
          if (Game.IsControlJustPressed(2, (Control) 51))
          {
            Function.Call((Hash) -5276917446737307043L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.Scene1),
              InputArgument.op_Implicit(0.0f)
            });
            string dict1 = "mp_bedmid";
            string str1 = "f_getin_l_bighouse";
            KosatkaScript.LoadDict(dict1);
            ((Entity) Game.Player.Character).Position = new Vector3(1558.758f, 382.52f, -54.25f);
            ((Entity) Game.Player.Character).Heading = 8.5f;
            ((Entity) Game.Player.Character).Position = ((Entity) Game.Player.Character).GetOffsetInWorldCoords(new Vector3(0.0f, 2.2f, 0.0f));
            Vector3 position = ((Entity) Game.Player.Character).Position;
            Script.Wait(100);
            this.Scene1 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
            {
              InputArgument.op_Implicit((float) ((Entity) Game.Player.Character).Position.X),
              InputArgument.op_Implicit((float) ((Entity) Game.Player.Character).Position.Y),
              InputArgument.op_Implicit((float) (((Entity) Game.Player.Character).Position.Z - 1.5)),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit(((Entity) Game.Player.Character).Heading),
              InputArgument.op_Implicit(2)
            });
            Function.Call((Hash) -1249422255215503276L, new InputArgument[10]
            {
              InputArgument.op_Implicit(Game.Player.Character),
              InputArgument.op_Implicit(this.Scene1),
              InputArgument.op_Implicit(KosatkaScript.LoadDict(dict1)),
              InputArgument.op_Implicit(str1),
              InputArgument.op_Implicit(3000.0),
              InputArgument.op_Implicit(-2.0),
              InputArgument.op_Implicit(128),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1148846080),
              InputArgument.op_Implicit(0)
            });
            Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.Scene1),
              InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
              {
                InputArgument.op_Implicit(this.Scene1)
              }))
            });
            Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.Scene1),
              InputArgument.op_Implicit(0.0)
            });
            Function.Call((Hash) -4073751461268206970L, new InputArgument[10]
            {
              InputArgument.op_Implicit(Game.Player.Character),
              InputArgument.op_Implicit(this.Scene1),
              InputArgument.op_Implicit(str1),
              InputArgument.op_Implicit(KosatkaScript.LoadDict(dict1)),
              InputArgument.op_Implicit(3000.0),
              InputArgument.op_Implicit(-2f),
              InputArgument.op_Implicit(-2f),
              InputArgument.op_Implicit(((Entity) Game.Player.Character).Heading),
              InputArgument.op_Implicit(1148846080),
              InputArgument.op_Implicit(0)
            });
            Script.Wait(15000);
            string dict2 = "mp_bedmid";
            string str2 = "f_sleep_l_loop_bighouse";
            KosatkaScript.LoadDict(dict2);
            ((Entity) Game.Player.Character).Health = ((Entity) Game.Player.Character).MaxHealth;
            Script.Wait(100);
            this.Scene1 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
            {
              InputArgument.op_Implicit((float) position.X),
              InputArgument.op_Implicit((float) position.Y),
              InputArgument.op_Implicit((float) (position.Z - 1.54999995231628)),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit(((Entity) Game.Player.Character).Heading + 90f),
              InputArgument.op_Implicit(2)
            });
            Function.Call((Hash) -1249422255215503276L, new InputArgument[10]
            {
              InputArgument.op_Implicit(Game.Player.Character),
              InputArgument.op_Implicit(this.Scene1),
              InputArgument.op_Implicit(KosatkaScript.LoadDict(dict2)),
              InputArgument.op_Implicit(str2),
              InputArgument.op_Implicit(3000.0),
              InputArgument.op_Implicit(-2.0),
              InputArgument.op_Implicit(128),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1148846080),
              InputArgument.op_Implicit(0)
            });
            Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.Scene1),
              InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
              {
                InputArgument.op_Implicit(this.Scene1)
              }))
            });
            Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.Scene1),
              InputArgument.op_Implicit(0.0)
            });
            Function.Call((Hash) -4073751461268206970L, new InputArgument[10]
            {
              InputArgument.op_Implicit(Game.Player.Character),
              InputArgument.op_Implicit(this.Scene1),
              InputArgument.op_Implicit(str2),
              InputArgument.op_Implicit(KosatkaScript.LoadDict(dict2)),
              InputArgument.op_Implicit(3000.0),
              InputArgument.op_Implicit(-2f),
              InputArgument.op_Implicit(-2f),
              InputArgument.op_Implicit(((Entity) Game.Player.Character).Heading),
              InputArgument.op_Implicit(1148846080),
              InputArgument.op_Implicit(0)
            });
            Script.Wait(4000);
            string dict3 = "mp_bedmid";
            string str3 = "f_getout_l_bighouse";
            KosatkaScript.LoadDict(dict3);
            Script.Wait(100);
            this.Scene1 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
            {
              InputArgument.op_Implicit((float) position.X),
              InputArgument.op_Implicit((float) position.Y),
              InputArgument.op_Implicit((float) (position.Z - 1.5)),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit(((Entity) Game.Player.Character).Heading + 90f),
              InputArgument.op_Implicit(2)
            });
            Function.Call((Hash) -1249422255215503276L, new InputArgument[10]
            {
              InputArgument.op_Implicit(Game.Player.Character),
              InputArgument.op_Implicit(this.Scene1),
              InputArgument.op_Implicit(KosatkaScript.LoadDict(dict3)),
              InputArgument.op_Implicit(str3),
              InputArgument.op_Implicit(3000.0),
              InputArgument.op_Implicit(-2.0),
              InputArgument.op_Implicit(128),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1148846080),
              InputArgument.op_Implicit(0)
            });
            Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.Scene1),
              InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
              {
                InputArgument.op_Implicit(this.Scene1)
              }))
            });
            Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
            {
              InputArgument.op_Implicit(this.Scene1),
              InputArgument.op_Implicit(0.0)
            });
            Function.Call((Hash) -4073751461268206970L, new InputArgument[10]
            {
              InputArgument.op_Implicit(Game.Player.Character),
              InputArgument.op_Implicit(this.Scene1),
              InputArgument.op_Implicit(str3),
              InputArgument.op_Implicit(KosatkaScript.LoadDict(dict3)),
              InputArgument.op_Implicit(3000.0),
              InputArgument.op_Implicit(-2f),
              InputArgument.op_Implicit(-2f),
              InputArgument.op_Implicit(((Entity) Game.Player.Character).Heading),
              InputArgument.op_Implicit(1148846080),
              InputArgument.op_Implicit(0)
            });
            Script.Wait(4000);
            Game.Player.Character.Task.ClearAll();
          }
        }
      }
      if (this.ReadyForRiseAnim)
      {
        this.PlayingRiseAnim = true;
        this.ReadyForRiseAnim = false;
        this.LoadIniFile("scripts//CayoPericoInSp//Submarine.ini");
        Function.Call((Hash) -6851178707428514157L, new InputArgument[1]
        {
          InputArgument.op_Implicit(false)
        });
        Vector3 position = ((Entity) this.Kosatka).Position;
        ((Entity) Game.Player.Character).Position = ((Entity) this.Kosatka).Position;
        if (Camera.op_Inequality(this.DroneCam, (Camera) null))
          this.DroneCam.Destroy();
        this.DroneCam = (Camera) Function.Call<Camera>((Hash) -4352696267611446977L, new InputArgument[2]
        {
          InputArgument.op_Implicit("DEFAULT_ANIMATED_CAMERA"),
          InputArgument.op_Implicit(0)
        });
        KosatkaScript.LoadDict("anim@scripted@submarine@sub_fast_travel@");
        Script.Wait(50);
        this.SubRiseAnim = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
        {
          InputArgument.op_Implicit((float) position.X),
          InputArgument.op_Implicit((float) position.Y),
          InputArgument.op_Implicit((float) (position.Z + 5.0)),
          InputArgument.op_Implicit(0.0),
          InputArgument.op_Implicit(0.0),
          InputArgument.op_Implicit(((Entity) this.Kosatka).Heading),
          InputArgument.op_Implicit(2)
        });
        Function.Call((Hash) -1249422255215503276L, new InputArgument[10]
        {
          InputArgument.op_Implicit(this.Kosatka),
          InputArgument.op_Implicit(this.SubRiseAnim),
          InputArgument.op_Implicit(KosatkaScript.LoadDict("anim@scripted@submarine@sub_fast_travel@")),
          InputArgument.op_Implicit("sub_fast_travel_end"),
          InputArgument.op_Implicit(0.0),
          InputArgument.op_Implicit(0.0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1148846080),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
        {
          InputArgument.op_Implicit(this.Kosatka),
          InputArgument.op_Implicit(this.SubRiseAnim),
          InputArgument.op_Implicit("sub_fast_travel_end"),
          InputArgument.op_Implicit(KosatkaScript.LoadDict("anim@scripted@submarine@sub_fast_travel@")),
          InputArgument.op_Implicit(1000f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1000f)
        });
        Function.Call((Hash) -7337190956853812334L, new InputArgument[11]
        {
          InputArgument.op_Implicit(this.DroneCam),
          InputArgument.op_Implicit("sub_fast_travel_start_cam"),
          InputArgument.op_Implicit(KosatkaScript.LoadDict("anim@scripted@submarine@sub_fast_travel@")),
          InputArgument.op_Implicit((float) ((Entity) this.Kosatka).Position.X),
          InputArgument.op_Implicit((float) ((Entity) this.Kosatka).Position.Y),
          InputArgument.op_Implicit((float) ((Entity) this.Kosatka).Position.Z),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(0.0f),
          InputArgument.op_Implicit(((Entity) this.Kosatka).Heading),
          InputArgument.op_Implicit(false),
          InputArgument.op_Implicit(2)
        });
        World.RenderingCamera = this.DroneCam;
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        this.IsInInterior = false;
      }
      if (this.PlayingRiseAnim)
      {
        if (Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
        {
          InputArgument.op_Implicit(this.SubRiseAnim)
        }) >= 1055353216)
        {
          Game.FadeScreenOut(3200);
          Script.Wait(500);
          Function.Call((Hash) 569060033405794044L, new InputArgument[5]
          {
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(3000),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0)
          });
          this.DroneCam.Destroy();
          if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
          {
            ((Entity) this.Kosatka).Delete();
            Script.Wait(500);
            this.SpawnMOC();
            Script.Wait(500);
            this.Spawn = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, -54.8f, 3.8f));
            Game.Player.Character.SetIntoVehicle(this.Kosatka, (VehicleSeat) -1);
          }
          Function.Call((Hash) -6851178707428514157L, new InputArgument[1]
          {
            InputArgument.op_Implicit(true)
          });
          UI.Notify("SubRiseAnim Finished");
          this.SubRiseAnim = -1;
          Script.Wait(500);
          Game.FadeScreenIn(3200);
        }
      }
      if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null) && Blip.op_Inequality(this.MOCBlip, (Blip) null))
        this.MOCBlip.Rotation = (int) ((Entity) this.Kosatka).Heading;
      if (this.SubPurchased == 0)
        this.MOCBlip.Alpha = 0;
      if (this.SubPurchased == 1)
        this.MOCBlip.Alpha = (int) byte.MaxValue;
      if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, this.PurchaseMarker) < 80.0)
        World.DrawMarker((MarkerType) 1, this.PurchaseMarker, Vector3.Zero, Vector3.Zero, new Vector3(0.65f, 0.65f, 0.4f), Color.Gray);
      if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, this.PurchaseMarker) < 3.0)
      {
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Purchase/Upgrade Kosatka");
        if (Game.IsControlJustPressed(2, (Control) 51) && !this.mainMenu.Visible)
          this.mainMenu.Visible = !this.mainMenu.Visible;
      }
      if (Entity.op_Inequality((Entity) this.Avisa, (Entity) null) && this.AvisaOut && (this.AvisaDestroyedTimer <= 2500 && !((Entity) this.Avisa).IsAlive))
      {
        UI.Notify("You Avisa has been Destroyed, it will take longer for it to respawn");
        this.AvisaDestroyedTimer = 4500;
        this.Config.SetValue<int>("Moonpool", "AvisaDestroyedTimer", (M0) this.AvisaDestroyedTimer);
        this.Config.SetValue<bool>("Moonpool", "AvisaOut", (M0) (this.AvisaOut ? 1 : 0));
        this.Config.Save();
      }
      if (Entity.op_Inequality((Entity) this.Seasparrow, (Entity) null) && this.SeaSparrowOut && (this.SeaSparrowDestroyedTimer <= 2500 && !((Entity) this.Seasparrow).IsAlive))
      {
        UI.Notify("You Seasparrow has been Destroyed, it will take longer for it to respawn");
        this.AvisaDestroyedTimer = 4500;
        this.Config.SetValue<int>("Moonpool", "SeaSparrowDestroyedTimer", (M0) this.SeaSparrowDestroyedTimer);
        this.Config.SetValue<bool>("Moonpool", "SeaSparrowOut", (M0) (this.SeaSparrowOut ? 1 : 0));
        this.Config.Save();
      }
      if (Entity.op_Inequality((Entity) this.Toreador, (Entity) null) && this.ToreadorOut && (this.ToreadorDestroyedTimer <= 2500 && !((Entity) this.Toreador).IsAlive))
      {
        UI.Notify("You Toreador has been Destroyed, it will take longer for it to respawn");
        this.ToreadorDestroyedTimer = 4500;
        this.Config.SetValue<int>("Moonpool", "ToreadorDestroyedTimer", (M0) this.ToreadorDestroyedTimer);
        this.Config.SetValue<bool>("Moonpool", "ToreadorOut", (M0) (this.ToreadorOut ? 1 : 0));
        this.Config.Save();
      }
      if (this.SeaSparrowDestroyedTimer == 0 && this.SeaSparrowOut)
      {
        this.SeaSparrowOut = false;
        this.Config.SetValue<bool>("Moonpool", "SeaSparrowOut", (M0) (this.SeaSparrowOut ? 1 : 0));
        this.Config.Save();
      }
      if (this.AvisaDestroyedTimer == 0 && this.AvisaOut)
      {
        this.AvisaOut = false;
        this.Config.SetValue<bool>("Moonpool", "AvisaOut", (M0) (this.AvisaOut ? 1 : 0));
        this.Config.Save();
      }
      if (this.ToreadorDestroyedTimer == 0 && this.ToreadorOut)
      {
        this.ToreadorOut = false;
        this.Config.SetValue<bool>("Moonpool", "ToreadorOut", (M0) (this.ToreadorOut ? 1 : 0));
        this.Config.Save();
      }
      if (this.SeaSparrowDestroyedTimer > 0 || this.AvisaDestroyedTimer > 0)
      {
        if (this.SpawnTimer == 40)
        {
          if (this.AvisaDestroyedTimer > 0)
            --this.AvisaDestroyedTimer;
          if (this.SeaSparrowDestroyedTimer > 0)
            --this.SeaSparrowDestroyedTimer;
          this.SpawnTimer = 0;
        }
        if (this.SpawnTimer != 40)
          ++this.SpawnTimer;
      }
      if (this.RunningTargetingAlgorithm)
      {
        if (this.Algorithmstage == 0)
        {
          Function.Call((Hash) 569060033405794044L, new InputArgument[5]
          {
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(3000),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0)
          });
          if (Camera.op_Inequality(this.DroneCam, (Camera) null))
            this.DroneCam.Destroy();
          Function.Call((Hash) 6410651044935755444L, Array.Empty<InputArgument>());
          Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
          Function.Call((Hash) 4362080213785518366L, Array.Empty<InputArgument>());
          Function.Call((Hash) 3211975551654944577L, new InputArgument[1]
          {
            InputArgument.op_Implicit("default")
          });
          if (Function.Call<int>((Hash) -147535234440955034L, Array.Empty<InputArgument>()) != -1)
            Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
          Function.Call((Hash) 3211975551654944577L, new InputArgument[1]
          {
            InputArgument.op_Implicit("traffic_skycam")
          });
          Function.Call((Hash) -9013954871696349517L, new InputArgument[1]
          {
            InputArgument.op_Implicit(1f)
          });
          Function.Call((Hash) 4309758426879203100L, new InputArgument[2]
          {
            InputArgument.op_Implicit("traffic_skycam"),
            InputArgument.op_Implicit(1f)
          });
          this.DroneCam = World.CreateCamera(((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 100f)), new Vector3(-90f, 0.0f, 0.0f), 100f);
          Function.Call((Hash) 569060033405794044L, new InputArgument[5]
          {
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(3000),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0)
          });
          World.RenderingCamera = this.DroneCam;
          while (true)
          {
            if (Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
            {
              InputArgument.op_Implicit("helicopterhud")
            }) == 0)
            {
              Script.Wait(10);
              Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
              {
                InputArgument.op_Implicit("helicopterhud"),
                InputArgument.op_Implicit(0)
              });
            }
            else
              break;
          }
          this.Algorithmstage = 1;
        }
        if (this.Algorithmstage == 1)
        {
          this.DisplayTargetingControls();
          while (true)
          {
            if (Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
            {
              InputArgument.op_Implicit("helicopterhud")
            }) == 0)
            {
              Script.Wait(10);
              Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
              {
                InputArgument.op_Implicit("helicopterhud"),
                InputArgument.op_Implicit(0)
              });
            }
            else
              break;
          }
          float screenY = (float) Function.Call<float>((Hash) -1424092350868114077L, new InputArgument[2]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(240)
          });
          float screenX = (float) Function.Call<float>((Hash) -1424092350868114077L, new InputArgument[2]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(239)
          });
          this.drawSpriteRTA2("helicopterhud", "hud_dest", 0.5f, 0.5f, 30f, 50f, 0, 186, 50, (int) byte.MaxValue, 0.0f);
          this.drawSpriteRTA2("helicopterhud", "hud_horiz", 0.5f, 0.95f, 900f, 100f, 0, 186, 50, (int) byte.MaxValue, 0.0f);
          this.drawSpriteRTA2("helicopterhud", "hud_vert", 0.0f, 0.5f, 100f, 1000f, 0, 186, 50, (int) byte.MaxValue, 0.0f);
          this.drawSpriteRTA2("helicopterhud", "hud_dest", screenX, screenY, 30f, 50f, (int) byte.MaxValue, 38, 5, (int) byte.MaxValue, 0.0f);
          this.World3DToScreen2d(((Entity) this.Kosatka).Position);
          float num1;
          if ((double) screenX > 0.4 && (double) screenX < 0.6)
          {
            num1 = 0.0f;
          }
          else
          {
            if ((double) screenX >= 0.600000023841858)
              screenX = 1f - screenX;
            num1 = screenX * 3f;
          }
          float num2;
          if ((double) screenY > 0.4 && (double) screenY < 0.6)
          {
            num2 = 0.0f;
          }
          else
          {
            if ((double) screenY >= 0.600000023841858)
              screenY = 1f - screenY;
            num2 = screenY * 3f;
          }
          Vector3 position1 = this.DroneCam.Position;
          if (Game.IsControlPressed(2, (Control) 34))
          {
            Camera droneCam = this.DroneCam;
            droneCam.Position = Vector3.op_Subtraction(droneCam.Position, new Vector3(2.5f, 0.0f, 0.0f));
          }
          if (Game.IsControlPressed(2, (Control) 267))
          {
            Camera droneCam = this.DroneCam;
            droneCam.Position = Vector3.op_Addition(droneCam.Position, new Vector3(2.5f, 0.0f, 0.0f));
          }
          if (Game.IsControlPressed(2, (Control) 32))
          {
            Camera droneCam = this.DroneCam;
            droneCam.Position = Vector3.op_Addition(droneCam.Position, new Vector3(0.0f, 2.5f, 0.0f));
          }
          if (Game.IsControlPressed(2, (Control) 269))
          {
            Camera droneCam = this.DroneCam;
            droneCam.Position = Vector3.op_Subtraction(droneCam.Position, new Vector3(0.0f, 2.5f, 0.0f));
          }
          Vector3 position2 = this.DroneCam.Position;
          // ISSUE: explicit constructor call
          ((Vector3) ref position2).\u002Ector((float) position2.X, (float) position2.Y, World.GetGroundHeight(position2));
          if (this.TargetsMarked < 1)
          {
            if (Game.IsControlJustPressed(2, (Control) 24))
            {
              ++this.TargetsMarked;
              this.TargetsMarkedListVec3.Add(position2);
              this.TargetsMarkedListVec2.Add(this.World3DToScreen2d(position2));
            }
          }
          else if (this.TargetsMarked >= 1)
          {
            if (Game.IsControlJustPressed(2, (Control) 24))
            {
              this.TargetsMarked = 0;
              this.TargetsMarkedListVec3.Clear();
              this.TargetsMarkedListVec2.Clear();
            }
            if (Game.IsControlPressed(2, (Control) 73))
              UI.Notify("Check ");
          }
          if (this.TargetsMarked >= 1)
          {
            Vector2 vector2 = this.World3DToScreen2d(this.TargetsMarkedListVec3[0]);
            this.drawSpriteRTA2("helicopterhud", "hudarrow", (float) vector2.X, (float) vector2.Y, 25f, 25f, (int) byte.MaxValue, 0, 0, (int) byte.MaxValue, 0.0f);
          }
          World.DrawMarker((MarkerType) 28, position2, Vector3.Zero, Vector3.Zero, new Vector3(2f, 2f, 2f), Color.Red);
        }
      }
      try
      {
        if (this.Flames.Count > 0)
        {
          foreach (flame flame in this.Flames)
          {
            if (flame.Type == 2)
            {
              if (flame.LifeTime != 5)
                flame.LifeTime++;
              if (flame.LifeTime >= 5)
                Function.Call((Hash) 9220355218917582655L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(flame.X1)
                });
            }
            if (flame.Type == 1)
            {
              if (flame.LifeTime != 5)
                flame.LifeTime++;
              if (flame.LifeTime >= 5)
              {
                if ((bool) Function.Call<bool>((Hash) 8408201869211353243L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(flame.ID)
                }))
                  Function.Call((Hash) -8109406742613235306L, new InputArgument[2]
                  {
                    InputArgument.op_Implicit(flame.ID),
                    InputArgument.op_Implicit(false)
                  });
              }
            }
          }
        }
      }
      catch
      {
      }
      if (this.ReadyForEnterAnim)
      {
        if (this.EnterAnim == 1)
        {
          ((Entity) Game.Player.Character).Position = new Vector3(1557.997f, 404.82f, -49.68f);
          Game.FadeScreenOut(500);
          Script.Wait(3000);
          Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
          int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(1561.541f),
            InputArgument.op_Implicit(419.4447f),
            InputArgument.op_Implicit(-55.30978f)
          });
          if (Entity.op_Inequality((Entity) this.Seasparrow, (Entity) null))
            ((Entity) this.Seasparrow).Delete();
          this.Seasparrow = World.CreateVehicle(this.RequestModel("SEASPARROW3"), new Vector3(1561.547f, 411.2735f, -51.1282f), 178f);
          this.Seasparrow.IsDriveable = false;
          ((Entity) this.Seasparrow).IsInvincible = true;
          ((Entity) this.Seasparrow).FreezePosition = true;
          this.Seasparrow.PrimaryColor = this.SeaSparrowPrimaryColor;
          this.Seasparrow.SecondaryColor = this.SeaSparrowSecondaryColor;
          Function.Call((Hash) 2245783831530643834L, new InputArgument[2]
          {
            InputArgument.op_Implicit(((Entity) this.Seasparrow).Handle),
            InputArgument.op_Implicit(0)
          });
          this.Seasparrow.SetMod((VehicleMod) 10, this.SeasparrowWeapons, true);
          ((Entity) Game.Player.Character).Position = new Vector3(1557.997f, 404.82f, -49.68f);
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_r_02a")))
            this.HatchR02 = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_r_01a")))
            this.HatchR01 = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_l_01a")))
            this.HatchL01 = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_l_02a")))
            this.HatchL02 = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_lift_platfom")))
            this.Lift = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_int_sub_lift_doors_r")))
            this.HangerDR = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_int_sub_lift_doors_l")))
            this.HangerDL = nearbyProp;
          if (Entity.op_Inequality((Entity) this.HatchR02, (Entity) null) && Entity.op_Inequality((Entity) this.HatchR01, (Entity) null) && (Entity.op_Inequality((Entity) this.HatchL01, (Entity) null) && Entity.op_Inequality((Entity) this.HatchL02, (Entity) null)) && (Entity.op_Inequality((Entity) this.Lift, (Entity) null) && Entity.op_Inequality((Entity) this.HangerDR, (Entity) null)) && Entity.op_Inequality((Entity) this.HangerDL, (Entity) null))
          {
            this.IsInInterior = true;
            ((Entity) Game.Player.Character).IsVisible = false;
            this.SeaSparrowOut = false;
            this.Config.SetValue<bool>("Moonpool", "SeaSparrowOut", (M0) (this.SeaSparrowOut ? 1 : 0));
            this.SeaSparrowDestroyedTimer = 0;
            this.Config.SetValue<int>("Moonpool", "SeaSparrowDestroyedTimer", (M0) this.SeaSparrowDestroyedTimer);
            this.Config.Save();
            ((Entity) Game.Player.Character).IsVisible = true;
            Script.Wait(3000);
            Game.FadeScreenIn(500);
            this.EnterAnimations(1);
          }
          this.EnterAnim = 0;
        }
        if (this.EnterAnim == 2)
        {
          ((Entity) Game.Player.Character).Position = new Vector3(1557.997f, 404.82f, -49.68f);
          Script.Wait(1);
          Game.FadeScreenOut(500);
          Script.Wait(3000);
          Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
          int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(1561.541f),
            InputArgument.op_Implicit(419.4447f),
            InputArgument.op_Implicit(-55.30978f)
          });
          ((Entity) Game.Player.Character).Position = new Vector3(1557.997f, 404.82f, -49.68f);
          this.DroneCam = World.CreateCamera(new Vector3(1558.299f, 405.1266f, -54.17f), new Vector3(0.0f, 0.0f, -26f), 80f);
          Function.Call((Hash) 569060033405794044L, new InputArgument[5]
          {
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(3000),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0)
          });
          World.RenderingCamera = this.DroneCam;
          KosatkaScript.LoadDict("anim@scripted@submarine@vehicle_trans@moonpool");
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_r_02a")))
            this.HatchR02 = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_r_01a")))
            this.HatchR01 = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_l_01a")))
            this.HatchL01 = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_l_02a")))
            this.HatchL02 = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_lift_platfom")))
            this.Lift = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_int_sub_lift_doors_r")))
            this.HangerDR = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_int_sub_lift_doors_l")))
            this.HangerDL = nearbyProp;
          if (Entity.op_Inequality((Entity) this.HatchR02, (Entity) null) && Entity.op_Inequality((Entity) this.HatchR01, (Entity) null) && (Entity.op_Inequality((Entity) this.HatchL01, (Entity) null) && Entity.op_Inequality((Entity) this.HatchL02, (Entity) null)) && (Entity.op_Inequality((Entity) this.Lift, (Entity) null) && Entity.op_Inequality((Entity) this.HangerDR, (Entity) null)) && Entity.op_Inequality((Entity) this.HangerDL, (Entity) null))
          {
            this.IsInInterior = true;
            this.AvisaOut = false;
            this.Config.SetValue<bool>("Moonpool", "AvisaOut", (M0) (this.AvisaOut ? 1 : 0));
            this.AvisaDestroyedTimer = 0;
            this.Config.SetValue<int>("Moonpool", "AvisaDestroyedTimer", (M0) this.AvisaDestroyedTimer);
            this.Config.Save();
            Script.Wait(3000);
            Game.FadeScreenIn(500);
            this.EnterAnimations(2);
          }
          this.EnterAnim = 0;
        }
        if (this.EnterAnim == 3)
        {
          ((Entity) Game.Player.Character).Position = new Vector3(1557.997f, 404.82f, -49.68f);
          Game.FadeScreenOut(500);
          Script.Wait(3000);
          Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
          if (this.ToreadorUpgrade == 1)
          {
            if (Entity.op_Inequality((Entity) this.Toreador, (Entity) null))
              ((Entity) this.Toreador).Delete();
            this.Toreador = World.CreateVehicle(this.RequestModel("Toreador"), new Vector3(1561.381f, 416.9739f, -55f), 180f);
            this.Toreador.IsDriveable = false;
            ((Entity) this.Toreador).IsInvincible = true;
            ((Entity) this.Toreador).FreezePosition = false;
            this.Toreador.PrimaryColor = this.ToreadorPrimaryColor;
            this.Toreador.SecondaryColor = this.ToreadorSecondaryColor;
          }
          int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(1561.541f),
            InputArgument.op_Implicit(419.4447f),
            InputArgument.op_Implicit(-55.30978f)
          });
          ((Entity) Game.Player.Character).Position = new Vector3(1557.997f, 419.2f, -49.68f);
          Vector3 position = ((Entity) Game.Player.Character).Position;
          while (true)
          {
            if (Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
            {
              InputArgument.op_Implicit((float) position.X),
              InputArgument.op_Implicit((float) position.Y),
              InputArgument.op_Implicit((float) position.Z)
            }) == 0)
              Script.Wait(10);
            else
              break;
          }
          Function.Call((Hash) 5949884333633149191L, new InputArgument[3]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit(0)
          });
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_r_02a")))
            this.HatchR02 = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_r_01a")))
            this.HatchR01 = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_l_01a")))
            this.HatchL01 = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_pool_hatch_l_02a")))
            this.HatchL02 = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_prop_sub_lift_platfom")))
            this.Lift = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_int_sub_lift_doors_r")))
            this.HangerDR = nearbyProp;
          foreach (Prop nearbyProp in World.GetNearbyProps(new Vector3(1561.547f, 411.2735f, -53.1282f), 30f, this.RequestModel("h4_int_sub_lift_doors_l")))
            this.HangerDL = nearbyProp;
          if (Entity.op_Inequality((Entity) this.HatchR02, (Entity) null) && Entity.op_Inequality((Entity) this.HatchR01, (Entity) null) && (Entity.op_Inequality((Entity) this.HatchL01, (Entity) null) && Entity.op_Inequality((Entity) this.HatchL02, (Entity) null)) && (Entity.op_Inequality((Entity) this.Lift, (Entity) null) && Entity.op_Inequality((Entity) this.HangerDR, (Entity) null)) && Entity.op_Inequality((Entity) this.HangerDL, (Entity) null))
          {
            ((Entity) Game.Player.Character).IsVisible = false;
            ((Entity) Game.Player.Character).IsVisible = true;
            Game.Player.CanControlCharacter = true;
            this.IsInInterior = true;
            this.ToreadorOut = false;
            this.Config.SetValue<bool>("Moonpool", "ToreadorOut", (M0) (this.ToreadorOut ? 1 : 0));
            this.ToreadorDestroyedTimer = 0;
            this.Config.SetValue<int>("Moonpool", "ToreadorDestroyedTimer", (M0) this.ToreadorDestroyedTimer);
            this.Config.Save();
            ((Entity) Game.Player.Character).Position = new Vector3(1557.997f, 404.82f, -49.68f);
            Script.Wait(3000);
            Game.FadeScreenIn(500);
            this.EnterAnimations(3);
          }
          this.EnterAnim = 0;
        }
      }
      if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
      {
        if (Game.IsControlPressed(2, (Control) 73))
        {
          if (Entity.op_Inequality((Entity) this.HatchR02, (Entity) null))
            World.DrawMarker((MarkerType) 28, ((Entity) this.HatchR02).Position, Vector3.Zero, Vector3.Zero, new Vector3(0.2f, 0.2f, 0.2f), this.SubmarineMarkerColor);
          if (Entity.op_Inequality((Entity) this.HatchR01, (Entity) null))
            World.DrawMarker((MarkerType) 28, ((Entity) this.HatchR01).Position, Vector3.Zero, Vector3.Zero, new Vector3(0.2f, 0.2f, 0.2f), this.SubmarineMarkerColor);
          if (Entity.op_Inequality((Entity) this.HatchL01, (Entity) null))
            World.DrawMarker((MarkerType) 28, ((Entity) this.HatchL01).Position, Vector3.Zero, Vector3.Zero, new Vector3(0.2f, 0.2f, 0.2f), this.SubmarineMarkerColor);
          if (Entity.op_Inequality((Entity) this.HatchL02, (Entity) null))
            World.DrawMarker((MarkerType) 28, ((Entity) this.HatchL02).Position, Vector3.Zero, Vector3.Zero, new Vector3(0.2f, 0.2f, 0.2f), this.SubmarineMarkerColor);
          if (Entity.op_Inequality((Entity) this.Lift, (Entity) null))
            World.DrawMarker((MarkerType) 28, ((Entity) this.Lift).Position, Vector3.Zero, Vector3.Zero, new Vector3(0.2f, 0.2f, 0.2f), this.SubmarineMarkerColor);
          if (Entity.op_Inequality((Entity) this.HangerDR, (Entity) null))
            World.DrawMarker((MarkerType) 28, ((Entity) this.HangerDR).Position, Vector3.Zero, Vector3.Zero, new Vector3(0.2f, 0.2f, 0.2f), this.SubmarineMarkerColor);
          if (Entity.op_Inequality((Entity) this.HangerDL, (Entity) null))
            World.DrawMarker((MarkerType) 28, ((Entity) this.HangerDL).Position, Vector3.Zero, Vector3.Zero, new Vector3(0.2f, 0.2f, 0.2f), this.SubmarineMarkerColor);
        }
        if (!Game.IsControlJustPressed(2, (Control) 73))
          ;
        Vector3 offsetInWorldCoords1 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, -10f, -15f));
        Vector3 offsetInWorldCoords2 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, 7f, 6.7f));
        if (Entity.op_Inequality((Entity) this.Avisa, (Entity) null) && ((Entity) this.Avisa).IsAlive)
        {
          if ((double) World.GetDistance(((Entity) this.Avisa).Position, offsetInWorldCoords1) < 80.0)
            World.DrawMarker((MarkerType) 0, offsetInWorldCoords1, Vector3.Zero, Vector3.Zero, new Vector3(2f, 2f, 2f), this.SubmarineMarkerColor);
          if ((double) World.GetDistance(((Entity) this.Avisa).Position, offsetInWorldCoords1) < 5.0)
          {
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Enter Kosatka with Avisa");
            if (Game.IsControlJustPressed(2, (Control) 51))
            {
              this.ReadyForEnterAnim = true;
              this.EnterAnim = 2;
            }
          }
        }
        if (Entity.op_Inequality((Entity) this.Toreador, (Entity) null) && ((Entity) this.Toreador).IsAlive)
        {
          if ((double) World.GetDistance(((Entity) this.Toreador).Position, offsetInWorldCoords1) < 80.0)
            World.DrawMarker((MarkerType) 0, offsetInWorldCoords1, Vector3.Zero, Vector3.Zero, new Vector3(2f, 2f, 2f), this.SubmarineMarkerColor);
          if ((double) World.GetDistance(((Entity) this.Toreador).Position, offsetInWorldCoords1) < 5.0)
          {
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Enter Kosatka with Toreador");
            if (Game.IsControlJustPressed(2, (Control) 51))
            {
              this.ReadyForEnterAnim = true;
              this.EnterAnim = 3;
            }
          }
        }
        if (Entity.op_Inequality((Entity) this.Seasparrow, (Entity) null) && ((Entity) this.Seasparrow).IsAlive)
        {
          if ((double) World.GetDistance(((Entity) this.Seasparrow).Position, offsetInWorldCoords2) < 80.0)
            World.DrawMarker((MarkerType) 1, offsetInWorldCoords2, Vector3.Zero, Vector3.Zero, new Vector3(5f, 5f, 0.4f), this.SubmarineMarkerColor);
          if ((double) World.GetDistance(((Entity) this.Seasparrow).Position, offsetInWorldCoords2) < 5.0)
          {
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Enter Kosatka with Sea Sparrow");
            if (Game.IsControlJustPressed(2, (Control) 51))
            {
              this.ReadyForEnterAnim = true;
              this.EnterAnim = 1;
            }
          }
        }
        ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -10f, 8f));
        ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -8f, 8f));
        ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -6f, 8f));
        ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -4f, 8f));
        ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -10f, 8f));
        ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -8f, 8f));
        ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -6f, 8f));
        ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -4f, 8f));
        if (!Game.Player.Name.ToUpper().Equals("CINNBARGNU2"))
          ;
        if (!Game.Player.Name.ToUpper().Equals("CINNBARGNU"))
          ;
      }
      float num3;
      if (Entity.op_Inequality((Entity) this.Missile, (Entity) null))
      {
        if (this.PilotingMissile)
        {
          Vector3 offsetInWorldCoords = ((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, 8f, 0.0f));
          if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, offsetInWorldCoords) < 80.0)
            World.DrawMarker((MarkerType) 28, offsetInWorldCoords, Vector3.Zero, Vector3.Zero, new Vector3(0.15f, 0.15f, 0.15f), Color.Red);
          if (Entity.op_Inequality((Entity) this.Missile2, (Entity) null))
          {
            ((Entity) this.Missile).IsVisible = false;
            ((Entity) this.Missile2).Rotation = KosatkaScript.DirectionToRotation(Vector3.op_Subtraction(((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, -3f, 0.0f)), ((Entity) this.Missile2).Position), ((Entity) this.Missile2).Heading);
            ((Entity) this.Missile2).Position = ((Entity) this.Missile).Position;
          }
          Prop missile = this.Missile;
          World.DrawMarker((MarkerType) 1, ((Entity) missile).GetOffsetInWorldCoords(new Vector3(0.0f, -3f, 0.0f)), Vector3.Zero, Vector3.Zero, new Vector3(0.2f, 0.2f, 0.2f), this.SubmarineMarkerColor);
          if (!((Entity) missile).HasCollidedWithAnything)
            ;
          if (Camera.op_Inequality(this.DroneCam, (Camera) null))
          {
            ((Entity) missile).LodDistance = 3000;
            Function.Call((Hash) -5184338789570016586L, new InputArgument[1]
            {
              InputArgument.op_Implicit("core")
            });
            Function.Call((Hash) 7798175403732277905L, new InputArgument[1]
            {
              InputArgument.op_Implicit("core")
            });
            Function.Call((Hash) -5184338789570016586L, new InputArgument[1]
            {
              InputArgument.op_Implicit("core")
            });
            Function.Call((Hash) 7798175403732277905L, new InputArgument[1]
            {
              InputArgument.op_Implicit("core")
            });
            int num1 = (int) Function.Call<int>((Hash) 1937722214304277783L, new InputArgument[12]
            {
              InputArgument.op_Implicit("ent_sht_flame"),
              InputArgument.op_Implicit(missile),
              InputArgument.op_Implicit(0.0f),
              InputArgument.op_Implicit(0.0f),
              InputArgument.op_Implicit(0.0f),
              InputArgument.op_Implicit(90f),
              InputArgument.op_Implicit(0.0f),
              InputArgument.op_Implicit(0.0f),
              InputArgument.op_Implicit(6f),
              InputArgument.op_Implicit(false),
              InputArgument.op_Implicit(false),
              InputArgument.op_Implicit(false)
            });
            this.SetRange(num1, 3000000f);
            this.PTFX__ids.Add(num1);
            this.Flames.Add(new flame(1, num1, 0));
            Vector3 dir = Vector3.op_Subtraction(((Entity) this.TargetPed).Position, ((Entity) missile).Position);
            ((Entity) missile).Rotation = KosatkaScript.DirectionToRotation(dir, ((Entity) missile).Heading);
            ((Entity) missile).CurrentBlip.Rotation = (int) ((Entity) missile).Heading;
            this.DroneCam.Position = this.DroneCam.Position = ((Entity) missile).GetOffsetInWorldCoords(new Vector3(0.0f, 1.5f, 0.0f));
            this.DroneCam.PointAt(((Entity) missile).GetOffsetInWorldCoords(new Vector3(0.0f, 1.5f, 0.0f)));
            if ((double) World.GetDistance(((Entity) missile).Position, ((Entity) this.TargetPed).Position) < 5.0)
            {
              ((Entity) this.Missile2).Delete();
              this.ReachedZCoord = false;
              ((Entity) this.Missile).Delete();
              Function.Call((Hash) 569060033405794044L, new InputArgument[5]
              {
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(3000),
                InputArgument.op_Implicit(1),
                InputArgument.op_Implicit(0)
              });
              if (Camera.op_Inequality(this.DroneCam, (Camera) null))
                this.DroneCam.Destroy();
              if (Entity.op_Inequality((Entity) this.Missile, (Entity) null))
                ((Entity) this.Missile).Delete();
              if (Entity.op_Inequality((Entity) this.Missile2, (Entity) null))
                ((Entity) this.Missile2).Delete();
              if (Entity.op_Inequality((Entity) this.GuidedMissileTarget, (Entity) null))
                ((Entity) this.GuidedMissileTarget).Delete();
              this.PilotingMissile = false;
              World.AddExplosion(((Entity) this.TargetPed).Position, (ExplosionType) 0, 100f, 3f);
            }
          }
          ((Entity) missile).Position = ((Entity) missile).GetOffsetInWorldCoords(new Vector3(0.0f, this.MissileSpeed, 0.0f));
          ((Entity) missile).Position = ((Entity) missile).GetOffsetInWorldCoords(new Vector3(0.0f, 0.1f, 0.0f));
          this.MissileSpeed += 1f / 1000f;
        }
        Vector3 position1;
        if (this.PilotingMissile2)
        {
          if (Entity.op_Inequality((Entity) this.TargetVehicle, (Entity) null))
          {
            ((Entity) this.TargetVehicle).IsPersistent = true;
            if (Entity.op_Inequality((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
              ((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) -1)).IsPersistent = true;
            if (Entity.op_Inequality((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 0), (Entity) null))
              ((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 0)).IsPersistent = true;
            if (Entity.op_Inequality((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 1), (Entity) null))
              ((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 1)).IsPersistent = true;
            if (Entity.op_Inequality((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 2), (Entity) null))
              ((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 2)).IsPersistent = true;
            if (Entity.op_Inequality((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 3), (Entity) null))
              ((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 3)).IsPersistent = true;
          }
          while (true)
          {
            if (Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
            {
              InputArgument.op_Implicit("helicopterhud")
            }) == 0)
            {
              Script.Wait(10);
              Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
              {
                InputArgument.op_Implicit("helicopterhud"),
                InputArgument.op_Implicit(0)
              });
            }
            else
              break;
          }
          float num1 = (float) Function.Call<float>((Hash) -1424092350868114077L, new InputArgument[2]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(240)
          });
          float num2 = (float) Function.Call<float>((Hash) -1424092350868114077L, new InputArgument[2]
          {
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(239)
          });
          this.drawSpriteRTA2("helicopterhud", "hud_horiz", 0.5f, 0.95f, 900f, 100f, 0, 186, 50, (int) byte.MaxValue, 0.0f);
          this.drawSpriteRTA2("helicopterhud", "hud_vert", 0.0f, 0.5f, 100f, 1000f, 0, 186, 50, (int) byte.MaxValue, 0.0f);
          Vector2 vector2 = this.World3DToScreen2d(((Entity) this.TargetVehicle).Position);
          if ((double) vector2.X >= 0.2 && (double) vector2.X <= 0.8 && ((double) vector2.Y >= 0.2 && (double) vector2.Y <= 0.8))
            this.drawSpriteRTA2("helicopterhud", "hudarrow", (float) vector2.X, (float) vector2.Y, 30f, 50f, (int) byte.MaxValue, (int) byte.MaxValue, 0, 0, 0.0f);
          Vector3 offsetInWorldCoords = ((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, 8f, 0.0f));
          if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, offsetInWorldCoords) < 80.0)
            World.DrawMarker((MarkerType) 28, offsetInWorldCoords, Vector3.Zero, Vector3.Zero, new Vector3(0.15f, 0.15f, 0.15f), Color.Red);
          if (Entity.op_Inequality((Entity) this.Missile2, (Entity) null))
          {
            ((Entity) this.Missile).IsVisible = false;
            ((Entity) this.Missile2).Rotation = KosatkaScript.DirectionToRotation(Vector3.op_Subtraction(((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, -3f, 0.0f)), ((Entity) this.Missile2).Position), ((Entity) this.Missile2).Heading);
            ((Entity) this.Missile2).Position = ((Entity) this.Missile).Position;
          }
          Prop missile = this.Missile;
          World.DrawMarker((MarkerType) 1, ((Entity) missile).GetOffsetInWorldCoords(new Vector3(0.0f, -3f, 0.0f)), Vector3.Zero, Vector3.Zero, new Vector3(0.2f, 0.2f, 0.2f), this.SubmarineMarkerColor);
          if (!((Entity) missile).HasCollidedWithAnything)
            ;
          if (Camera.op_Inequality(this.DroneCam, (Camera) null))
          {
            ((Entity) missile).LodDistance = 3000;
            Function.Call((Hash) -5184338789570016586L, new InputArgument[1]
            {
              InputArgument.op_Implicit("core")
            });
            Function.Call((Hash) 7798175403732277905L, new InputArgument[1]
            {
              InputArgument.op_Implicit("core")
            });
            Function.Call((Hash) -5184338789570016586L, new InputArgument[1]
            {
              InputArgument.op_Implicit("core")
            });
            Function.Call((Hash) 7798175403732277905L, new InputArgument[1]
            {
              InputArgument.op_Implicit("core")
            });
            int num4 = (int) Function.Call<int>((Hash) 1937722214304277783L, new InputArgument[12]
            {
              InputArgument.op_Implicit("ent_sht_flame"),
              InputArgument.op_Implicit(missile),
              InputArgument.op_Implicit(0.0f),
              InputArgument.op_Implicit(0.0f),
              InputArgument.op_Implicit(0.0f),
              InputArgument.op_Implicit(90f),
              InputArgument.op_Implicit(0.0f),
              InputArgument.op_Implicit(0.0f),
              InputArgument.op_Implicit(6f),
              InputArgument.op_Implicit(false),
              InputArgument.op_Implicit(false),
              InputArgument.op_Implicit(false)
            });
            this.SetRange(num4, 3000000f);
            this.PTFX__ids.Add(num4);
            this.Flames.Add(new flame(1, num4, 0));
            if (!this.ReachedZCoord)
            {
              ((Entity) missile).CurrentBlip.Rotation = (int) ((Entity) missile).Heading;
              if (!((Entity) this.TargetVehicle).IsInAir)
              {
                if ((uint) this.MissileTimer > 0U)
                  --this.MissileTimer;
                if (this.MissileTimer <= 0)
                {
                  this.TargetPos = ((Entity) this.TargetVehicle).Position;
                  this.TargetPos = new Vector3((float) this.TargetPos.X, (float) this.TargetPos.Y, (float) (this.TargetPos.Z + 30.0));
                  this.MissileTimer = 50;
                }
              }
              if (((Entity) this.TargetVehicle).IsInAir)
                this.ReachedZCoord = true;
              this.DroneCam.Position = this.DroneCam.Position = ((Entity) missile).GetOffsetInWorldCoords(new Vector3(0.0f, 10f, 0.0f));
              this.DroneCam.PointAt(((Entity) missile).GetOffsetInWorldCoords(new Vector3(0.0f, 15f, 0.0f)));
              Vector3 dir = Vector3.op_Subtraction(this.TargetPos, ((Entity) missile).Position);
              ((Entity) missile).Rotation = KosatkaScript.DirectionToRotation(dir, ((Entity) missile).Heading);
              if ((double) World.GetDistance(((Entity) missile).Position, this.TargetPos) < 100.0)
                this.ReachedZCoord = true;
            }
            if (this.ReachedZCoord)
            {
              ((Entity) missile).CurrentBlip.Rotation = (int) ((Entity) missile).Heading;
              this.DroneCam.Position = this.DroneCam.Position = ((Entity) missile).GetOffsetInWorldCoords(new Vector3(0.0f, 10f, 0.0f));
              this.DroneCam.PointAt(((Entity) missile).GetOffsetInWorldCoords(new Vector3(0.0f, 15f, 0.0f)));
              Vector3 dir = Vector3.op_Subtraction(((Entity) this.TargetVehicle).Position, ((Entity) missile).Position);
              ((Entity) missile).Rotation = KosatkaScript.DirectionToRotation(dir, ((Entity) missile).Heading);
            }
            if ((double) World.GetDistance(((Entity) missile).Position, ((Entity) this.TargetVehicle).Position) < 5.0)
            {
              this.ReachedZCoord = false;
              if (Entity.op_Inequality((Entity) this.TargetVehicle, (Entity) null))
              {
                ((Entity) this.TargetVehicle).IsPersistent = false;
                if (Entity.op_Inequality((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) -1), (Entity) null))
                  ((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) -1)).IsPersistent = false;
                if (Entity.op_Inequality((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 0), (Entity) null))
                  ((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 0)).IsPersistent = false;
                if (Entity.op_Inequality((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 1), (Entity) null))
                  ((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 1)).IsPersistent = false;
                if (Entity.op_Inequality((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 2), (Entity) null))
                  ((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 2)).IsPersistent = false;
                if (Entity.op_Inequality((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 3), (Entity) null))
                  ((Entity) this.TargetVehicle.GetPedOnSeat((VehicleSeat) 3)).IsPersistent = false;
              }
              this.PilotingMissile2 = false;
              World.AddExplosion(((Entity) this.TargetVehicle).Position, (ExplosionType) 0, 100f, 3f);
              Vector3 position2 = ((Entity) this.TargetVehicle).Position;
              World.AddExplosion(((Vector3) ref position2).Around(2f), (ExplosionType) 0, 100f, 3f);
              position1 = ((Entity) this.TargetVehicle).Position;
              World.AddExplosion(((Vector3) ref position1).Around(2f), (ExplosionType) 29, 100f, 3f);
              position1 = ((Entity) this.TargetVehicle).Position;
              World.AddExplosion(((Vector3) ref position1).Around(2f), (ExplosionType) 14, 100f, 3f);
              position1 = ((Entity) this.TargetVehicle).Position;
              World.AddExplosion(((Vector3) ref position1).Around(2f), (ExplosionType) 29, 100f, 3f);
              position1 = ((Entity) this.TargetVehicle).Position;
              World.AddExplosion(((Vector3) ref position1).Around(2f), (ExplosionType) 14, 100f, 3f);
              position1 = ((Entity) this.TargetVehicle).Position;
              World.AddExplosion(((Vector3) ref position1).Around(2f), (ExplosionType) 14, 100f, 3f);
              position1 = ((Entity) this.TargetVehicle).Position;
              World.AddExplosion(((Vector3) ref position1).Around(2f), (ExplosionType) 14, 100f, 3f);
              position1 = ((Entity) this.TargetVehicle).Position;
              World.AddExplosion(((Vector3) ref position1).Around(2f), (ExplosionType) 14, 100f, 3f);
              Script.Wait(1500);
              if (Entity.op_Inequality((Entity) this.Missile, (Entity) null))
                ((Entity) this.Missile).Delete();
              if (Entity.op_Inequality((Entity) this.Missile2, (Entity) null))
                ((Entity) this.Missile2).Delete();
              if (Entity.op_Inequality((Entity) this.GuidedMissileTarget, (Entity) null))
                ((Entity) this.GuidedMissileTarget).Delete();
              Function.Call((Hash) 569060033405794044L, new InputArgument[5]
              {
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(3000),
                InputArgument.op_Implicit(1),
                InputArgument.op_Implicit(0)
              });
              if (Camera.op_Inequality(this.DroneCam, (Camera) null))
                this.DroneCam.Destroy();
              this.PilotingMissile2 = false;
            }
          }
          ((Entity) missile).Position = ((Entity) missile).GetOffsetInWorldCoords(new Vector3(0.0f, this.MissileSpeed, 0.0f));
          ((Entity) missile).Position = ((Entity) missile).GetOffsetInWorldCoords(new Vector3(0.0f, 0.1f, 0.0f));
          this.MissileSpeed += 0.01f;
        }
        if (this.PilotingGuidedMissil3)
        {
          KosatkaScript.DrawScaleformTurret();
          num3 = (float) this.BatteryPercent / 4000f * 100f;
          this.DisplayHelpTextThisFrameNoSound("Missile Control : ~INPUT_LOOK_LR~ ~INPUT_LOOK_UD~, Battery Level " + num3.ToString() + "%");
          if ((double) this.BatteryPercent < (double) World.GetDistance(((Entity) this.Missile).Position, ((Entity) this.Kosatka).Position))
            this.BatteryPercent = (int) World.GetDistance(((Entity) this.Missile).Position, ((Entity) this.Kosatka).Position);
          ((Entity) this.Missile).SetNoCollision((Entity) this.Missile2, true);
          ((Entity) this.Missile2).SetNoCollision((Entity) this.Missile, true);
          Vector3 offsetInWorldCoords = ((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, 8f, 0.0f));
          if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, offsetInWorldCoords) < 80.0)
            World.DrawMarker((MarkerType) 28, offsetInWorldCoords, Vector3.Zero, Vector3.Zero, new Vector3(0.15f, 0.15f, 0.15f), Color.Red);
          Prop missile = this.Missile;
          World.DrawMarker((MarkerType) 1, ((Entity) missile).GetOffsetInWorldCoords(new Vector3(0.0f, -3f, 0.0f)), Vector3.Zero, Vector3.Zero, new Vector3(0.2f, 0.2f, 0.2f), this.SubmarineMarkerColor);
          if (Camera.op_Inequality(this.DroneCam, (Camera) null))
          {
            ((Entity) missile).LodDistance = 3000;
            Function.Call((Hash) -5184338789570016586L, new InputArgument[1]
            {
              InputArgument.op_Implicit("core")
            });
            Function.Call((Hash) 7798175403732277905L, new InputArgument[1]
            {
              InputArgument.op_Implicit("core")
            });
            Function.Call((Hash) -5184338789570016586L, new InputArgument[1]
            {
              InputArgument.op_Implicit("core")
            });
            Function.Call((Hash) 7798175403732277905L, new InputArgument[1]
            {
              InputArgument.op_Implicit("core")
            });
            int num1 = (int) Function.Call<int>((Hash) 1937722214304277783L, new InputArgument[12]
            {
              InputArgument.op_Implicit("ent_sht_flame"),
              InputArgument.op_Implicit(missile),
              InputArgument.op_Implicit(0.0f),
              InputArgument.op_Implicit(0.0f),
              InputArgument.op_Implicit(0.0f),
              InputArgument.op_Implicit(90f),
              InputArgument.op_Implicit(0.0f),
              InputArgument.op_Implicit(0.0f),
              InputArgument.op_Implicit(6f),
              InputArgument.op_Implicit(false),
              InputArgument.op_Implicit(false),
              InputArgument.op_Implicit(false)
            });
            this.SetRange(num1, 3000000f);
            this.PTFX__ids.Add(num1);
            this.Flames.Add(new flame(1, num1, 0));
            if (Game.IsControlPressed(2, (Control) 32))
            {
              if ((double) this.MissileSpeed < 15.0)
                this.MissileSpeed += 0.02f;
            }
            else if (Game.IsControlPressed(2, (Control) 33) && (double) this.MissileSpeed > 0.600000023841858)
              this.MissileSpeed -= 0.01f;
            if (!Game.IsControlPressed(2, (Control) 32) && !Game.IsControlPressed(2, (Control) 33))
            {
              if ((double) this.MissileSpeed > 3.0)
                this.MissileSpeed -= 0.03f;
              if ((double) this.MissileSpeed < 3.0)
                this.MissileSpeed += 0.01f;
            }
            num3 = this.MissileSpeed * 50f;
            UI.ShowSubtitle("~b~" + num3.ToString() + " m/s");
            ((Entity) missile).Position = ((Entity) missile).GetOffsetInWorldCoords(new Vector3(0.0f, this.MissileSpeed, 0.0f));
            ((Entity) missile).Position = ((Entity) missile).GetOffsetInWorldCoords(new Vector3(0.0f, 0.1f, 0.0f));
            this.TargetPos = ((Entity) this.GuidedMissileTarget).Position;
            ((Entity) this.GuidedMissileTarget).IsVisible = false;
            ((Entity) this.Missile).IsVisible = false;
            Vector3 dir = Vector3.op_Subtraction(this.TargetPos, ((Entity) missile).Position);
            ((Entity) missile).Rotation = KosatkaScript.DirectionToRotation(dir, ((Entity) missile).Heading);
            ((Entity) missile).CurrentBlip.Rotation = (int) ((Entity) missile).Heading;
            ((Entity) Game.Player.Character).IsVisible = false;
            ((Entity) Game.Player.Character).Position = ((Entity) this.Missile).Position;
            ((Entity) Game.Player.Character).Heading = ((Entity) missile).Heading;
            if (Game.CurrentInputMode == 1)
            {
              if (Game.IsControlPressed(2, (Control) 271))
                this.DroneCam.Rotation = new Vector3((float) this.DroneCam.Rotation.X, 0.0f, (float) (this.DroneCam.Rotation.Z - 0.75));
              if (Game.IsControlPressed(2, (Control) 5))
                this.DroneCam.Rotation = new Vector3((float) this.DroneCam.Rotation.X, 0.0f, (float) (this.DroneCam.Rotation.Z + 0.75));
              if (Game.IsControlPressed(2, (Control) 3) && this.DroneCam.Rotation.X < 65.0)
                this.DroneCam.Rotation = new Vector3((float) (this.DroneCam.Rotation.X + 0.5), 0.0f, (float) this.DroneCam.Rotation.Z);
              if (Game.IsControlPressed(2, (Control) 4) && this.DroneCam.Rotation.X > -11.0)
                this.DroneCam.Rotation = new Vector3((float) (this.DroneCam.Rotation.X - 0.5), 0.0f, (float) this.DroneCam.Rotation.Z);
              if (Game.IsControlPressed(2, (Control) 271))
                this.DroneCam.Rotation = new Vector3((float) this.DroneCam.Rotation.X, 0.0f, (float) (this.DroneCam.Rotation.Z - 0.75));
              if (Game.IsControlPressed(2, (Control) 5))
                this.DroneCam.Rotation = new Vector3((float) this.DroneCam.Rotation.X, 0.0f, (float) (this.DroneCam.Rotation.Z + 0.75));
              if (Game.IsControlPressed(2, (Control) 3) && this.DroneCam.Rotation.X < 65.0)
                this.DroneCam.Rotation = new Vector3((float) (this.DroneCam.Rotation.X + 0.5), 0.0f, (float) this.DroneCam.Rotation.Z);
            }
            if (Game.CurrentInputMode == 0)
            {
              float num2 = 0.0f;
              float num4 = 0.0f;
              float num5 = (float) Function.Call<float>((Hash) -1424092350868114077L, new InputArgument[2]
              {
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(240)
              });
              float num6 = (float) Function.Call<float>((Hash) -1424092350868114077L, new InputArgument[2]
              {
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(239)
              });
              if ((double) num6 > 0.35 && (double) num6 < 0.65)
              {
                this.LeftRightMoveAmt = 0.0f;
              }
              else
              {
                if ((double) num6 >= 0.660000026226044 && ((double) this.LeftRightMoveAmt >= -1.0 && (double) this.LeftRightMoveAmt < 1.0))
                {
                  this.LeftRightMoveAmt -= 0.02f;
                  num2 = -0.5f;
                }
                if ((double) num6 <= 0.349999994039536 && ((double) this.LeftRightMoveAmt >= -1.0 && (double) this.LeftRightMoveAmt < 1.0))
                {
                  this.LeftRightMoveAmt += 0.02f;
                  num2 = 0.5f;
                }
              }
              if ((double) num5 > 0.35 && (double) num5 < 0.65)
              {
                this.UpDownMoveAmt = 0.0f;
              }
              else
              {
                if ((double) num5 >= 0.649999976158142 && ((double) this.UpDownMoveAmt >= -1.0 && (double) this.UpDownMoveAmt < 1.0))
                {
                  this.UpDownMoveAmt -= 0.02f;
                  num4 = -0.5f;
                }
                if ((double) num5 <= 0.349999994039536 && ((double) this.UpDownMoveAmt >= -1.0 && (double) this.UpDownMoveAmt < 1.0))
                {
                  this.UpDownMoveAmt += 0.02f;
                  num4 = 0.5f;
                }
              }
              Camera droneCam = this.DroneCam;
              droneCam.Rotation = Vector3.op_Addition(droneCam.Rotation, new Vector3(this.UpDownMoveAmt, 0.0f, this.LeftRightMoveAmt));
            }
            ((Entity) this.Missile).Rotation = this.DroneCam.Rotation;
            this.DroneCam.Position = ((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, 10f, 0.0f));
            if (((Entity) this.Missile).HasCollidedWithAnything)
            {
              this.DroneCam.Position = ((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, -30f, 0.0f));
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              Script.Wait(1000);
              ((Entity) this.Missile2).Delete();
              this.ReachedZCoord = false;
              ((Entity) this.Missile).Delete();
              Function.Call((Hash) 569060033405794044L, new InputArgument[5]
              {
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(3000),
                InputArgument.op_Implicit(1),
                InputArgument.op_Implicit(0)
              });
              if (Camera.op_Inequality(this.DroneCam, (Camera) null))
                this.DroneCam.Destroy();
              if (Entity.op_Inequality((Entity) this.Missile, (Entity) null))
                ((Entity) this.Missile).Delete();
              if (Entity.op_Inequality((Entity) this.Missile2, (Entity) null))
                ((Entity) this.Missile2).Delete();
              if (Entity.op_Inequality((Entity) this.GuidedMissileTarget, (Entity) null))
                ((Entity) this.GuidedMissileTarget).Delete();
              if (this.MissileStationUsing == 1)
              {
                this.IsInInterior = true;
                this.IsUsingSam = false;
                ((Entity) Game.Player.Character).Position = ((Entity) this.Chair1).Position;
                this.MissileStationUsing = 0;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair1 = this.Chair1;
                this.ExitChair = this.Chair1;
                this.Chair1_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair1_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair1),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("computer_exit_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.Console1),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("computer_exit_console"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
              }
              if (this.MissileStationUsing == 2)
              {
                this.IsInInterior = true;
                this.IsUsingSam = false;
                ((Entity) Game.Player.Character).Position = ((Entity) this.Chair2).Position;
                this.MissileStationUsing = 0;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair2 = this.Chair2;
                this.ExitChair = this.Chair2;
                this.Chair2_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair2_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair2),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("computer_exit_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.Console2),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("computer_exit_console"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
              }
              ((Entity) Game.Player.Character).IsVisible = true;
              this.PilotingGuidedMissil3 = false;
            }
            Vector3 vector3_1;
            // ISSUE: explicit constructor call
            ((Vector3) ref vector3_1).\u002Ector((float) ((Entity) this.Missile).Position.X, (float) ((Entity) this.Missile).Position.Y, World.GetGroundHeight(((Entity) this.Missile).Position));
            if ((double) World.GetDistance(((Entity) this.Missile).Position, vector3_1) < 3.25)
            {
              this.DroneCam.Position = ((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, -30f, 0.0f));
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              Script.Wait(2000);
              ((Entity) this.Missile2).Delete();
              this.ReachedZCoord = false;
              ((Entity) this.Missile).Delete();
              Function.Call((Hash) 569060033405794044L, new InputArgument[5]
              {
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(3000),
                InputArgument.op_Implicit(1),
                InputArgument.op_Implicit(0)
              });
              if (Camera.op_Inequality(this.DroneCam, (Camera) null))
                this.DroneCam.Destroy();
              if (Entity.op_Inequality((Entity) this.Missile, (Entity) null))
                ((Entity) this.Missile).Delete();
              if (Entity.op_Inequality((Entity) this.Missile2, (Entity) null))
                ((Entity) this.Missile2).Delete();
              if (Entity.op_Inequality((Entity) this.GuidedMissileTarget, (Entity) null))
                ((Entity) this.GuidedMissileTarget).Delete();
              if (this.MissileStationUsing == 1)
              {
                this.IsInInterior = true;
                this.IsUsingSam = false;
                ((Entity) Game.Player.Character).Position = ((Entity) this.Chair1).Position;
                this.MissileStationUsing = 0;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair1 = this.Chair1;
                this.ExitChair = this.Chair1;
                this.Chair1_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair1_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair1),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("computer_exit_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.Console1),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("computer_exit_console"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
              }
              if (this.MissileStationUsing == 2)
              {
                this.IsInInterior = true;
                this.IsUsingSam = false;
                ((Entity) Game.Player.Character).Position = ((Entity) this.Chair2).Position;
                this.MissileStationUsing = 0;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair2 = this.Chair2;
                this.ExitChair = this.Chair2;
                this.Chair2_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair2_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair2),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("computer_exit_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.Console2),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("computer_exit_console"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
              }
              ((Entity) Game.Player.Character).IsVisible = true;
              this.PilotingGuidedMissil3 = false;
            }
            Vector3 position2 = this.DroneCam.Position;
            Vector3 position3 = ((Entity) Game.Player.Character).Position;
            Vector3 position4 = this.DroneCam.Position;
            Vector3 rotation = this.DroneCam.Rotation;
            float num7 = (float) (rotation.Z * (System.Math.PI / 180.0));
            float num8 = (float) (rotation.X * (System.Math.PI / 180.0));
            float num9 = (float) System.Math.Abs(System.Math.Cos((double) num8));
            Vector3 vector3_2;
            // ISSUE: explicit constructor call
            ((Vector3) ref vector3_2).\u002Ector((float) (System.Math.Sin((double) num7) * (double) num9 * -1.0), (float) System.Math.Cos((double) num7) * num9, (float) System.Math.Sin((double) num8));
            RaycastResult raycastResult = World.Raycast(position4, Vector3.op_Addition(position4, Vector3.op_Multiply(vector3_2, 100000f)), (IntersectOptions) -1);
            Vector3 hitCoords = ((RaycastResult) ref raycastResult).HitCoords;
            float num10 = (float) (hitCoords.Z - 25.0);
            Vector3 vector3_3;
            // ISSUE: explicit constructor call
            ((Vector3) ref vector3_3).\u002Ector((float) hitCoords.X, (float) hitCoords.Y, num10);
            if ((double) World.GetDistance(((Entity) this.Missile).Position, hitCoords) < 30.0)
            {
              this.DroneCam.Position = ((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, -30f, 0.0f));
              World.AddExplosion(((Vector3) ref hitCoords).Around(5f), (ExplosionType) 34, 100f, 3f);
              World.AddExplosion(((Vector3) ref hitCoords).Around(5f), (ExplosionType) 34, 100f, 3f);
              World.AddExplosion(((Vector3) ref hitCoords).Around(5f), (ExplosionType) 34, 100f, 3f);
              World.AddExplosion(((Vector3) ref hitCoords).Around(5f), (ExplosionType) 34, 100f, 3f);
              World.AddExplosion(((Vector3) ref hitCoords).Around(5f), (ExplosionType) 34, 100f, 3f);
              World.AddExplosion(((Vector3) ref hitCoords).Around(5f), (ExplosionType) 34, 100f, 3f);
              World.AddExplosion(((Vector3) ref hitCoords).Around(5f), (ExplosionType) 34, 100f, 3f);
              World.AddExplosion(((Vector3) ref hitCoords).Around(5f), (ExplosionType) 34, 100f, 3f);
              Script.Wait(2000);
              ((Entity) this.Missile2).Delete();
              this.ReachedZCoord = false;
              ((Entity) this.Missile).Delete();
              Function.Call((Hash) 569060033405794044L, new InputArgument[5]
              {
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(3000),
                InputArgument.op_Implicit(1),
                InputArgument.op_Implicit(0)
              });
              if (Camera.op_Inequality(this.DroneCam, (Camera) null))
                this.DroneCam.Destroy();
              if (Entity.op_Inequality((Entity) this.Missile, (Entity) null))
                ((Entity) this.Missile).Delete();
              if (Entity.op_Inequality((Entity) this.Missile2, (Entity) null))
                ((Entity) this.Missile2).Delete();
              if (Entity.op_Inequality((Entity) this.GuidedMissileTarget, (Entity) null))
                ((Entity) this.GuidedMissileTarget).Delete();
              if (this.MissileStationUsing == 1)
              {
                this.IsInInterior = true;
                this.IsUsingSam = false;
                ((Entity) Game.Player.Character).Position = ((Entity) this.Chair1).Position;
                this.MissileStationUsing = 0;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair1 = this.Chair1;
                this.ExitChair = this.Chair1;
                this.Chair1_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair1_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair1),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("computer_exit_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.Console1),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("computer_exit_console"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
              }
              if (this.MissileStationUsing == 2)
              {
                this.IsInInterior = true;
                this.IsUsingSam = false;
                ((Entity) Game.Player.Character).Position = ((Entity) this.Chair2).Position;
                this.MissileStationUsing = 0;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair2 = this.Chair2;
                this.ExitChair = this.Chair2;
                this.Chair2_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair2_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair2),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("computer_exit_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.Console2),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("computer_exit_console"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
              }
              ((Entity) Game.Player.Character).IsVisible = true;
              this.PilotingGuidedMissil3 = false;
            }
            if ((double) ((float) this.BatteryPercent / 4000f) * 100.0 >= 100.0)
            {
              this.BatteryPercent = 0;
              this.DroneCam.Position = ((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, -30f, 0.0f));
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              position1 = ((Entity) this.Missile).Position;
              World.AddExplosion(((Vector3) ref position1).Around(5f), (ExplosionType) 34, 100f, 3f);
              Script.Wait(2000);
              ((Entity) this.Missile2).Delete();
              this.ReachedZCoord = false;
              ((Entity) this.Missile).Delete();
              Function.Call((Hash) 569060033405794044L, new InputArgument[5]
              {
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(3000),
                InputArgument.op_Implicit(1),
                InputArgument.op_Implicit(0)
              });
              if (Camera.op_Inequality(this.DroneCam, (Camera) null))
                this.DroneCam.Destroy();
              if (Entity.op_Inequality((Entity) this.Missile, (Entity) null))
                ((Entity) this.Missile).Delete();
              if (Entity.op_Inequality((Entity) this.Missile2, (Entity) null))
                ((Entity) this.Missile2).Delete();
              if (Entity.op_Inequality((Entity) this.GuidedMissileTarget, (Entity) null))
                ((Entity) this.GuidedMissileTarget).Delete();
              if (this.MissileStationUsing == 1)
              {
                this.IsInInterior = true;
                this.IsUsingSam = false;
                ((Entity) Game.Player.Character).Position = ((Entity) this.Chair1).Position;
                this.MissileStationUsing = 0;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair1 = this.Chair1;
                this.ExitChair = this.Chair1;
                this.Chair1_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair1_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair1),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("computer_exit_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.Console1),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("computer_exit_console"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
              }
              if (this.MissileStationUsing == 2)
              {
                this.IsInInterior = true;
                this.IsUsingSam = false;
                ((Entity) Game.Player.Character).Position = ((Entity) this.Chair2).Position;
                this.MissileStationUsing = 0;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair2 = this.Chair2;
                this.ExitChair = this.Chair2;
                this.Chair2_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair2_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("computer_exit"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair2),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("computer_exit_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.Console2),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("computer_exit_console"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
              }
              ((Entity) Game.Player.Character).IsVisible = true;
              this.PilotingGuidedMissil3 = false;
            }
          }
        }
      }
      Vector3 position5 = ((Entity) Game.Player.Character).Position;
      if (this.SubPurchased == 1)
      {
        if (Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit((float) position5.X),
          InputArgument.op_Implicit((float) position5.Y),
          InputArgument.op_Implicit((float) position5.Z)
        }) > 0)
        {
          if (Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(1560f),
            InputArgument.op_Implicit(400f),
            InputArgument.op_Implicit(-50f)
          }) == Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit((float) position5.X),
            InputArgument.op_Implicit((float) position5.Y),
            InputArgument.op_Implicit((float) position5.Z)
          }))
          {
            this.LoadIniFile("scripts//CayoPericoInSp//Submarine.ini");
            this.IsInInterior = true;
            if (Entity.op_Equality((Entity) this.Kosatka, (Entity) null))
            {
              this.LoadIniFile("scripts//CayoPericoInSp//Submarine.ini");
              this.SpawnMOC();
            }
          }
        }
      }
      if (this.UsingPeriscope)
        ;
      if (this.UsingPeriscope)
        Function.Call((Hash) -100848937243707716L, new InputArgument[3]
        {
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(27),
          InputArgument.op_Implicit(true)
        });
      if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
      {
        if (((Entity) this.Kosatka).Position.Z > -11.0 && this.UnderWater)
        {
          this.UnderWater = false;
          Function.Call((Hash) 6410651044935755444L, Array.Empty<InputArgument>());
          Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
          Function.Call((Hash) 4362080213785518366L, Array.Empty<InputArgument>());
          Function.Call((Hash) 3211975551654944577L, new InputArgument[1]
          {
            InputArgument.op_Implicit("default")
          });
          if (Function.Call<int>((Hash) -147535234440955034L, Array.Empty<InputArgument>()) != -1)
            Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
        }
        if (((Entity) this.Kosatka).Position.Z < -11.0 && Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) this.Kosatka) && !this.UnderWater)
        {
          this.UnderWater = true;
          Function.Call((Hash) 6410651044935755444L, Array.Empty<InputArgument>());
          Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
          Function.Call((Hash) 4362080213785518366L, Array.Empty<InputArgument>());
          Function.Call((Hash) 3211975551654944577L, new InputArgument[1]
          {
            InputArgument.op_Implicit("default")
          });
          if (Function.Call<int>((Hash) -147535234440955034L, Array.Empty<InputArgument>()) != -1)
            Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
          Function.Call((Hash) 6410651044935755444L, Array.Empty<InputArgument>());
          Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
          Function.Call((Hash) 4362080213785518366L, Array.Empty<InputArgument>());
          Function.Call((Hash) 3211975551654944577L, new InputArgument[1]
          {
            InputArgument.op_Implicit("NEW_ornate_bank_entrance")
          });
          Function.Call((Hash) -9013954871696349517L, new InputArgument[1]
          {
            InputArgument.op_Implicit(1f)
          });
          Function.Call((Hash) 4309758426879203100L, new InputArgument[2]
          {
            InputArgument.op_Implicit("NEW_ornate_bank_entrance"),
            InputArgument.op_Implicit(1f)
          });
        }
        Vector3 offsetInWorldCoords1 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.8f, 25.5f, 13.5f));
        if (((Entity) this.Kosatka).Position.Z < -14.0)
        {
          if (!Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) this.Kosatka) || !Camera.op_Equality(World.RenderingCamera, (Camera) null))
            ;
          if (this.UsingPeriscope)
          {
            Function.Call((Hash) 569060033405794044L, new InputArgument[5]
            {
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(3000),
              InputArgument.op_Implicit(1),
              InputArgument.op_Implicit(0)
            });
            ((Entity) Game.Player.Character).IsInvincible = false;
            ((Entity) Game.Player.Character).IsVisible = true;
            this.DroneCam.Destroy();
            this.UsingPeriscope = false;
          }
        }
        if (((Entity) this.Kosatka).Position.Z > -14.0 && this.UsingPeriscope)
        {
          if (this.PeriscopeMode == 2 && Camera.op_Inequality(this.DroneCam, (Camera) null))
          {
            while (true)
            {
              if (Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
              {
                InputArgument.op_Implicit("mpsubmarine_periscope")
              }) == 0)
              {
                Script.Wait(10);
                Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
                {
                  InputArgument.op_Implicit("mpsubmarine_periscope"),
                  InputArgument.op_Implicit(0)
                });
              }
              else
                break;
            }
            while (true)
            {
              if (Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
              {
                InputArgument.op_Implicit("mpentry")
              }) == 0)
              {
                Script.Wait(10);
                Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
                {
                  InputArgument.op_Implicit("mpentry"),
                  InputArgument.op_Implicit(0)
                });
              }
              else
                break;
            }
            while (true)
            {
              if (Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
              {
                InputArgument.op_Implicit("helicopterhud")
              }) == 0)
              {
                Script.Wait(10);
                Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
                {
                  InputArgument.op_Implicit("helicopterhud"),
                  InputArgument.op_Implicit(0)
                });
              }
              else
                break;
            }
            this.DroneCam.Position = offsetInWorldCoords1;
            if (this.PeriscopeUseMouseMovement && Game.CurrentInputMode == 1)
            {
              if (Game.IsControlPressed(2, (Control) 271))
                this.DroneCam.Rotation = new Vector3((float) this.DroneCam.Rotation.X, 0.0f, (float) (this.DroneCam.Rotation.Z - 0.5));
              if (Game.IsControlPressed(2, (Control) 5))
                this.DroneCam.Rotation = new Vector3((float) this.DroneCam.Rotation.X, 0.0f, (float) (this.DroneCam.Rotation.Z + 0.5));
              if (Game.IsControlPressed(2, (Control) 3) && this.DroneCam.Rotation.X < 65.0)
                this.DroneCam.Rotation = new Vector3((float) (this.DroneCam.Rotation.X + 0.5), 0.0f, (float) this.DroneCam.Rotation.Z);
              if (Game.IsControlPressed(2, (Control) 4) && this.DroneCam.Rotation.X > -11.0)
                this.DroneCam.Rotation = new Vector3((float) (this.DroneCam.Rotation.X - 0.5), 0.0f, (float) this.DroneCam.Rotation.Z);
            }
            if (!this.PeriscopeUseMouseMovement && Game.CurrentInputMode == 1)
            {
              if (Game.IsControlPressed(2, (Control) 175))
                this.DroneCam.Rotation = new Vector3((float) this.DroneCam.Rotation.X, 0.0f, (float) (this.DroneCam.Rotation.Z - 0.5));
              if (Game.IsControlPressed(2, (Control) 174))
                this.DroneCam.Rotation = new Vector3((float) this.DroneCam.Rotation.X, 0.0f, (float) (this.DroneCam.Rotation.Z + 0.5));
              if (Game.IsControlPressed(2, (Control) 172) && this.DroneCam.Rotation.X < 65.0)
                this.DroneCam.Rotation = new Vector3((float) (this.DroneCam.Rotation.X + 0.5), 0.0f, (float) this.DroneCam.Rotation.Z);
              if (Game.IsControlPressed(2, (Control) 173) && this.DroneCam.Rotation.X > -11.0)
                this.DroneCam.Rotation = new Vector3((float) (this.DroneCam.Rotation.X - 0.5), 0.0f, (float) this.DroneCam.Rotation.Z);
            }
            if (!this.PeriscopeUseMouseMovement)
            {
              if (Game.IsControlPressed(2, (Control) 175))
                this.DroneCam.Rotation = new Vector3((float) this.DroneCam.Rotation.X, 0.0f, (float) (this.DroneCam.Rotation.Z - 0.5));
              if (Game.IsControlPressed(2, (Control) 174))
                this.DroneCam.Rotation = new Vector3((float) this.DroneCam.Rotation.X, 0.0f, (float) (this.DroneCam.Rotation.Z + 0.5));
              if (Game.IsControlPressed(2, (Control) 172) && this.DroneCam.Rotation.X < 65.0)
                this.DroneCam.Rotation = new Vector3((float) (this.DroneCam.Rotation.X + 0.5), 0.0f, (float) this.DroneCam.Rotation.Z);
              if (Game.IsControlPressed(2, (Control) 173) && this.DroneCam.Rotation.X > -11.0)
                this.DroneCam.Rotation = new Vector3((float) (this.DroneCam.Rotation.X - 0.5), 0.0f, (float) this.DroneCam.Rotation.Z);
            }
            if (this.PeriscopeUseMouseMovement && Game.CurrentInputMode == 0)
            {
              float num1 = 0.0f;
              float num2 = 0.0f;
              float num4 = (float) Function.Call<float>((Hash) -1424092350868114077L, new InputArgument[2]
              {
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(240)
              });
              float num5 = (float) Function.Call<float>((Hash) -1424092350868114077L, new InputArgument[2]
              {
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(239)
              });
              Vector2 vector2_1;
              // ISSUE: explicit constructor call
              ((Vector2) ref vector2_1).\u002Ector(num5, num4);
              if ((double) ((Vector2) ref vector2_1).DistanceTo(this.MousePos) > 0.0500000007450581)
              {
                this.LeftRightTimer = 0;
                this.LeftRightMoveAmt = 0.0f;
                this.MousePos = vector2_1;
              }
              if ((double) num5 > 0.45 && (double) num5 < 0.55)
              {
                this.LeftRightTimer = 0;
                this.LeftRightMoveAmt = 0.0f;
                num5 = 0.0f;
              }
              else
              {
                if ((double) num5 >= 0.550000011920929 && ((double) this.LeftRightMoveAmt >= -1.0 && (double) this.LeftRightMoveAmt < 1.0))
                {
                  ++this.LeftRightTimer;
                  double leftRightTimer = (double) this.LeftRightTimer;
                  Vector2 vector2_2 = new Vector2(num5, num4);
                  double num6 = (double) ((Vector2) ref vector2_2).DistanceTo(new Vector2(0.5f, 0.5f)) * 345.0 * 0.800000011920929;
                  if (leftRightTimer < num6)
                  {
                    num1 = -0.5f;
                    this.LeftRightMoveAmt -= 0.005f;
                  }
                  else
                  {
                    num1 = 0.0f;
                    this.LeftRightMoveAmt = 0.0f;
                  }
                }
                if ((double) num5 <= 0.449999988079071 && ((double) this.LeftRightMoveAmt >= -1.0 && (double) this.LeftRightMoveAmt < 1.0))
                {
                  ++this.LeftRightTimer;
                  double leftRightTimer = (double) this.LeftRightTimer;
                  Vector2 vector2_2 = new Vector2(num5, num4);
                  double num6 = (double) ((Vector2) ref vector2_2).DistanceTo(new Vector2(0.5f, 0.5f)) * 345.0 * 0.800000011920929;
                  if (leftRightTimer < num6)
                  {
                    this.LeftRightMoveAmt += 0.005f;
                    num1 = 0.5f;
                  }
                  else
                  {
                    num1 = 0.0f;
                    this.LeftRightMoveAmt = 0.0f;
                  }
                }
              }
              if ((double) num4 > 0.45 && (double) num4 < 0.55)
              {
                this.UpDownTimer = 0;
                this.UpDownMoveAmt = 0.0f;
              }
              else
              {
                if ((double) num4 >= 0.550000011920929 && ((double) this.UpDownMoveAmt >= -1.0 && (double) this.UpDownMoveAmt < 1.0))
                {
                  ++this.UpDownTimer;
                  double upDownTimer = (double) this.UpDownTimer;
                  Vector2 vector2_2 = new Vector2(num5, num4);
                  double num6 = (double) ((Vector2) ref vector2_2).DistanceTo(new Vector2(0.5f, 0.5f)) * 345.0 * 0.800000011920929;
                  if (upDownTimer < num6)
                  {
                    this.UpDownMoveAmt -= 0.005f;
                    num2 = -0.5f;
                  }
                  else
                  {
                    this.UpDownMoveAmt = 0.0f;
                    num2 = 0.0f;
                  }
                }
                if ((double) num4 <= 0.449999988079071 && ((double) this.UpDownMoveAmt >= -1.0 && (double) this.UpDownMoveAmt < 1.0))
                {
                  ++this.UpDownTimer;
                  double upDownTimer = (double) this.UpDownTimer;
                  Vector2 vector2_2 = new Vector2(num5, num4);
                  double num6 = (double) ((Vector2) ref vector2_2).DistanceTo(new Vector2(0.5f, 0.5f)) * 345.0 * 0.800000011920929;
                  if (upDownTimer < num6)
                  {
                    this.UpDownMoveAmt += 0.005f;
                    num2 = 0.5f;
                  }
                  else
                  {
                    this.UpDownMoveAmt = 0.0f;
                    num2 = 0.0f;
                  }
                }
              }
              Camera droneCam = this.DroneCam;
              droneCam.Rotation = Vector3.op_Addition(droneCam.Rotation, new Vector3(this.UpDownMoveAmt, 0.0f, this.LeftRightMoveAmt));
            }
            if (this.GuidedMissiles == 1)
            {
              foreach (Vehicle nearbyVehicle in World.GetNearbyVehicles(((Entity) this.Kosatka).Position, 1500f))
              {
                if (((Entity) nearbyVehicle).IsOnScreen)
                {
                  Vector2 vector2 = this.World3DToScreen2d(((Entity) nearbyVehicle).Position);
                  if ((double) vector2.X >= 0.2 && (double) vector2.X <= 0.8 && ((double) vector2.Y >= 0.2 && (double) vector2.Y <= 0.8))
                  {
                    if ((double) vector2.X >= 0.45 && (double) vector2.X <= 0.55)
                    {
                      if ((double) vector2.Y >= 0.45 && (double) vector2.Y <= 0.55)
                      {
                        Vector3 offsetInWorldCoords2 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -10f, 8f));
                        Vector3 offsetInWorldCoords3 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -8f, 8f));
                        Vector3 offsetInWorldCoords4 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -6f, 8f));
                        Vector3 offsetInWorldCoords5 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -4f, 8f));
                        Vector3 offsetInWorldCoords6 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -10f, 8f));
                        Vector3 offsetInWorldCoords7 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -8f, 8f));
                        Vector3 offsetInWorldCoords8 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -6f, 8f));
                        Vector3 offsetInWorldCoords9 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -4f, 8f));
                        this.drawSprite3("helicopterhud", "hud_outline", (float) vector2.X, (float) vector2.Y, 30f, 30f, (int) byte.MaxValue, 0, 0, (int) byte.MaxValue);
                        Function.Call((Hash) 7042254994863937538L, new InputArgument[1]
                        {
                          InputArgument.op_Implicit(0)
                        });
                        this.DisplayHelpTextThisFrameNoSound("Missile Ready!, Press ~INPUT_ATTACK~ to Fire!");
                        if (Game.IsControlJustPressed(2, (Control) 24))
                        {
                          this.MissileSpeed = 1f;
                          this.PilotingMissile2 = false;
                          this.PilotingGuidedMissil3 = false;
                          if (Entity.op_Inequality((Entity) this.Missile, (Entity) null))
                            ((Entity) this.Missile).Delete();
                          if (Entity.op_Inequality((Entity) this.Missile2, (Entity) null))
                            ((Entity) this.Missile2).Delete();
                          if (Entity.op_Inequality((Entity) this.GuidedMissileTarget, (Entity) null))
                            ((Entity) this.GuidedMissileTarget).Delete();
                          int num1 = new Random().Next(0, 800);
                          Vector3 vector3 = new Vector3();
                          if (num1 < 100)
                            vector3 = offsetInWorldCoords2;
                          if (num1 >= 100 & num1 < 200)
                            vector3 = offsetInWorldCoords3;
                          if (num1 >= 200 & num1 < 300)
                            vector3 = offsetInWorldCoords4;
                          if (num1 >= 300 & num1 < 400)
                            vector3 = offsetInWorldCoords5;
                          if (num1 >= 400 & num1 < 500)
                            vector3 = offsetInWorldCoords6;
                          if (num1 >= 500 & num1 < 600)
                            vector3 = offsetInWorldCoords7;
                          if (num1 >= 600 & num1 < 700)
                            vector3 = offsetInWorldCoords8;
                          if (num1 >= 700 & num1 <= 800)
                            vector3 = offsetInWorldCoords9;
                          this.Missile = World.CreateProp(this.RequestModel("h4_prop_h4_mine_01a"), vector3, new Vector3(0.0f, 0.0f, 0.0f), false, false);
                          this.Missile2 = World.CreateProp(this.RequestModel("h4_prop_h4_airmissile_01a"), vector3, new Vector3(0.0f, 0.0f, 0.0f), false, false);
                          this.TargetVehicle = nearbyVehicle;
                          this.ReachedZCoord = false;
                          Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                          {
                            InputArgument.op_Implicit(0),
                            InputArgument.op_Implicit(0),
                            InputArgument.op_Implicit(3000),
                            InputArgument.op_Implicit(1),
                            InputArgument.op_Implicit(0)
                          });
                          ((Entity) Game.Player.Character).IsInvincible = false;
                          ((Entity) Game.Player.Character).IsVisible = true;
                          if (Camera.op_Inequality(this.DroneCam, (Camera) null))
                            this.DroneCam.Destroy();
                          this.UsingPeriscope = false;
                          this.DroneCam = World.CreateCamera(((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 4f)), new Vector3(0.0f, 0.0f, 0.0f), 60f);
                          Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                          {
                            InputArgument.op_Implicit(1),
                            InputArgument.op_Implicit(0),
                            InputArgument.op_Implicit(3000),
                            InputArgument.op_Implicit(1),
                            InputArgument.op_Implicit(0)
                          });
                          World.RenderingCamera = this.DroneCam;
                          this.PilotingMissile2 = true;
                        }
                      }
                      else
                        this.drawSprite3("helicopterhud", "hud_lock", (float) vector2.X, (float) vector2.Y, 30f, 30f, (int) byte.MaxValue, 0, 0, (int) byte.MaxValue);
                    }
                    else
                      this.drawSprite3("helicopterhud", "hud_lock", (float) vector2.X, (float) vector2.Y, 30f, 30f, (int) byte.MaxValue, 0, 0, (int) byte.MaxValue);
                  }
                }
              }
            }
            if (!this.UsingInteriorPeriscope)
            {
              if (Game.CurrentInputMode == 0)
              {
                Function.Call((Hash) 7042254994863937538L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(0)
                });
                this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use Periscope");
                Function.Call((Hash) 7042254994863937538L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(1)
                });
              }
              if (Game.CurrentInputMode == 1)
              {
                Function.Call((Hash) 7042254994863937538L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(0)
                });
                this.DisplayHelpTextThisFrame("Press ~INPUT_COVER~ to use Periscope");
                Function.Call((Hash) 7042254994863937538L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(1)
                });
              }
            }
            if (this.UsingInteriorPeriscope)
            {
              if (Game.CurrentInputMode == 0)
              {
                Function.Call((Hash) 7042254994863937538L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(0)
                });
                this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to stop using Periscope");
                Function.Call((Hash) 7042254994863937538L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(1)
                });
              }
              if (Game.CurrentInputMode == 1)
              {
                Function.Call((Hash) 7042254994863937538L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(0)
                });
                this.DisplayHelpTextThisFrame("Press ~INPUT_COVER~ to stop using Periscope");
                Function.Call((Hash) 7042254994863937538L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(1)
                });
              }
            }
            Function.Call((Hash) 7042254994863937538L, new InputArgument[1]
            {
              InputArgument.op_Implicit(1)
            });
            float num7 = (float) Function.Call<float>((Hash) -1424092350868114077L, new InputArgument[2]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(240)
            });
            float num8 = (float) Function.Call<float>((Hash) -1424092350868114077L, new InputArgument[2]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(239)
            });
            while (true)
            {
              if (Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
              {
                InputArgument.op_Implicit("mpmissmarkers256")
              }) == 0)
              {
                Script.Wait(10);
                Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
                {
                  InputArgument.op_Implicit("mpmissmarkers256"),
                  InputArgument.op_Implicit(0)
                });
              }
              else
                break;
            }
            this.drawSpriteRTA("mpsubmarine_periscope", "crosshairline", 0.5f, 0.5f, 2320f, 1f, 40, 140, 0, (int) byte.MaxValue, 90f);
            this.drawSpriteRTA("mpsubmarine_periscope", "crosshairline", 0.5f, 0.5f, 1f, 2320f, 40, 140, 0, (int) byte.MaxValue, 0.0f);
            this.drawSprite3("mpsubmarine_periscope", "scopeoverlay", 0.5f, 0.5f, 1920f, 1920f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          }
          if (this.PeriscopeMode == 1 && Camera.op_Inequality(this.DroneCam, (Camera) null))
          {
            while (true)
            {
              if (Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
              {
                InputArgument.op_Implicit("mpsubmarine_periscope")
              }) == 0)
              {
                Script.Wait(10);
                Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
                {
                  InputArgument.op_Implicit("mpsubmarine_periscope"),
                  InputArgument.op_Implicit(0)
                });
              }
              else
                break;
            }
            while (true)
            {
              if (Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
              {
                InputArgument.op_Implicit("mpentry")
              }) == 0)
              {
                Script.Wait(10);
                Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
                {
                  InputArgument.op_Implicit("mpentry"),
                  InputArgument.op_Implicit(0)
                });
              }
              else
                break;
            }
            while (true)
            {
              if (Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
              {
                InputArgument.op_Implicit("helicopterhud")
              }) == 0)
              {
                Script.Wait(10);
                Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
                {
                  InputArgument.op_Implicit("helicopterhud"),
                  InputArgument.op_Implicit(0)
                });
              }
              else
                break;
            }
            this.DroneCam.Position = offsetInWorldCoords1;
            if (this.PeriscopeUseMouseMovement && Game.CurrentInputMode == 1)
            {
              if (Game.IsControlPressed(2, (Control) 271))
                this.DroneCam.Rotation = new Vector3((float) this.DroneCam.Rotation.X, 0.0f, (float) (this.DroneCam.Rotation.Z - 0.5));
              if (Game.IsControlPressed(2, (Control) 5))
                this.DroneCam.Rotation = new Vector3((float) this.DroneCam.Rotation.X, 0.0f, (float) (this.DroneCam.Rotation.Z + 0.5));
              if (Game.IsControlPressed(2, (Control) 3) && this.DroneCam.Rotation.X < 65.0)
                this.DroneCam.Rotation = new Vector3((float) (this.DroneCam.Rotation.X + 0.5), 0.0f, (float) this.DroneCam.Rotation.Z);
              if (Game.IsControlPressed(2, (Control) 4) && this.DroneCam.Rotation.X > -11.0)
                this.DroneCam.Rotation = new Vector3((float) (this.DroneCam.Rotation.X - 0.5), 0.0f, (float) this.DroneCam.Rotation.Z);
            }
            if (!this.PeriscopeUseMouseMovement && Game.CurrentInputMode == 1)
            {
              if (Game.IsControlPressed(2, (Control) 175))
                this.DroneCam.Rotation = new Vector3((float) this.DroneCam.Rotation.X, 0.0f, (float) (this.DroneCam.Rotation.Z - 0.5));
              if (Game.IsControlPressed(2, (Control) 174))
                this.DroneCam.Rotation = new Vector3((float) this.DroneCam.Rotation.X, 0.0f, (float) (this.DroneCam.Rotation.Z + 0.5));
              if (Game.IsControlPressed(2, (Control) 172) && this.DroneCam.Rotation.X < 65.0)
                this.DroneCam.Rotation = new Vector3((float) (this.DroneCam.Rotation.X + 0.5), 0.0f, (float) this.DroneCam.Rotation.Z);
              if (Game.IsControlPressed(2, (Control) 173) && this.DroneCam.Rotation.X > -11.0)
                this.DroneCam.Rotation = new Vector3((float) (this.DroneCam.Rotation.X - 0.5), 0.0f, (float) this.DroneCam.Rotation.Z);
            }
            if (this.GuidedMissiles == 1)
            {
              foreach (Vehicle nearbyVehicle in World.GetNearbyVehicles(((Entity) this.Kosatka).Position, 1500f))
              {
                if (((Entity) nearbyVehicle).IsOnScreen)
                {
                  Vector2 vector2 = this.World3DToScreen2d(((Entity) nearbyVehicle).Position);
                  if ((double) vector2.X >= 0.2 && (double) vector2.X <= 0.8 && ((double) vector2.Y >= 0.2 && (double) vector2.Y <= 0.8))
                  {
                    if ((double) vector2.X >= 0.45 && (double) vector2.X <= 0.55)
                    {
                      if ((double) vector2.Y >= 0.45 && (double) vector2.Y <= 0.55)
                      {
                        Vector3 offsetInWorldCoords2 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -10f, 8f));
                        Vector3 offsetInWorldCoords3 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -8f, 8f));
                        Vector3 offsetInWorldCoords4 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -6f, 8f));
                        Vector3 offsetInWorldCoords5 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -4f, 8f));
                        Vector3 offsetInWorldCoords6 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -10f, 8f));
                        Vector3 offsetInWorldCoords7 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -8f, 8f));
                        Vector3 offsetInWorldCoords8 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -6f, 8f));
                        Vector3 offsetInWorldCoords9 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -4f, 8f));
                        this.drawSprite3("helicopterhud", "hud_outline", (float) vector2.X, (float) vector2.Y, 30f, 30f, (int) byte.MaxValue, 0, 0, (int) byte.MaxValue);
                        Function.Call((Hash) 7042254994863937538L, new InputArgument[1]
                        {
                          InputArgument.op_Implicit(0)
                        });
                        this.DisplayHelpTextThisFrameNoSound("Missile Ready!, Press ~INPUT_ATTACK~ to Fire!");
                        if (Game.IsControlJustPressed(2, (Control) 24))
                        {
                          this.MissileSpeed = 1f;
                          this.PilotingMissile2 = false;
                          this.PilotingGuidedMissil3 = false;
                          if (Entity.op_Inequality((Entity) this.Missile, (Entity) null))
                            ((Entity) this.Missile).Delete();
                          if (Entity.op_Inequality((Entity) this.Missile2, (Entity) null))
                            ((Entity) this.Missile2).Delete();
                          if (Entity.op_Inequality((Entity) this.GuidedMissileTarget, (Entity) null))
                            ((Entity) this.GuidedMissileTarget).Delete();
                          int num1 = new Random().Next(0, 800);
                          Vector3 vector3 = new Vector3();
                          if (num1 < 100)
                            vector3 = offsetInWorldCoords2;
                          if (num1 >= 100 & num1 < 200)
                            vector3 = offsetInWorldCoords3;
                          if (num1 >= 200 & num1 < 300)
                            vector3 = offsetInWorldCoords4;
                          if (num1 >= 300 & num1 < 400)
                            vector3 = offsetInWorldCoords5;
                          if (num1 >= 400 & num1 < 500)
                            vector3 = offsetInWorldCoords6;
                          if (num1 >= 500 & num1 < 600)
                            vector3 = offsetInWorldCoords7;
                          if (num1 >= 600 & num1 < 700)
                            vector3 = offsetInWorldCoords8;
                          if (num1 >= 700 & num1 <= 800)
                            vector3 = offsetInWorldCoords9;
                          this.Missile = World.CreateProp(this.RequestModel("h4_prop_h4_mine_01a"), vector3, new Vector3(0.0f, 0.0f, 0.0f), false, false);
                          this.Missile2 = World.CreateProp(this.RequestModel("h4_prop_h4_airmissile_01a"), vector3, new Vector3(0.0f, 0.0f, 0.0f), false, false);
                          this.TargetVehicle = nearbyVehicle;
                          this.ReachedZCoord = false;
                          Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                          {
                            InputArgument.op_Implicit(0),
                            InputArgument.op_Implicit(0),
                            InputArgument.op_Implicit(3000),
                            InputArgument.op_Implicit(1),
                            InputArgument.op_Implicit(0)
                          });
                          ((Entity) Game.Player.Character).IsInvincible = false;
                          ((Entity) Game.Player.Character).IsVisible = true;
                          if (Camera.op_Inequality(this.DroneCam, (Camera) null))
                            this.DroneCam.Destroy();
                          this.UsingPeriscope = false;
                          this.DroneCam = World.CreateCamera(((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 4f)), new Vector3(0.0f, 0.0f, 0.0f), 60f);
                          Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                          {
                            InputArgument.op_Implicit(1),
                            InputArgument.op_Implicit(0),
                            InputArgument.op_Implicit(3000),
                            InputArgument.op_Implicit(1),
                            InputArgument.op_Implicit(0)
                          });
                          World.RenderingCamera = this.DroneCam;
                          this.PilotingMissile2 = true;
                        }
                      }
                      else
                        this.drawSprite3("helicopterhud", "hud_lock", (float) vector2.X, (float) vector2.Y, 30f, 30f, (int) byte.MaxValue, 0, 0, (int) byte.MaxValue);
                    }
                    else
                      this.drawSprite3("helicopterhud", "hud_lock", (float) vector2.X, (float) vector2.Y, 30f, 30f, (int) byte.MaxValue, 0, 0, (int) byte.MaxValue);
                  }
                }
              }
            }
            if (this.PeriscopeUseMouseMovement && Camera.op_Inequality(this.DroneCam, (Camera) null) && Game.CurrentInputMode == 0)
            {
              float num1 = 0.0f;
              float num2 = 0.0f;
              float num4 = (float) Function.Call<float>((Hash) -1424092350868114077L, new InputArgument[2]
              {
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(240)
              });
              float num5 = (float) Function.Call<float>((Hash) -1424092350868114077L, new InputArgument[2]
              {
                InputArgument.op_Implicit(2),
                InputArgument.op_Implicit(239)
              });
              Vector2 vector2_1;
              // ISSUE: explicit constructor call
              ((Vector2) ref vector2_1).\u002Ector(num5, num4);
              if ((double) ((Vector2) ref vector2_1).DistanceTo(this.MousePos) > 0.0500000007450581)
              {
                this.LeftRightTimer = 0;
                this.LeftRightMoveAmt = 0.0f;
                this.MousePos = vector2_1;
              }
              if ((double) num5 > 0.45 && (double) num5 < 0.55)
              {
                this.LeftRightTimer = 0;
                this.LeftRightMoveAmt = 0.0f;
                num5 = 0.0f;
              }
              else
              {
                if ((double) num5 >= 0.550000011920929 && ((double) this.LeftRightMoveAmt >= -1.0 && (double) this.LeftRightMoveAmt < 1.0))
                {
                  ++this.LeftRightTimer;
                  double leftRightTimer = (double) this.LeftRightTimer;
                  Vector2 vector2_2 = new Vector2(num5, num4);
                  double num6 = (double) ((Vector2) ref vector2_2).DistanceTo(new Vector2(0.5f, 0.5f)) * 345.0 * 0.800000011920929;
                  if (leftRightTimer < num6)
                  {
                    num1 = -0.5f;
                    this.LeftRightMoveAmt -= 0.005f;
                  }
                  else
                  {
                    num1 = 0.0f;
                    this.LeftRightMoveAmt = 0.0f;
                  }
                }
                if ((double) num5 <= 0.449999988079071 && ((double) this.LeftRightMoveAmt >= -1.0 && (double) this.LeftRightMoveAmt < 1.0))
                {
                  ++this.LeftRightTimer;
                  double leftRightTimer = (double) this.LeftRightTimer;
                  Vector2 vector2_2 = new Vector2(num5, num4);
                  double num6 = (double) ((Vector2) ref vector2_2).DistanceTo(new Vector2(0.5f, 0.5f)) * 345.0 * 0.800000011920929;
                  if (leftRightTimer < num6)
                  {
                    this.LeftRightMoveAmt += 0.005f;
                    num1 = 0.5f;
                  }
                  else
                  {
                    num1 = 0.0f;
                    this.LeftRightMoveAmt = 0.0f;
                  }
                }
              }
              if ((double) num4 > 0.45 && (double) num4 < 0.55)
              {
                this.UpDownTimer = 0;
                this.UpDownMoveAmt = 0.0f;
                num4 = 0.0f;
              }
              else
              {
                if ((double) num4 >= 0.550000011920929 && ((double) this.UpDownMoveAmt >= -1.0 && (double) this.UpDownMoveAmt < 1.0))
                {
                  ++this.UpDownTimer;
                  double upDownTimer = (double) this.UpDownTimer;
                  Vector2 vector2_2 = new Vector2(num5, num4);
                  double num6 = (double) ((Vector2) ref vector2_2).DistanceTo(new Vector2(0.5f, 0.5f)) * 345.0 * 0.800000011920929;
                  if (upDownTimer < num6)
                  {
                    this.UpDownMoveAmt -= 0.005f;
                    num2 = -0.5f;
                  }
                  else
                  {
                    this.UpDownMoveAmt = 0.0f;
                    num2 = 0.0f;
                  }
                }
                if ((double) num4 <= 0.449999988079071 && ((double) this.UpDownMoveAmt >= -1.0 && (double) this.UpDownMoveAmt < 1.0))
                {
                  ++this.UpDownTimer;
                  double upDownTimer = (double) this.UpDownTimer;
                  Vector2 vector2_2 = new Vector2(num5, num4);
                  double num6 = (double) ((Vector2) ref vector2_2).DistanceTo(new Vector2(0.5f, 0.5f)) * 345.0 * 0.800000011920929;
                  if (upDownTimer < num6)
                  {
                    this.UpDownMoveAmt += 0.005f;
                    num2 = 0.5f;
                  }
                  else
                  {
                    this.UpDownMoveAmt = 0.0f;
                    num2 = 0.0f;
                  }
                }
              }
              Vector2 vector2_3 = new Vector2(num5, num4);
              num3 = (float) ((double) ((Vector2) ref vector2_3).DistanceTo(new Vector2(0.5f, 0.5f)) * 345.0 * 0.800000011920929);
              UI.ShowSubtitle("Dist" + num3.ToString());
              Camera droneCam = this.DroneCam;
              droneCam.Rotation = Vector3.op_Addition(droneCam.Rotation, new Vector3(this.UpDownMoveAmt, 0.0f, this.LeftRightMoveAmt));
            }
            Function.Call((Hash) 7042254994863937538L, new InputArgument[1]
            {
              InputArgument.op_Implicit(1)
            });
            float num7 = (float) Function.Call<float>((Hash) -1424092350868114077L, new InputArgument[2]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(240)
            });
            float num8 = (float) Function.Call<float>((Hash) -1424092350868114077L, new InputArgument[2]
            {
              InputArgument.op_Implicit(2),
              InputArgument.op_Implicit(239)
            });
            while (true)
            {
              if (Function.Call<bool>((Hash) 91750494399812324L, new InputArgument[1]
              {
                InputArgument.op_Implicit("mpmissmarkers256")
              }) == 0)
              {
                Script.Wait(10);
                Function.Call((Hash) -2332038263791780395L, new InputArgument[2]
                {
                  InputArgument.op_Implicit("mpmissmarkers256"),
                  InputArgument.op_Implicit(0)
                });
              }
              else
                break;
            }
            this.drawSpriteRTA("mpsubmarine_periscope", "crosshairline", 0.5f, 0.5f, 2320f, 1f, 40, 140, 0, (int) byte.MaxValue, 90f);
            this.drawSpriteRTA("mpsubmarine_periscope", "crosshairline", 0.5f, 0.5f, 1f, 2320f, 40, 140, 0, (int) byte.MaxValue, 0.0f);
            this.drawSprite3("mpsubmarine_periscope", "scopeoverlay", 0.5f, 0.5f, 1920f, 1920f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          }
        }
        if (Entity.op_Inequality((Entity) Game.Player.Character.CurrentVehicle, (Entity) null))
        {
          if (Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) this.Kosatka))
          {
            this.IsInInterior = false;
            ((Entity) this.Kosatka).FreezePosition = false;
            if (((Entity) this.Kosatka).Position.Z < -14.0)
              this.ShowSubControlls2();
            if (((Entity) this.Kosatka).Position.Z > -14.0)
            {
              this.ShowSubControlls();
              if (Game.IsControlJustPressed(2, (Control) 51) && Game.CurrentInputMode == null || Game.IsControlJustPressed(2, (Control) 44) && Game.CurrentInputMode == 1)
              {
                if (!this.UsingPeriscope)
                {
                  this.PeriscopeMode = 1;
                  this.DroneCam = World.CreateCamera(offsetInWorldCoords1, new Vector3(0.0f, 0.0f, ((Entity) this.Kosatka).Heading), 30f);
                  Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                  {
                    InputArgument.op_Implicit(1),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(3000),
                    InputArgument.op_Implicit(1),
                    InputArgument.op_Implicit(0)
                  });
                  World.RenderingCamera = this.DroneCam;
                  this.UsingPeriscope = true;
                  UI.Notify("Activating Periscope");
                }
                else if (this.UsingPeriscope && this.PeriscopeMode == 1)
                {
                  this.PeriscopeMode = 0;
                  Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                  {
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(3000),
                    InputArgument.op_Implicit(1),
                    InputArgument.op_Implicit(0)
                  });
                  ((Entity) Game.Player.Character).IsInvincible = false;
                  ((Entity) Game.Player.Character).IsVisible = true;
                  Game.Player.Character.SetIntoVehicle(this.Kosatka, (VehicleSeat) -1);
                  Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                  {
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(3000),
                    InputArgument.op_Implicit(1),
                    InputArgument.op_Implicit(0)
                  });
                  this.DroneCam.Destroy();
                  this.UsingPeriscope = false;
                }
              }
            }
            if (this.SonarStation == 1)
            {
              if (Game.IsControlJustPressed(2, (Control) 36) && Game.CurrentInputMode == 1 || Game.IsControlJustPressed(2, (Control) 73) && Game.CurrentInputMode == 0)
              {
                if (this.SonarActive)
                {
                  UI.Notify("~y~ Kosatka ~w~ Sonar has been turned off");
                  this.SonarActive = false;
                  Function.Call((Hash) 7732958218177162945L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(false)
                  });
                  try
                  {
                    if (Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) null))
                    {
                      foreach (KosatkaScript.Wreck underWaterWreck in this.UnderWaterWrecks)
                      {
                        if (underWaterWreck.Created)
                        {
                          if (Blip.op_Inequality(underWaterWreck.Blip, (Blip) null))
                            underWaterWreck.Blip.Remove();
                          underWaterWreck.Created = false;
                        }
                      }
                    }
                    if (this.RDOBJ.Count > 0)
                    {
                      foreach (Prop prop in this.RDOBJ)
                      {
                        if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null) && (double) World.GetDistance(((Entity) this.Kosatka).Position, ((Entity) prop).Position) > 500.0)
                        {
                          ((Entity) prop).CurrentBlip.Remove();
                          this.RDOBJ.Remove(prop);
                        }
                        if (Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) null))
                        {
                          ((Entity) prop).CurrentBlip.Remove();
                          this.RDOBJ.Remove(prop);
                        }
                      }
                    }
                  }
                  catch
                  {
                  }
                }
                else if (!this.SonarActive)
                {
                  UI.Notify("~y~ Kosatka ~w~ Sonar has been turned On");
                  this.SonarActive = true;
                }
              }
              if (this.SonarActive)
              {
                Function.Call((Hash) 7732958218177162945L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(true)
                });
                Prop[] nearbyProps1 = World.GetNearbyProps(((Entity) this.Kosatka).Position, 500f, Model.op_Implicit("h4_prop_h4_mine_01a"));
                Prop[] nearbyProps2 = World.GetNearbyProps(((Entity) this.Kosatka).Position, 500f, Model.op_Implicit("h4_prop_h4_mine_02a"));
                Prop[] nearbyProps3 = World.GetNearbyProps(((Entity) this.Kosatka).Position, 500f, Model.op_Implicit("h4_prop_h4_mine_03a"));
                Prop[] nearbyProps4 = World.GetNearbyProps(((Entity) this.Kosatka).Position, 500f, Model.op_Implicit("xm_prop_x17_sub"));
                Prop[] nearbyProps5 = World.GetNearbyProps(((Entity) this.Kosatka).Position, 500f, Model.op_Implicit("xm_prop_x17_mine_01a"));
                Prop[] nearbyProps6 = World.GetNearbyProps(((Entity) this.Kosatka).Position, 500f, Model.op_Implicit("xm_prop_x17_mine_02a"));
                Prop[] nearbyProps7 = World.GetNearbyProps(((Entity) this.Kosatka).Position, 500f, Model.op_Implicit("xm_prop_x17_mine_03a"));
                Prop[] nearbyProps8 = World.GetNearbyProps(((Entity) this.Kosatka).Position, 500f, Model.op_Implicit("cs2_10_sea_sub_00"));
                foreach (Prop prop in nearbyProps1)
                {
                  if (!this.RDOBJ.Contains(prop))
                  {
                    this.RDOBJ.Add(prop);
                    ((Entity) prop).AddBlip();
                    ((Entity) prop).CurrentBlip.Sprite = (BlipSprite) 1;
                    ((Entity) prop).CurrentBlip.Name = "Sea Mine";
                    ((Entity) prop).CurrentBlip.Scale = 0.4f;
                    ((Entity) prop).CurrentBlip.Color = (BlipColor) 76;
                  }
                }
                foreach (Prop prop in nearbyProps2)
                {
                  if (!this.RDOBJ.Contains(prop))
                  {
                    this.RDOBJ.Add(prop);
                    ((Entity) prop).AddBlip();
                    ((Entity) prop).CurrentBlip.Sprite = (BlipSprite) 1;
                    ((Entity) prop).CurrentBlip.Name = "Sea Mine";
                    ((Entity) prop).CurrentBlip.Scale = 0.4f;
                    ((Entity) prop).CurrentBlip.Color = (BlipColor) 76;
                  }
                }
                foreach (Prop prop in nearbyProps3)
                {
                  if (!this.RDOBJ.Contains(prop))
                  {
                    this.RDOBJ.Add(prop);
                    ((Entity) prop).AddBlip();
                    ((Entity) prop).CurrentBlip.Sprite = (BlipSprite) 1;
                    ((Entity) prop).CurrentBlip.Name = "Sea Mine";
                    ((Entity) prop).CurrentBlip.Scale = 0.4f;
                    ((Entity) prop).CurrentBlip.Color = (BlipColor) 76;
                  }
                }
                foreach (Prop prop in nearbyProps5)
                {
                  if (!this.RDOBJ.Contains(prop))
                  {
                    this.RDOBJ.Add(prop);
                    ((Entity) prop).AddBlip();
                    ((Entity) prop).CurrentBlip.Sprite = (BlipSprite) 1;
                    ((Entity) prop).CurrentBlip.Name = "Sea Mine";
                    ((Entity) prop).CurrentBlip.Scale = 0.4f;
                    ((Entity) prop).CurrentBlip.Color = (BlipColor) 76;
                  }
                }
                foreach (Prop prop in nearbyProps6)
                {
                  if (!this.RDOBJ.Contains(prop))
                  {
                    this.RDOBJ.Add(prop);
                    ((Entity) prop).AddBlip();
                    ((Entity) prop).CurrentBlip.Sprite = (BlipSprite) 1;
                    ((Entity) prop).CurrentBlip.Name = "Sea Mine";
                    ((Entity) prop).CurrentBlip.Scale = 0.4f;
                    ((Entity) prop).CurrentBlip.Color = (BlipColor) 76;
                  }
                }
                foreach (Prop prop in nearbyProps7)
                {
                  if (!this.RDOBJ.Contains(prop))
                  {
                    this.RDOBJ.Add(prop);
                    ((Entity) prop).AddBlip();
                    ((Entity) prop).CurrentBlip.Sprite = (BlipSprite) 1;
                    ((Entity) prop).CurrentBlip.Name = "Sea Mine";
                    ((Entity) prop).CurrentBlip.Scale = 0.4f;
                    ((Entity) prop).CurrentBlip.Color = (BlipColor) 76;
                  }
                }
                foreach (Prop prop in nearbyProps4)
                {
                  if (!this.RDOBJ.Contains(prop))
                  {
                    this.RDOBJ.Add(prop);
                    ((Entity) prop).AddBlip();
                    ((Entity) prop).CurrentBlip.Sprite = (BlipSprite) 308;
                    ((Entity) prop).CurrentBlip.Name = "Submarine";
                    ((Entity) prop).CurrentBlip.Scale = 0.9f;
                    ((Entity) prop).CurrentBlip.Color = (BlipColor) 76;
                  }
                }
                foreach (Prop prop in nearbyProps8)
                {
                  if (!this.RDOBJ.Contains(prop))
                  {
                    this.RDOBJ.Add(prop);
                    ((Entity) prop).AddBlip();
                    ((Entity) prop).CurrentBlip.Sprite = (BlipSprite) 66;
                    ((Entity) prop).CurrentBlip.Name = "Underwater Object";
                    ((Entity) prop).CurrentBlip.Scale = 0.7f;
                    ((Entity) prop).CurrentBlip.Color = (BlipColor) 66;
                  }
                }
                try
                {
                  foreach (KosatkaScript.Wreck underwaterChest in this.UnderwaterChests)
                  {
                    if ((double) World.GetDistance(((Entity) this.Kosatka).Position, underwaterChest.L) <= 200.0 && !underwaterChest.Created)
                    {
                      if (Blip.op_Inequality(underwaterChest.Blip, (Blip) null))
                        underwaterChest.Blip.Remove();
                      underwaterChest.Created = true;
                      underwaterChest.Blip = World.CreateBlip(underwaterChest.L);
                      underwaterChest.Blip.Sprite = (BlipSprite) 66;
                      underwaterChest.Blip.Name = "Underwater Object";
                      underwaterChest.Blip.Scale = 0.6f;
                      underwaterChest.Blip.Color = (BlipColor) 66;
                    }
                    if ((double) World.GetDistance(((Entity) this.Kosatka).Position, underwaterChest.L) > 200.0 && underwaterChest.Created)
                    {
                      if (Blip.op_Inequality(underwaterChest.Blip, (Blip) null))
                        underwaterChest.Blip.Remove();
                      underwaterChest.Created = false;
                    }
                  }
                  foreach (KosatkaScript.Wreck underWaterWreck in this.UnderWaterWrecks)
                  {
                    if ((double) World.GetDistance(((Entity) this.Kosatka).Position, underWaterWreck.L) <= 500.0 && !underWaterWreck.Created)
                    {
                      if (Blip.op_Inequality(underWaterWreck.Blip, (Blip) null))
                        underWaterWreck.Blip.Remove();
                      underWaterWreck.Created = true;
                      underWaterWreck.Blip = World.CreateBlip(underWaterWreck.L);
                      underWaterWreck.Blip.Sprite = (BlipSprite) 66;
                      underWaterWreck.Blip.Name = "Underwater Object";
                      underWaterWreck.Blip.Scale = 0.6f;
                      underWaterWreck.Blip.Color = (BlipColor) 66;
                    }
                    if ((double) World.GetDistance(((Entity) this.Kosatka).Position, underWaterWreck.L) > 500.0 && underWaterWreck.Created)
                    {
                      if (Blip.op_Inequality(underWaterWreck.Blip, (Blip) null))
                        underWaterWreck.Blip.Remove();
                      underWaterWreck.Created = false;
                    }
                  }
                }
                catch
                {
                  UI.Notify("UnderWaterWrecks " + this.UnderWaterWrecks.Count.ToString());
                }
              }
              if (!this.SonarActive)
              {
                ((Entity) this.Kosatka).FreezePosition = false;
                Function.Call((Hash) 7732958218177162945L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(false)
                });
                try
                {
                  if (Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) null))
                  {
                    foreach (KosatkaScript.Wreck underWaterWreck in this.UnderWaterWrecks)
                    {
                      if (underWaterWreck.Created)
                      {
                        if (Blip.op_Inequality(underWaterWreck.Blip, (Blip) null))
                          underWaterWreck.Blip.Remove();
                        underWaterWreck.Created = false;
                      }
                    }
                  }
                  if (this.RDOBJ.Count > 0)
                  {
                    foreach (Prop prop in this.RDOBJ)
                    {
                      if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null) && (double) World.GetDistance(((Entity) this.Kosatka).Position, ((Entity) prop).Position) > 500.0)
                      {
                        ((Entity) prop).CurrentBlip.Remove();
                        this.RDOBJ.Remove(prop);
                      }
                      if (Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) null))
                      {
                        ((Entity) prop).CurrentBlip.Remove();
                        this.RDOBJ.Remove(prop);
                      }
                    }
                  }
                }
                catch
                {
                }
              }
            }
          }
          if (Entity.op_Inequality((Entity) Game.Player.Character.CurrentVehicle, (Entity) this.Kosatka))
          {
            ((Entity) this.Kosatka).FreezePosition = false;
            Function.Call((Hash) 7732958218177162945L, new InputArgument[1]
            {
              InputArgument.op_Implicit(false)
            });
          }
        }
        else
        {
          if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null) && ((Entity) this.Kosatka).Position.Z < -4.0)
            ((Entity) this.Kosatka).FreezePosition = true;
          Function.Call((Hash) 7732958218177162945L, new InputArgument[1]
          {
            InputArgument.op_Implicit(false)
          });
        }
      }
      try
      {
        if (Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) null))
        {
          foreach (KosatkaScript.Wreck underWaterWreck in this.UnderWaterWrecks)
          {
            if (underWaterWreck.Created)
            {
              if (Blip.op_Inequality(underWaterWreck.Blip, (Blip) null))
                underWaterWreck.Blip.Remove();
              underWaterWreck.Created = false;
            }
          }
        }
        if (this.RDOBJ.Count > 0)
        {
          foreach (Prop prop in this.RDOBJ)
          {
            if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null) && (double) World.GetDistance(((Entity) this.Kosatka).Position, ((Entity) prop).Position) > 500.0)
            {
              ((Entity) prop).CurrentBlip.Remove();
              this.RDOBJ.Remove(prop);
            }
            if (Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) null))
            {
              ((Entity) prop).CurrentBlip.Remove();
              this.RDOBJ.Remove(prop);
            }
          }
        }
      }
      catch
      {
      }
      if (!this.IsInInterior)
      {
        Vector3 position1 = ((Entity) Game.Player.Character).Position;
        if (Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit((float) position1.X),
          InputArgument.op_Implicit((float) position1.Y),
          InputArgument.op_Implicit((float) position1.Z)
        }) > 0)
        {
          if (Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(1560f),
            InputArgument.op_Implicit(400f),
            InputArgument.op_Implicit(-50f)
          }) == Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit((float) position1.X),
            InputArgument.op_Implicit((float) position1.Y),
            InputArgument.op_Implicit((float) position1.Z)
          }))
            this.IsInInterior = true;
        }
        if (!this.SeaSparrowOut && !this.AvisaOut && !this.ToreadorOut)
          this.Check = 0;
        this.CreatedInteriorVehicles = false;
        this.Readocci = false;
      }
      if (this.IsInInterior)
      {
        if (!this.CreatedInteriorVehicles && !this.ReadyForEnterAnim)
        {
          if (this.Check == 0)
          {
            this.Check = 1;
            int num1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
            {
              InputArgument.op_Implicit(1561.541f),
              InputArgument.op_Implicit(419.4447f),
              InputArgument.op_Implicit(-55.30978f)
            });
            Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
            {
              InputArgument.op_Implicit(num1)
            });
            Script.Wait(500);
            Script.Wait(500);
            if (this.WeaponsUpgrade == 1)
            {
              Function.Call((Hash) 6190315277334034081L, new InputArgument[2]
              {
                InputArgument.op_Implicit(num1),
                InputArgument.op_Implicit("entity_set_weapons")
              });
              Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
              {
                InputArgument.op_Implicit(num1)
              });
            }
            if (this.WeaponsUpgrade == 0)
            {
              Function.Call((Hash) 4759129920140927330L, new InputArgument[2]
              {
                InputArgument.op_Implicit(num1),
                InputArgument.op_Implicit("entity_set_weapons")
              });
              Function.Call((Hash) 4752278595253525216L, new InputArgument[1]
              {
                InputArgument.op_Implicit(num1)
              });
            }
            ++this.Check;
            UI.Notify("Refreshed ~b~Kosatka~w~ Interior");
          }
          this.CreatedInteriorVehicles = true;
          if (Entity.op_Inequality((Entity) this.PeriscopeProp, (Entity) null))
            ((Entity) this.PeriscopeProp).Delete();
          this.PeriscopeProp = World.CreateProp(this.RequestModel("h4_int_lev_sub_periscope_h_up"), new Vector3(1561.519f, 388.7829f, -48.59f), new Vector3(0.0f, 0.0f, 180f), false, false);
          int num2 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
          {
            InputArgument.op_Implicit(1561.541f),
            InputArgument.op_Implicit(419.4447f),
            InputArgument.op_Implicit(-55.30978f)
          });
          Function.Call((Hash) 5949884333633149191L, new InputArgument[3]
          {
            InputArgument.op_Implicit(this.PeriscopeProp),
            InputArgument.op_Implicit(num2),
            InputArgument.op_Implicit((int) Function.Call<int>((Hash) 5170871713518273099L, new InputArgument[1]
            {
              InputArgument.op_Implicit(Game.Player.Character)
            }))
          });
        }
        if (this.CreatedInteriorVehicles)
        {
          if (!Entity.op_Inequality((Entity) this.Toreador, (Entity) null))
            ;
          if (Entity.op_Inequality((Entity) this.Seasparrow, (Entity) null) && Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) this.Seasparrow))
          {
            if (((Entity) this.Kosatka).Position.Z >= -10.0)
            {
              this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use Sea Sparrow");
              if (Game.IsControlJustPressed(2, (Control) 51))
              {
                this.DroneCam = World.CreateCamera(new Vector3(1557.997f, 404.82f, -49.68f), new Vector3(0.0f, 0.0f, -39f), 80f);
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                World.RenderingCamera = this.DroneCam;
                string dict = "anim@scripted@submarine@vehicle_trans@helipad";
                KosatkaScript.LoadDict(dict);
                UI.Notify("If your Sea Sparrow is destroyed, you will have to wait for it to respawn");
                Vector3 vector3;
                // ISSUE: explicit constructor call
                ((Vector3) ref vector3).\u002Ector(1559.5f, 410.5084f, -50.66686f);
                this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) vector3.X),
                  InputArgument.op_Implicit((float) vector3.Y),
                  InputArgument.op_Implicit((float) vector3.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(180),
                  InputArgument.op_Implicit(0)
                });
                Function.Call((Hash) 7696488426199063767L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit((float) vector3.X),
                  InputArgument.op_Implicit((float) vector3.Y),
                  InputArgument.op_Implicit((float) vector3.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(180),
                  InputArgument.op_Implicit(true)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Scene3)
                  }))
                });
                Game.Player.Character.SetIntoVehicle(this.Seasparrow, (VehicleSeat) -1);
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.Seasparrow),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit("exit_seasparrow"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.Lift),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit("exit_platform"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.HangerDL),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit("exit_l_door"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.DroneCam),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("exit_cam"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.DroneCam),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit("exit_cam"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.HangerDR),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit("exit_r_door"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Script.Wait(8000);
                Game.FadeScreenOut(500);
                Script.Wait(3000);
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                this.DroneCam.Destroy();
                this.SeaSparrowOut = true;
                this.Config.SetValue<bool>("Moonpool", "SeaSparrowOut", (M0) (this.SeaSparrowOut ? 1 : 0));
                this.SeaSparrowDestroyedTimer = 2500;
                this.Config.SetValue<int>("Moonpool", "SeaSparrowDestroyedTimer", (M0) this.SeaSparrowDestroyedTimer);
                this.Config.Save();
                Vector3 offsetInWorldCoords = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, 7f, 8f));
                if (Entity.op_Inequality((Entity) this.Seasparrow, (Entity) null))
                  ((Entity) this.Seasparrow).Delete();
                this.Seasparrow = World.CreateVehicle(this.RequestModel("SEASPARROW2"), offsetInWorldCoords, ((Entity) this.Kosatka).Heading);
                this.Seasparrow.IsDriveable = true;
                ((Entity) this.Seasparrow).IsInvincible = false;
                ((Entity) this.Seasparrow).FreezePosition = false;
                this.Seasparrow.PrimaryColor = this.SeaSparrowPrimaryColor;
                this.Seasparrow.SecondaryColor = this.SeaSparrowSecondaryColor;
                Function.Call((Hash) 2245783831530643834L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(((Entity) this.Seasparrow).Handle),
                  InputArgument.op_Implicit(0)
                });
                this.Seasparrow.SetMod((VehicleMod) 10, this.SeasparrowWeapons, true);
                Game.Player.Character.SetIntoVehicle(this.Seasparrow, (VehicleSeat) -1);
                this.IsInInterior = false;
                Script.Wait(3000);
                Game.FadeScreenIn(500);
              }
            }
            if (((Entity) this.Kosatka).Position.Z < -10.0)
              this.DisplayHelpTextThisFrame("You cannot use this Vehicle while Kosatka is submirged");
          }
          if (Entity.op_Inequality((Entity) this.Avisa, (Entity) null) && Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) this.Avisa))
          {
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use Avisa");
            if (Game.IsControlJustPressed(2, (Control) 51))
            {
              ((Entity) Game.Player.Character).Position = new Vector3(1558.299f, 405.1266f, -54.17f);
              this.DroneCam = World.CreateCamera(new Vector3(1558.299f, 405.1266f, -54.17f), new Vector3(0.0f, 0.0f, -26f), 80f);
              Function.Call((Hash) 569060033405794044L, new InputArgument[5]
              {
                InputArgument.op_Implicit(1),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(3000),
                InputArgument.op_Implicit(1),
                InputArgument.op_Implicit(0)
              });
              World.RenderingCamera = this.DroneCam;
              string dict = "anim@scripted@submarine@vehicle_trans@moonpool";
              KosatkaScript.LoadDict(dict);
              int num1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
              {
                InputArgument.op_Implicit(1561.541f),
                InputArgument.op_Implicit(419.4447f),
                InputArgument.op_Implicit(-55.30978f)
              });
              UI.Notify("If your Avisa is destroyed, you will have to wait for it to respawn");
              ((Entity) this.HatchR01).IsVisible = true;
              ((Entity) this.HatchL01).IsVisible = true;
              ((Entity) this.Avisa).IsVisible = true;
              Function.Call((Hash) 5949884333633149191L, new InputArgument[3]
              {
                InputArgument.op_Implicit(this.HatchR01),
                InputArgument.op_Implicit(num1),
                InputArgument.op_Implicit((int) Function.Call<int>((Hash) 5170871713518273099L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(Game.Player.Character)
                }))
              });
              Function.Call((Hash) 5949884333633149191L, new InputArgument[3]
              {
                InputArgument.op_Implicit(this.HatchL01),
                InputArgument.op_Implicit(num1),
                InputArgument.op_Implicit((int) Function.Call<int>((Hash) 5170871713518273099L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(Game.Player.Character)
                }))
              });
              Function.Call((Hash) 5949884333633149191L, new InputArgument[3]
              {
                InputArgument.op_Implicit(this.Avisa),
                InputArgument.op_Implicit(num1),
                InputArgument.op_Implicit((int) Function.Call<int>((Hash) 5170871713518273099L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(Game.Player.Character)
                }))
              });
              Game.Player.Character.SetIntoVehicle(this.Avisa, (VehicleSeat) -1);
              Vector3 vector3;
              // ISSUE: explicit constructor call
              ((Vector3) ref vector3).\u002Ector(1563.666f, 413.979f, -54.9424f);
              this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
              {
                InputArgument.op_Implicit((float) vector3.X),
                InputArgument.op_Implicit((float) vector3.Y),
                InputArgument.op_Implicit((float) vector3.Z),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(180),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) 7696488426199063767L, new InputArgument[8]
              {
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit((float) vector3.X),
                InputArgument.op_Implicit((float) vector3.Y),
                InputArgument.op_Implicit((float) vector3.Z),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(180),
                InputArgument.op_Implicit(true)
              });
              Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
              {
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(this.Scene3)
                }))
              });
              Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
              {
                InputArgument.op_Implicit(this.Avisa),
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit("avisa_exit_avisa"),
                InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                InputArgument.op_Implicit(16f),
                InputArgument.op_Implicit(-16f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(1148846080)
              });
              Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
              {
                InputArgument.op_Implicit(this.HatchR01),
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit("avisa_exit_hatch_01r"),
                InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                InputArgument.op_Implicit(16f),
                InputArgument.op_Implicit(-16f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(1148846080)
              });
              Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
              {
                InputArgument.op_Implicit(this.HatchL01),
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit("avisa_exit_hatch_01l"),
                InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                InputArgument.op_Implicit(16f),
                InputArgument.op_Implicit(-16f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(1148846080)
              });
              Script.Wait(5000);
              Game.FadeScreenOut(500);
              Script.Wait(3000);
              Function.Call((Hash) 569060033405794044L, new InputArgument[5]
              {
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(3000),
                InputArgument.op_Implicit(1),
                InputArgument.op_Implicit(0)
              });
              this.DroneCam.Destroy();
              this.AvisaOut = true;
              this.Config.SetValue<bool>("Moonpool", "AvisaOut", (M0) (this.AvisaOut ? 1 : 0));
              this.AvisaDestroyedTimer = 2500;
              this.Config.SetValue<int>("Moonpool", "AvisaDestroyedTimer", (M0) this.AvisaDestroyedTimer);
              this.Config.Save();
              Vector3 offsetInWorldCoords = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, -10f, -15f));
              if (Entity.op_Inequality((Entity) this.Avisa, (Entity) null))
                ((Entity) this.Avisa).Delete();
              this.Avisa = World.CreateVehicle(this.RequestModel("AVISA"), offsetInWorldCoords, ((Entity) this.Kosatka).Heading);
              this.Avisa.IsDriveable = true;
              ((Entity) this.Avisa).IsInvincible = false;
              ((Entity) this.Avisa).FreezePosition = false;
              this.Avisa.PrimaryColor = this.AvisaPrimaryColor;
              this.Avisa.SecondaryColor = this.AvisaSecondaryColor;
              this.IsInInterior = false;
              this.IsInInterior = false;
              Game.Player.Character.SetIntoVehicle(this.Avisa, (VehicleSeat) -1);
              Script.Wait(3000);
              Game.FadeScreenIn(500);
            }
          }
          if (Entity.op_Inequality((Entity) this.Toreador, (Entity) null) && Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) this.Toreador))
          {
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use Toreador");
            if (Game.IsControlJustPressed(2, (Control) 51))
            {
              ((Entity) Game.Player.Character).IsVisible = false;
              Game.Player.CanControlCharacter = false;
              Game.Player.Character.Task.WarpOutOfVehicle(this.Toreador);
              ((Entity) Game.Player.Character).Position = new Vector3(1558.299f, 419.4447f, -54.17f);
              this.DroneCam = World.CreateCamera(new Vector3(1558.299f, 419.4447f, -54.17f), new Vector3(0.0f, 0.0f, -115f), 80f);
              Function.Call((Hash) 569060033405794044L, new InputArgument[5]
              {
                InputArgument.op_Implicit(1),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(3000),
                InputArgument.op_Implicit(1),
                InputArgument.op_Implicit(0)
              });
              World.RenderingCamera = this.DroneCam;
              string dict = "anim@scripted@submarine@vehicle_trans@moonpool";
              KosatkaScript.LoadDict(dict);
              int num1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
              {
                InputArgument.op_Implicit(1561.541f),
                InputArgument.op_Implicit(419.7447f),
                InputArgument.op_Implicit(-55.30978f)
              });
              Vector3 vector3;
              // ISSUE: explicit constructor call
              ((Vector3) ref vector3).\u002Ector(1563.666f, 419.3f, -54.9424f);
              this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
              {
                InputArgument.op_Implicit((float) vector3.X),
                InputArgument.op_Implicit((float) vector3.Y),
                InputArgument.op_Implicit((float) vector3.Z),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(180),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) 7696488426199063767L, new InputArgument[8]
              {
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit((float) vector3.X),
                InputArgument.op_Implicit((float) vector3.Y),
                InputArgument.op_Implicit((float) vector3.Z),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(180),
                InputArgument.op_Implicit(true)
              });
              Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
              {
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(this.Scene3)
                }))
              });
              Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
              {
                InputArgument.op_Implicit(this.Toreador),
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                InputArgument.op_Implicit("toreador_exit_toreador"),
                InputArgument.op_Implicit(16f),
                InputArgument.op_Implicit(-16f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(1148846080)
              });
              Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
              {
                InputArgument.op_Implicit(this.Toreador),
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit("toreador_exit_toreador"),
                InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                InputArgument.op_Implicit(16f),
                InputArgument.op_Implicit(-16f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(1148846080)
              });
              Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
              {
                InputArgument.op_Implicit(this.HatchR02),
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit("toreador_exit_hatch_02r"),
                InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                InputArgument.op_Implicit(16f),
                InputArgument.op_Implicit(-16f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(1148846080)
              });
              Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
              {
                InputArgument.op_Implicit(this.HatchL02),
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit("toreador_exit_hatch_02l"),
                InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                InputArgument.op_Implicit(16f),
                InputArgument.op_Implicit(-16f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(1148846080)
              });
              Script.Wait(5000);
              Game.FadeScreenOut(500);
              Script.Wait(3000);
              Function.Call((Hash) 569060033405794044L, new InputArgument[5]
              {
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(3000),
                InputArgument.op_Implicit(1),
                InputArgument.op_Implicit(0)
              });
              this.DroneCam.Destroy();
              ((Entity) Game.Player.Character).IsVisible = true;
              Game.Player.CanControlCharacter = true;
              this.ToreadorOut = true;
              this.Config.SetValue<bool>("Moonpool", "ToreadorOut", (M0) (this.ToreadorOut ? 1 : 0));
              this.ToreadorDestroyedTimer = 2500;
              this.Config.SetValue<int>("Moonpool", "ToreadorDestroyedTimer", (M0) this.ToreadorDestroyedTimer);
              this.Config.Save();
              Vector3 offsetInWorldCoords = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, -10f, -15f));
              if (Entity.op_Inequality((Entity) this.Toreador, (Entity) null))
                ((Entity) this.Toreador).Delete();
              this.Toreador = World.CreateVehicle(this.RequestModel("Toreador"), offsetInWorldCoords, ((Entity) this.Kosatka).Heading);
              this.Toreador.IsDriveable = true;
              ((Entity) this.Toreador).IsInvincible = false;
              ((Entity) this.Toreador).FreezePosition = false;
              this.Toreador.PrimaryColor = this.ToreadorPrimaryColor;
              this.Toreador.SecondaryColor = this.ToreadorSecondaryColor;
              this.IsInInterior = false;
              this.IsInInterior = false;
              Game.Player.Character.SetIntoVehicle(this.Toreador, (VehicleSeat) -1);
              Script.Wait(3000);
              Game.FadeScreenIn(500);
            }
          }
        }
        if (!this.Readocci)
        {
          this.Readocci = true;
          this.CheckOcci("scripts//OpenCommandCenterInteriors.ini");
          this.Gunlockeron = false;
          this.Gunlockeron = (bool) this.CheckOcciConfig.GetValue<bool>("Terrobyte", "TWEAPONS", (M0) (this.Gunlockeron ? 1 : 0));
        }
        if (this.GunmodMenuPool != null && this.GunmodMenuPool.IsAnyMenuOpen())
          this.GunmodMenuPool.ProcessMenus();
        if (this.WeaponsUpgrade == 1 && Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) null))
        {
          if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, this.GunLockerMarker) < 1.35000002384186)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to open Gun Locker");
          if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, this.GunLockerMarker) < 80.0)
            World.DrawMarker((MarkerType) 1, this.GunLockerMarker, Vector3.Zero, Vector3.Zero, new Vector3(0.65f, 0.65f, 0.4f), this.SubmarineMarkerColor);
          if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, this.GunLockerMarker) < 2.0 && Game.IsControlJustPressed(2, (Control) 51) && !this.GunmainMenu.Visible)
            this.GunmainMenu.Visible = !this.GunmainMenu.Visible;
        }
      }
      if (!this.IsInInterior && this.CreatedChairs)
      {
        this.CreatedChairs = false;
        if (Entity.op_Inequality((Entity) this.Chair1, (Entity) null))
          ((Entity) this.Chair1).Delete();
        if (Entity.op_Inequality((Entity) this.Chair2, (Entity) null))
          ((Entity) this.Chair2).Delete();
        if (Entity.op_Inequality((Entity) this.Chair3, (Entity) null))
          ((Entity) this.Chair3).Delete();
        if (Entity.op_Inequality((Entity) this.Chair4, (Entity) null))
          ((Entity) this.Chair4).Delete();
        if (Entity.op_Inequality((Entity) this.Chair5, (Entity) null))
          ((Entity) this.Chair5).Delete();
        if (Entity.op_Inequality((Entity) this.Chair6, (Entity) null))
          ((Entity) this.Chair6).Delete();
        if (Entity.op_Inequality((Entity) this.Chair7, (Entity) null))
          ((Entity) this.Chair7).Delete();
        if (Entity.op_Inequality((Entity) this.Chair8, (Entity) null))
          ((Entity) this.Chair8).Delete();
        if (Entity.op_Inequality((Entity) this.Chair9, (Entity) null))
          ((Entity) this.Chair9).Delete();
        if (Entity.op_Inequality((Entity) this.Chair10, (Entity) null))
          ((Entity) this.Chair10).Delete();
        if (Entity.op_Inequality((Entity) this.Console1, (Entity) null))
          ((Entity) this.Console1).Delete();
        if (Entity.op_Inequality((Entity) this.Console2, (Entity) null))
          ((Entity) this.Console2).Delete();
        if (Entity.op_Inequality((Entity) this.Console3, (Entity) null))
          ((Entity) this.Console3).Delete();
        if (Entity.op_Inequality((Entity) this.PeriscopeProp, (Entity) null))
          ((Entity) this.PeriscopeProp).Delete();
      }
      if (this.IsInInterior)
      {
        if (!this.SittinginSeat)
          ;
        if (this.CreatedChairs)
        {
          if (Entity.op_Inequality((Entity) this.Chair1, (Entity) null))
          {
            if (Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
            {
              InputArgument.op_Implicit(this.Chair1_Scene)
            }) >= 1065353216 && (!this.SittinginSeat2 && this.Chair2WaitingAnim))
              this.SittinginSeat2 = true;
            if (this.SittinginSeat2)
            {
              this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Fire Player Guided Missile, ~INPUT_AIM~ Exit");
              if (!this.IsUsingSam && Game.IsControlJustPressed(2, (Control) 51))
              {
                this.BatteryPercent = 0;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair1 = this.Chair1;
                this.ExitChair = this.Chair1;
                this.Chair1_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("computer_enter"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair1_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("computer_enter"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair1),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("computer_enter_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.Console1),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("computer_enter_console"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Script.Wait(4000);
                this.MissileStationUsing = 1;
                this.IsUsingSam = true;
                this.MissileSpeed = 0.8f;
                this.PilotingMissile = false;
                this.PilotingGuidedMissil3 = false;
                if (Entity.op_Inequality((Entity) this.Missile, (Entity) null))
                  ((Entity) this.Missile).Delete();
                if (Entity.op_Inequality((Entity) this.Missile2, (Entity) null))
                  ((Entity) this.Missile2).Delete();
                if (Entity.op_Inequality((Entity) this.GuidedMissileTarget, (Entity) null))
                  ((Entity) this.GuidedMissileTarget).Delete();
                int num1 = new Random().Next(0, 800);
                Vector3 vector3 = new Vector3();
                Vector3 offsetInWorldCoords1 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -10f, 8f));
                Vector3 offsetInWorldCoords2 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -8f, 8f));
                Vector3 offsetInWorldCoords3 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -6f, 8f));
                Vector3 offsetInWorldCoords4 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -4f, 8f));
                Vector3 offsetInWorldCoords5 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -10f, 8f));
                Vector3 offsetInWorldCoords6 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -8f, 8f));
                Vector3 offsetInWorldCoords7 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -6f, 8f));
                Vector3 offsetInWorldCoords8 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -4f, 8f));
                if (num1 < 100)
                  vector3 = offsetInWorldCoords1;
                if (num1 >= 100 & num1 < 200)
                  vector3 = offsetInWorldCoords2;
                if (num1 >= 200 & num1 < 300)
                  vector3 = offsetInWorldCoords3;
                if (num1 >= 300 & num1 < 400)
                  vector3 = offsetInWorldCoords4;
                if (num1 >= 400 & num1 < 500)
                  vector3 = offsetInWorldCoords5;
                if (num1 >= 500 & num1 < 600)
                  vector3 = offsetInWorldCoords6;
                if (num1 >= 600 & num1 < 700)
                  vector3 = offsetInWorldCoords7;
                if (num1 >= 700 & num1 <= 800)
                  vector3 = offsetInWorldCoords8;
                this.Missile = World.CreateProp(this.RequestModel("h4_prop_h4_mine_01a"), vector3, new Vector3(0.0f, 0.0f, 0.0f), false, false);
                ((Entity) this.Missile).AddBlip();
                ((Entity) this.Missile).CurrentBlip.Sprite = (BlipSprite) 548;
                this.Missile2 = World.CreateProp(this.RequestModel("h4_prop_h4_airmissile_01a"), vector3, new Vector3(0.0f, 0.0f, 0.0f), false, false);
                this.GuidedMissileTarget = World.CreateProp(this.RequestModel("h4_prop_h4_mine_01a"), ((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 12f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
                this.TargetPos = ((Entity) this.GuidedMissileTarget).Position;
                this.ReachedZCoord = false;
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                ((Entity) Game.Player.Character).IsInvincible = false;
                ((Entity) Game.Player.Character).IsVisible = true;
                if (Camera.op_Inequality(this.DroneCam, (Camera) null))
                  this.DroneCam.Destroy();
                this.UsingPeriscope = false;
                this.DroneCam = World.CreateCamera(((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 12f)), new Vector3(0.0f, 0.0f, 0.0f), 60f);
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                World.RenderingCamera = this.DroneCam;
                this.PilotingGuidedMissil3 = true;
              }
              if (this.SittinginSeat2 && Game.IsControlJustPressed(2, (Control) 25))
              {
                this.Chair2WaitingAnim = false;
                Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
                this.PlayingConsoleIdleAnim_1 = false;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair1 = this.Chair1;
                this.Chair1_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("exit_left"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair1_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("exit_left"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair1),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("exit_left_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Script.Wait(3000);
                Game.Player.Character.Task.ClearAll();
                this.SittinginSeat2 = false;
              }
            }
            if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, ((Entity) this.Chair1).GetOffsetInWorldCoords(new Vector3(0.0f, 1f, 0.0f))) >= 1.0)
              ;
            if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, ((Entity) this.Chair1).GetOffsetInWorldCoords(new Vector3(0.0f, 1f, 0.0f))) < 1.0)
            {
              if (!this.SittinginSeat2)
                this.DisplayHelpTextThisFrame("Press ~INPUT_AIM~ to Sit on Seat");
              if (Game.IsControlJustPressed(2, (Control) 25) && !this.SittinginSeat2)
              {
                Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
                this.PlayingConsoleIdleAnim_1 = false;
                Script.Wait(100);
                this.Chair2WaitingAnim = true;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair1 = this.Chair1;
                this.ExitChair = this.Chair1;
                this.Chair1_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair1).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("enter_left"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair1_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("enter_left"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair1),
                  InputArgument.op_Implicit(this.Chair1_Scene),
                  InputArgument.op_Implicit("enter_left_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
              }
            }
          }
          if (Entity.op_Inequality((Entity) this.Chair2, (Entity) null))
          {
            if (Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
            {
              InputArgument.op_Implicit(this.Chair2_Scene)
            }) >= 1065353216 && (!this.SittinginSeat1 && this.Chair1WaitingAnim))
              this.SittinginSeat1 = true;
            if (this.SittinginSeat1)
            {
              this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Fire Player Guided Missile, ~INPUT_AIM~ Exit");
              if (!this.IsUsingSam && Game.IsControlJustPressed(2, (Control) 51))
              {
                this.BatteryPercent = 0;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair2 = this.Chair2;
                this.ExitChair = this.Chair2;
                this.Chair2_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("computer_enter"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair2_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("computer_enter"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair2),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("computer_enter_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.Console2),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("computer_enter_console"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Script.Wait(4000);
                this.MissileStationUsing = 2;
                this.IsUsingSam = true;
                this.MissileSpeed = 0.8f;
                this.PilotingMissile = false;
                this.PilotingGuidedMissil3 = false;
                if (Entity.op_Inequality((Entity) this.Missile, (Entity) null))
                  ((Entity) this.Missile).Delete();
                if (Entity.op_Inequality((Entity) this.Missile2, (Entity) null))
                  ((Entity) this.Missile2).Delete();
                if (Entity.op_Inequality((Entity) this.GuidedMissileTarget, (Entity) null))
                  ((Entity) this.GuidedMissileTarget).Delete();
                int num1 = new Random().Next(0, 800);
                Vector3 vector3 = new Vector3();
                Vector3 offsetInWorldCoords1 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -10f, 8f));
                Vector3 offsetInWorldCoords2 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -8f, 8f));
                Vector3 offsetInWorldCoords3 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -6f, 8f));
                Vector3 offsetInWorldCoords4 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(1.6f, -4f, 8f));
                Vector3 offsetInWorldCoords5 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -10f, 8f));
                Vector3 offsetInWorldCoords6 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -8f, 8f));
                Vector3 offsetInWorldCoords7 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -6f, 8f));
                Vector3 offsetInWorldCoords8 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(-1.6f, -4f, 8f));
                if (num1 < 100)
                  vector3 = offsetInWorldCoords1;
                if (num1 >= 100 & num1 < 200)
                  vector3 = offsetInWorldCoords2;
                if (num1 >= 200 & num1 < 300)
                  vector3 = offsetInWorldCoords3;
                if (num1 >= 300 & num1 < 400)
                  vector3 = offsetInWorldCoords4;
                if (num1 >= 400 & num1 < 500)
                  vector3 = offsetInWorldCoords5;
                if (num1 >= 500 & num1 < 600)
                  vector3 = offsetInWorldCoords6;
                if (num1 >= 600 & num1 < 700)
                  vector3 = offsetInWorldCoords7;
                if (num1 >= 700 & num1 <= 800)
                  vector3 = offsetInWorldCoords8;
                this.Missile = World.CreateProp(this.RequestModel("h4_prop_h4_mine_01a"), vector3, new Vector3(0.0f, 0.0f, 0.0f), false, false);
                ((Entity) this.Missile).AddBlip();
                ((Entity) this.Missile).CurrentBlip.Sprite = (BlipSprite) 548;
                this.Missile2 = World.CreateProp(this.RequestModel("h4_prop_h4_airmissile_01a"), vector3, new Vector3(0.0f, 0.0f, 0.0f), false, false);
                this.GuidedMissileTarget = World.CreateProp(this.RequestModel("h4_prop_h4_mine_01a"), ((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 12f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
                this.TargetPos = ((Entity) this.GuidedMissileTarget).Position;
                this.ReachedZCoord = false;
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                ((Entity) Game.Player.Character).IsInvincible = false;
                ((Entity) Game.Player.Character).IsVisible = true;
                if (Camera.op_Inequality(this.DroneCam, (Camera) null))
                  this.DroneCam.Destroy();
                this.UsingPeriscope = false;
                this.DroneCam = World.CreateCamera(((Entity) this.Missile).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 12f)), new Vector3(0.0f, 0.0f, 0.0f), 60f);
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                World.RenderingCamera = this.DroneCam;
                this.PilotingGuidedMissil3 = true;
              }
              if (this.SittinginSeat1 && Game.IsControlJustPressed(2, (Control) 25))
              {
                this.Chair1WaitingAnim = false;
                Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
                this.PlayingConsoleIdleAnim_2 = false;
                this.SittinginSeat1 = false;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair2 = this.Chair2;
                this.Chair2_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("exit_left"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair2_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("exit_left"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair2),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("exit_left_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Script.Wait(3000);
                Game.Player.Character.Task.ClearAll();
              }
            }
            if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, ((Entity) this.Chair2).GetOffsetInWorldCoords(new Vector3(0.0f, 1f, 0.0f))) >= 1.0)
              ;
            if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, ((Entity) this.Chair2).GetOffsetInWorldCoords(new Vector3(0.0f, 1f, 0.0f))) < 1.0)
            {
              if (!this.SittinginSeat1)
                this.DisplayHelpTextThisFrame("Press ~INPUT_AIM~ to Sit on Seat");
              if (Game.IsControlJustPressed(2, (Control) 25) && !this.SittinginSeat1)
              {
                Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
                this.PlayingConsoleIdleAnim_2 = false;
                Script.Wait(100);
                this.Chair1WaitingAnim = true;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair2 = this.Chair2;
                this.ExitChair = this.Chair2;
                this.Chair2_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair2).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("enter_left"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair2_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("enter_left"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair2),
                  InputArgument.op_Implicit(this.Chair2_Scene),
                  InputArgument.op_Implicit("enter_left_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
              }
            }
          }
          if (Entity.op_Inequality((Entity) this.Chair8, (Entity) null) && (double) World.GetDistance(((Entity) Game.Player.Character).Position, ((Entity) this.Chair8).Position) < 1.35000002384186)
          {
            if (!this.SittinginSeat)
              this.DisplayHelpTextThisFrame("Press ~INPUT_AIM~ to Sit on Seat");
            if (this.SittinginSeat)
            {
              this.DisplayHelpTextThisFrame("Press ~INPUT_AIM~ Exit, ~INPUT_VEH_Exit~ Drive Kosotka, ~INPUT_CONTEXT~ To use Fast Travel");
              if (this.PlayingConsoleIdleAnim_8)
              {
                if (Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(this.Chair8_Scene)
                }) >= 1065353216)
                {
                  string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                  KosatkaScript.LoadDict(dict);
                  Prop chair8 = this.Chair8;
                  this.ExitChair = this.Chair8;
                  Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                  {
                    InputArgument.op_Implicit(Game.Player.Character),
                    InputArgument.op_Implicit(this.Chair8_Scene),
                    InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                    InputArgument.op_Implicit("computer_idle"),
                    InputArgument.op_Implicit(16f),
                    InputArgument.op_Implicit(-16f),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(1148846080)
                  });
                  Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                  {
                    InputArgument.op_Implicit(Game.Player.Character),
                    InputArgument.op_Implicit(this.Chair8_Scene),
                    InputArgument.op_Implicit("computer_idle"),
                    InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                    InputArgument.op_Implicit(16f),
                    InputArgument.op_Implicit(-16f),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(1148846080)
                  });
                  Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                  {
                    InputArgument.op_Implicit(this.Console3),
                    InputArgument.op_Implicit(this.Chair8_Scene),
                    InputArgument.op_Implicit("idle_a_console"),
                    InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                    InputArgument.op_Implicit(16f),
                    InputArgument.op_Implicit(-16f),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(1148846080)
                  });
                }
              }
              if (Game.IsControlJustPressed(2, (Control) 75))
              {
                Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
                if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
                {
                  ((Entity) this.Kosatka).Delete();
                  Script.Wait(500);
                  this.SpawnMOC();
                  Script.Wait(500);
                  this.Spawn = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, -54.8f, 3.8f));
                }
                this.IsInInterior = false;
                Game.Player.Character.SetIntoVehicle(this.Kosatka, (VehicleSeat) -1);
              }
              if (this.mainMenu2.Visible && (Game.IsControlJustPressed(2, (Control) 200) || Game.IsControlJustPressed(2, (Control) 177)))
                this.PlayingConsoleIdleAnim_8 = false;
              if (Game.IsControlJustPressed(2, (Control) 51))
              {
                Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
                this.PlayingConsoleIdleAnim_8 = true;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair8 = this.Chair8;
                this.ExitChair = this.Chair8;
                this.Chair8_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair8).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair8).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair8).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair8).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair8_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("computer_enter"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair8_Scene),
                  InputArgument.op_Implicit("computer_enter"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(this.Console3),
                  InputArgument.op_Implicit(this.Chair8_Scene),
                  InputArgument.op_Implicit("enter_console"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                if (!this.mainMenu2.Visible)
                  this.mainMenu2.Visible = !this.mainMenu2.Visible;
              }
            }
            if (Game.IsControlJustPressed(2, (Control) 25))
            {
              if (!this.SittinginSeat)
              {
                Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
                this.PlayingConsoleIdleAnim_8 = false;
                this.SittinginSeat = true;
                this.SittinginSeat1 = false;
                this.SittinginSeat2 = false;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair8 = this.Chair8;
                this.ExitChair = this.Chair8;
                this.Chair8_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair8).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair8).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair8).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair8).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair8_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("enter_left"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair8_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair8_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair8_Scene),
                  InputArgument.op_Implicit("enter_left"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair8),
                  InputArgument.op_Implicit(this.Chair8_Scene),
                  InputArgument.op_Implicit("enter_left_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
              }
              else if (this.SittinginSeat)
              {
                Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
                this.PlayingConsoleIdleAnim_8 = false;
                this.SittinginSeat = false;
                this.SittinginSeat1 = false;
                this.SittinginSeat2 = false;
                string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
                KosatkaScript.LoadDict(dict);
                Prop chair8 = this.Chair8;
                this.Chair8_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) ((Entity) chair8).Position.X),
                  InputArgument.op_Implicit((float) ((Entity) chair8).Position.Y),
                  InputArgument.op_Implicit((float) ((Entity) chair8).Position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) chair8).Rotation.Z),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair8_Scene),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("exit_left"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Chair8_Scene),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Chair8_Scene)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Chair8_Scene),
                  InputArgument.op_Implicit("exit_left"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(chair8),
                  InputArgument.op_Implicit(this.Chair8_Scene),
                  InputArgument.op_Implicit("exit_left_chair"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Script.Wait(3000);
                Game.Player.Character.Task.ClearAll();
              }
            }
          }
        }
      }
      if (this.IsInInterior && !this.CreatedChairs && !this.IsUsingSam)
      {
        this.CreatedChairs = true;
        if (Entity.op_Inequality((Entity) this.Chair1, (Entity) null))
          ((Entity) this.Chair1).Delete();
        if (Entity.op_Inequality((Entity) this.Chair2, (Entity) null))
          ((Entity) this.Chair2).Delete();
        if (Entity.op_Inequality((Entity) this.Chair3, (Entity) null))
          ((Entity) this.Chair3).Delete();
        if (Entity.op_Inequality((Entity) this.Chair4, (Entity) null))
          ((Entity) this.Chair4).Delete();
        if (Entity.op_Inequality((Entity) this.Chair5, (Entity) null))
          ((Entity) this.Chair5).Delete();
        if (Entity.op_Inequality((Entity) this.Chair6, (Entity) null))
          ((Entity) this.Chair6).Delete();
        if (Entity.op_Inequality((Entity) this.Chair7, (Entity) null))
          ((Entity) this.Chair7).Delete();
        if (Entity.op_Inequality((Entity) this.Chair8, (Entity) null))
          ((Entity) this.Chair8).Delete();
        if (Entity.op_Inequality((Entity) this.Chair9, (Entity) null))
          ((Entity) this.Chair9).Delete();
        if (Entity.op_Inequality((Entity) this.Chair10, (Entity) null))
          ((Entity) this.Chair10).Delete();
        if (Entity.op_Inequality((Entity) this.Console1, (Entity) null))
          ((Entity) this.Console1).Delete();
        if (Entity.op_Inequality((Entity) this.Console2, (Entity) null))
          ((Entity) this.Console2).Delete();
        if (Entity.op_Inequality((Entity) this.Console3, (Entity) null))
          ((Entity) this.Console3).Delete();
        this.Chair1 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_02"), new Vector3(1558.718f, 388.6768f, -50.68f), new Vector3(0.0f, 0.0f, -90f), false, false);
        ((Entity) this.Chair1).FreezePosition = true;
        this.Chair2 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_02"), new Vector3(1558.765f, 387.4181f, -50.68f), new Vector3(0.0f, 0.0f, -90f), false, false);
        ((Entity) this.Chair2).FreezePosition = true;
        this.Chair3 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1558.862f, 385.974f, -50.68f), new Vector3(0.0f, 0.0f, -90f), false, false);
        ((Entity) this.Chair3).FreezePosition = true;
        this.Chair4 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1558.751f, 384.6591f, -50.68f), new Vector3(0.0f, 0.0f, -90f), false, false);
        ((Entity) this.Chair4).FreezePosition = true;
        this.Chair5 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1558.74f, 383.2693f, -50.68727f), new Vector3(0.0f, 0.0f, -90f), false, false);
        ((Entity) this.Chair5).FreezePosition = true;
        this.Chair7 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1558.801f, 382.0339f, -50.68f), new Vector3(0.0f, 0.0f, -90f), false, false);
        ((Entity) this.Chair7).FreezePosition = true;
        this.Chair8 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_02"), new Vector3(1559.427f, 381.3182f, -50.68f), new Vector3(0.0f, 0.0f, 0.0f), false, false);
        ((Entity) this.Chair8).FreezePosition = true;
        this.Chair9 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1564.07f, 386.1208f, -50.68f), new Vector3(0.0f, 0.0f, 98f), false, false);
        ((Entity) this.Chair9).FreezePosition = true;
        this.Chair10 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1564.01f, 384.9416f, -50.68727f), new Vector3(0.0f, 0.0f, 90f), false, false);
        ((Entity) this.Chair10).FreezePosition = true;
        int num1 = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit(1561.541f),
          InputArgument.op_Implicit(419.4447f),
          InputArgument.op_Implicit(-55.30978f)
        });
        this.Console1 = World.CreateProp(this.RequestModel("h4_prop_h4_console_01a"), new Vector3(1557.958f, 388.6993f, -49.93543f), new Vector3(0.0f, 0.0f, 90f), false, false);
        this.Console2 = World.CreateProp(this.RequestModel("h4_prop_h4_console_01a"), new Vector3(1557.958f, 387.3052f, -49.93543f), new Vector3(0.0f, 0.0f, 90f), false, false);
        this.Console3 = World.CreateProp(this.RequestModel("h4_prop_h4_console_01a"), new Vector3(1559.388f, 380.5829f, -49.93543f), new Vector3(0.0f, 0.0f, 180f), false, false);
        foreach (Prop chest in this.Chests)
        {
          if (Entity.op_Inequality((Entity) chest, (Entity) null))
            ((Entity) chest).Delete();
        }
        if (this.ShowTreasureCollectioninSub)
        {
          Prop prop1 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), new Vector3(1563.3f, 400.4742f, -50.6f), new Vector3(0.0f, 0.0f, 0.0f), true, false);
          this.Chests.Add(prop1);
          ((Entity) prop1).IsVisible = false;
          ((Entity) prop1).FreezePosition = true;
          if (this.ChestCollected >= 1 && this.ChestCollected < 7)
            ((Entity) prop1).IsVisible = true;
          if (this.ChestCollected >= 2 && this.ChestCollected < 16)
          {
            Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, 0.0f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop2);
            ((Entity) prop2).FreezePosition = true;
          }
          if (this.ChestCollected >= 3)
          {
            Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(-0.5f, 0.0f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop2);
            ((Entity) prop2).FreezePosition = true;
          }
          if (this.ChestCollected >= 4)
          {
            Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, 0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop2);
            ((Entity) prop2).FreezePosition = true;
          }
          if (this.ChestCollected >= 5 && this.ChestCollected < 24)
          {
            Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, -0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop2);
            ((Entity) prop2).FreezePosition = true;
          }
          if (this.ChestCollected >= 6)
          {
            Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a_land"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, 0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
            Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, 0.3f, 0.05f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop2);
            ((Entity) prop2).FreezePosition = true;
            this.Chests.Add(prop3);
            ((Entity) prop3).FreezePosition = true;
          }
          if (this.ChestCollected >= 7)
          {
            Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop2);
            ((Entity) prop2).FreezePosition = true;
          }
          if (this.ChestCollected >= 9)
          {
            Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(-0.5f, 0.0f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop2);
            ((Entity) prop2).FreezePosition = true;
            Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(-0.5f, 0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop3);
            ((Entity) prop3).FreezePosition = true;
          }
          if (this.ChestCollected >= 11)
          {
            Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, 0.6f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop2);
            ((Entity) prop2).FreezePosition = true;
            Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a_land"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, 0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
            Prop prop4 = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, 0.3f, 0.23f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop3);
            ((Entity) prop3).FreezePosition = true;
            this.Chests.Add(prop4);
            ((Entity) prop4).FreezePosition = true;
          }
          if (this.ChestCollected >= 12 && this.ChestCollected < 24)
          {
            Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, -0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop2);
            ((Entity) prop2).FreezePosition = true;
          }
          if (this.ChestCollected >= 13)
          {
            Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a_land"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, 0.0f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
            Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, 0.0f, 0.23f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop2);
            ((Entity) prop2).FreezePosition = true;
            this.Chests.Add(prop3);
            ((Entity) prop3).FreezePosition = true;
          }
          if (this.ChestCollected >= 16)
          {
            Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, 0.0f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop2);
            ((Entity) prop2).FreezePosition = true;
            Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, 0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop3);
            ((Entity) prop3).FreezePosition = true;
            Prop prop4 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, 0.0f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop4);
            ((Entity) prop4).FreezePosition = true;
          }
          if (this.ChestCollected >= 18)
          {
            Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a_land"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, 0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
            Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, 0.3f, 0.23f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop2);
            ((Entity) prop2).FreezePosition = true;
            this.Chests.Add(prop3);
            ((Entity) prop3).FreezePosition = true;
          }
          if (this.ChestCollected >= 24)
          {
            Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, -0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop2);
            ((Entity) prop2).FreezePosition = true;
            Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, -0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop3);
            ((Entity) prop3).FreezePosition = true;
            Prop prop4 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, -0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop4);
            ((Entity) prop4).FreezePosition = true;
            Prop prop5 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, -0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop5);
            ((Entity) prop5).FreezePosition = true;
            Prop prop6 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(-0.5f, -0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop6);
            ((Entity) prop6).FreezePosition = true;
            Prop prop7 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(-1f, -0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop7);
            ((Entity) prop7).FreezePosition = true;
          }
          if (this.ChestCollected >= 26)
          {
            Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, -0.3f, 0.36f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop2);
            ((Entity) prop2).FreezePosition = true;
            Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a_land"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, -0.3f, 0.36f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
            Prop prop4 = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, -0.3f, 0.41f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
            this.Chests.Add(prop3);
            ((Entity) prop3).FreezePosition = true;
            this.Chests.Add(prop4);
            ((Entity) prop4).FreezePosition = true;
          }
        }
      }
      if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
      {
        if (Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) null))
          this.IsInCab = false;
        if (Entity.op_Inequality((Entity) Game.Player.Character.CurrentVehicle, (Entity) null) && Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) this.Kosatka) && !this.IsInCab)
        {
          this.IsInCab = true;
          this.Kosatka.IsDriveable = true;
        }
      }
      this.OnKeyDown();
      if (this.modMenuPool != null && this.modMenuPool.IsAnyMenuOpen())
        this.modMenuPool.ProcessMenus();
      if (this.modMenuPool2 != null && this.modMenuPool2.IsAnyMenuOpen())
        this.modMenuPool2.ProcessMenus();
      if (!Entity.op_Equality((Entity) this.Kosatka, (Entity) null))
        ;
      if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
      {
        if (this.UsingInteriorPeriscope)
        {
          if ((Game.IsControlJustPressed(2, (Control) 51) && Game.CurrentInputMode == null || Game.IsControlJustPressed(2, (Control) 44) && Game.CurrentInputMode == 1) && this.UsingInteriorPeriscope)
          {
            Function.Call((Hash) 569060033405794044L, new InputArgument[5]
            {
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(3000),
              InputArgument.op_Implicit(1),
              InputArgument.op_Implicit(0)
            });
            ((Entity) Game.Player.Character).IsInvincible = false;
            ((Entity) Game.Player.Character).IsVisible = true;
            this.DroneCam.Destroy();
            this.UsingPeriscope = false;
            ((Entity) Game.Player.Character).IsVisible = true;
            ((Entity) Game.Player.Character).FreezePosition = false;
            KosatkaScript.LoadDict("anim@scripted@submarine@ig17_sub_periscope@male@");
            Vector3 vector3;
            // ISSUE: explicit constructor call
            ((Vector3) ref vector3).\u002Ector(0.0f, 0.0f, 180f);
            Vector3 position1 = ((Entity) this.PeriscopeProp).Position;
            Game.Player.Character.AlwaysKeepTask = true;
            this.Scene2 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
            {
              InputArgument.op_Implicit((float) position1.X),
              InputArgument.op_Implicit((float) position1.Y),
              InputArgument.op_Implicit((float) position1.Z),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit((float) vector3.Z),
              InputArgument.op_Implicit(2)
            });
            Function.Call((Hash) 7696488426199063767L, new InputArgument[8]
            {
              InputArgument.op_Implicit(this.Scene2),
              InputArgument.op_Implicit((float) position1.X),
              InputArgument.op_Implicit((float) position1.Y),
              InputArgument.op_Implicit((float) position1.Z),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit((float) vector3.Z),
              InputArgument.op_Implicit(true)
            });
            Function.Call((Hash) -1249422255215503276L, new InputArgument[10]
            {
              InputArgument.op_Implicit(this.PeriscopeProp),
              InputArgument.op_Implicit(this.Scene2),
              InputArgument.op_Implicit("anim@scripted@submarine@ig17_sub_periscope@male@"),
              InputArgument.op_Implicit("exit_periscope"),
              InputArgument.op_Implicit(1000.0),
              InputArgument.op_Implicit(-4.0),
              InputArgument.op_Implicit(128),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1148846080),
              InputArgument.op_Implicit(0)
            });
            Function.Call((Hash) -4073751461268206970L, new InputArgument[10]
            {
              InputArgument.op_Implicit(this.PeriscopeProp),
              InputArgument.op_Implicit(this.Scene2),
              InputArgument.op_Implicit("exit_periscope"),
              InputArgument.op_Implicit(KosatkaScript.LoadDict("anim@scripted@submarine@ig17_sub_periscope@male@")),
              InputArgument.op_Implicit(1000.0),
              InputArgument.op_Implicit(-8f),
              InputArgument.op_Implicit(-8f),
              InputArgument.op_Implicit((float) (vector3.Z + 180.0)),
              InputArgument.op_Implicit(1148846080),
              InputArgument.op_Implicit(0)
            });
            Function.Call((Hash) -1249422255215503276L, new InputArgument[10]
            {
              InputArgument.op_Implicit(Game.Player.Character),
              InputArgument.op_Implicit(this.Scene2),
              InputArgument.op_Implicit("anim@scripted@submarine@ig17_sub_periscope@male@"),
              InputArgument.op_Implicit("exit_male"),
              InputArgument.op_Implicit(1000.0),
              InputArgument.op_Implicit(-4.0),
              InputArgument.op_Implicit(128),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1148846080),
              InputArgument.op_Implicit(0)
            });
            Function.Call((Hash) -4073751461268206970L, new InputArgument[10]
            {
              InputArgument.op_Implicit(Game.Player.Character),
              InputArgument.op_Implicit(this.Scene2),
              InputArgument.op_Implicit("exit_male"),
              InputArgument.op_Implicit(KosatkaScript.LoadDict("anim@scripted@submarine@ig17_sub_periscope@male@")),
              InputArgument.op_Implicit(1000.0),
              InputArgument.op_Implicit(-8f),
              InputArgument.op_Implicit(-8f),
              InputArgument.op_Implicit((float) (vector3.Z + 180.0)),
              InputArgument.op_Implicit(1148846080),
              InputArgument.op_Implicit(0)
            });
          }
          if (Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
          {
            InputArgument.op_Implicit(this.Scene2)
          }) >= 1065353216)
          {
            this.UsingInteriorPeriscope = false;
            Game.Player.Character.Task.ClearAll();
            return;
          }
        }
        else if (!this.UsingInteriorPeriscope)
        {
          if (Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
          {
            InputArgument.op_Implicit(this.PeriscopeScene1)
          }) >= 1065353216)
          {
            if (!this.CanUseInteriorPeriscope)
              ;
            return;
          }
        }
        if (this.IsInInterior && Entity.op_Inequality((Entity) this.PeriscopeProp, (Entity) null) && (double) World.GetDistance(((Entity) Game.Player.Character).Position, ((Entity) this.PeriscopeProp).Position) < 2.0)
        {
          if (Game.CurrentInputMode == 1)
            this.DisplayHelpTextThisFrame("Press ~INPUT_COVER~ to use Periscope");
          if (Game.CurrentInputMode == 0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to use Periscope");
          if (((Entity) this.Kosatka).Position.Z > -14.0 && ((Game.IsControlJustPressed(2, (Control) 51) && Game.CurrentInputMode == null || Game.IsControlJustPressed(2, (Control) 44) && Game.CurrentInputMode == 1) && !this.UsingInteriorPeriscope))
          {
            if (Entity.op_Inequality((Entity) this.PeriscopeProp, (Entity) null))
              ((Entity) this.PeriscopeProp).Delete();
            this.PeriscopeProp = World.CreateProp(this.RequestModel("h4_int_lev_sub_periscope"), new Vector3(1561.519f, 388.7829f, -48.59f), new Vector3(0.0f, 0.0f, 180f), false, false);
            KosatkaScript.LoadDict("anim@scripted@submarine@ig17_sub_periscope@male@");
            Vector3 vector3;
            // ISSUE: explicit constructor call
            ((Vector3) ref vector3).\u002Ector(0.0f, 0.0f, 180f);
            Vector3 position1 = ((Entity) this.PeriscopeProp).Position;
            Game.Player.Character.AlwaysKeepTask = true;
            this.PeriscopeScene1 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
            {
              InputArgument.op_Implicit((float) position1.X),
              InputArgument.op_Implicit((float) position1.Y),
              InputArgument.op_Implicit((float) position1.Z),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit((float) vector3.Z),
              InputArgument.op_Implicit(2)
            });
            Function.Call((Hash) 7696488426199063767L, new InputArgument[8]
            {
              InputArgument.op_Implicit(this.PeriscopeScene1),
              InputArgument.op_Implicit((float) position1.X),
              InputArgument.op_Implicit((float) position1.Y),
              InputArgument.op_Implicit((float) position1.Z),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit((float) vector3.Z),
              InputArgument.op_Implicit(true)
            });
            Function.Call((Hash) -1249422255215503276L, new InputArgument[10]
            {
              InputArgument.op_Implicit(this.PeriscopeProp),
              InputArgument.op_Implicit(this.PeriscopeScene1),
              InputArgument.op_Implicit("anim@scripted@submarine@ig17_sub_periscope@male@"),
              InputArgument.op_Implicit("enter_periscope"),
              InputArgument.op_Implicit(1000.0),
              InputArgument.op_Implicit(-4.0),
              InputArgument.op_Implicit(128),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1148846080),
              InputArgument.op_Implicit(0)
            });
            Function.Call((Hash) -4073751461268206970L, new InputArgument[10]
            {
              InputArgument.op_Implicit(this.PeriscopeProp),
              InputArgument.op_Implicit(this.PeriscopeScene1),
              InputArgument.op_Implicit("enter_periscope"),
              InputArgument.op_Implicit(KosatkaScript.LoadDict("anim@scripted@submarine@ig17_sub_periscope@male@")),
              InputArgument.op_Implicit(1000.0),
              InputArgument.op_Implicit(-8f),
              InputArgument.op_Implicit(-8f),
              InputArgument.op_Implicit((float) (vector3.Z + 180.0)),
              InputArgument.op_Implicit(1148846080),
              InputArgument.op_Implicit(0)
            });
            Function.Call((Hash) -1249422255215503276L, new InputArgument[10]
            {
              InputArgument.op_Implicit(Game.Player.Character),
              InputArgument.op_Implicit(this.PeriscopeScene1),
              InputArgument.op_Implicit("anim@scripted@submarine@ig17_sub_periscope@male@"),
              InputArgument.op_Implicit("enter_male"),
              InputArgument.op_Implicit(1000.0),
              InputArgument.op_Implicit(-4.0),
              InputArgument.op_Implicit(128),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1148846080),
              InputArgument.op_Implicit(0)
            });
            Function.Call((Hash) -4073751461268206970L, new InputArgument[10]
            {
              InputArgument.op_Implicit(Game.Player.Character),
              InputArgument.op_Implicit(this.PeriscopeScene1),
              InputArgument.op_Implicit("enter_male"),
              InputArgument.op_Implicit(KosatkaScript.LoadDict("anim@scripted@submarine@ig17_sub_periscope@male@")),
              InputArgument.op_Implicit(1000.0),
              InputArgument.op_Implicit(-8f),
              InputArgument.op_Implicit(-8f),
              InputArgument.op_Implicit((float) (vector3.Z + 180.0)),
              InputArgument.op_Implicit(1148846080),
              InputArgument.op_Implicit(0)
            });
            Script.Wait(4000);
            Vector3 offsetInWorldCoords = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.8f, 25.5f, 13.5f));
            ((Entity) Game.Player.Character).Position = offsetInWorldCoords;
            ((Entity) Game.Player.Character).IsVisible = false;
            ((Entity) Game.Player.Character).FreezePosition = true;
            this.PeriscopeMode = 2;
            this.DroneCam = World.CreateCamera(offsetInWorldCoords, new Vector3(0.0f, 0.0f, ((Entity) this.Kosatka).Heading), 30f);
            Function.Call((Hash) 569060033405794044L, new InputArgument[5]
            {
              InputArgument.op_Implicit(1),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(3000),
              InputArgument.op_Implicit(1),
              InputArgument.op_Implicit(0)
            });
            World.RenderingCamera = this.DroneCam;
            this.UsingPeriscope = true;
            this.UsingInteriorPeriscope = true;
          }
          if (((Entity) this.Kosatka).Position.Z < -14.0)
            this.DisplayHelpTextThisFrame("Cannot Use Periscope While Submerged");
        }
      }
      if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
      {
        if (!this.IsInInterior)
          this.CanUseInteriorPeriscope = false;
        if ((double) this.Kosatka.Speed < 10.0 && Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) null))
        {
          Vector3 offsetInWorldCoords1 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, -54.8f, 3.8f));
          if (!this.IsInInterior)
          {
            if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, offsetInWorldCoords1) < 200.0)
              World.DrawMarker((MarkerType) 1, offsetInWorldCoords1, Vector3.Zero, Vector3.Zero, new Vector3(0.65f, 0.65f, 0.65f), this.SubmarineMarkerColor);
            if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, offsetInWorldCoords1) < 2.0)
            {
              this.DisplayHelpTextThisFrame("Press ~INPUT_VEH_EXIT~ to Drive Vehicle, ~INPUT_CONTEXT~ to Enter Vehicle Interior");
              if (Game.IsControlJustPressed(2, (Control) 51))
              {
                try
                {
                  string dict = "anim@scripted@submarine@ig26_submarine_enter@male@";
                  KosatkaScript.LoadDict(dict);
                  Prop exitChair = this.ExitChair;
                  KosatkaScript.LoadDict(dict);
                  Vector3 position1 = ((Entity) this.Kosatka).Position;
                  this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                  {
                    InputArgument.op_Implicit((float) position1.X),
                    InputArgument.op_Implicit((float) position1.Y),
                    InputArgument.op_Implicit((float) position1.Z),
                    InputArgument.op_Implicit(0.0),
                    InputArgument.op_Implicit(0.0),
                    InputArgument.op_Implicit((float) ((Entity) this.Kosatka).Rotation.Z),
                    InputArgument.op_Implicit(2)
                  });
                  Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                  {
                    InputArgument.op_Implicit(Game.Player.Character),
                    InputArgument.op_Implicit(this.Scene3),
                    InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                    InputArgument.op_Implicit("submarine_enter"),
                    InputArgument.op_Implicit(16f),
                    InputArgument.op_Implicit(-16f),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(1148846080)
                  });
                  Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                  {
                    InputArgument.op_Implicit(this.Scene3),
                    InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                    {
                      InputArgument.op_Implicit(this.Scene3)
                    }))
                  });
                  Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                  {
                    InputArgument.op_Implicit(Game.Player.Character),
                    InputArgument.op_Implicit(this.Scene3),
                    InputArgument.op_Implicit("submarine_enter"),
                    InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                    InputArgument.op_Implicit(16f),
                    InputArgument.op_Implicit(-16f),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(1148846080)
                  });
                  Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                  {
                    InputArgument.op_Implicit(this.Kosatka),
                    InputArgument.op_Implicit(this.Scene3),
                    InputArgument.op_Implicit("submarine_enter_kosatka"),
                    InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                    InputArgument.op_Implicit(16f),
                    InputArgument.op_Implicit(-16f),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(1148846080)
                  });
                  Script.Wait(3000);
                  this.MOCPosSave = ((Entity) this.Kosatka).Position;
                  Game.FadeScreenOut(3200);
                  Script.Wait(3000);
                  this.X = (float) offsetInWorldCoords1.X;
                  this.Config.SetValue<float>("Setup", "X", (M0) (double) this.X);
                  this.Y = (float) offsetInWorldCoords1.Y;
                  this.Config.SetValue<float>("Setup", "Y", (M0) (double) this.Y);
                  this.Z = (float) offsetInWorldCoords1.Z;
                  this.Config.SetValue<float>("Setup", "Z", (M0) (double) this.Z);
                  this.Config.SetValue<Vector3>("Setup", "SavePosition", (M0) this.MOCPosSave);
                  this.Config.Save();
                  this.VHeading = ((Entity) this.Kosatka).Heading;
                  this.Config.SetValue<float>("Setup", "VHeading", (M0) (double) this.VHeading);
                  this.Config.Save();
                  Script.Wait(1);
                  this.IsInInterior = true;
                  this.CanUseInteriorPeriscope = true;
                  Script.Wait(500);
                  ((Entity) Game.Player.Character).Position = new Vector3(1557.997f, 404.82f, -49.68f);
                  Script.Wait(1000);
                  Game.FadeScreenIn(3200);
                  ((Entity) Game.Player.Character).Position = new Vector3(1564.646f, 447.85f, -54.1f);
                }
                catch (Exception ex)
                {
                  UI.Notify("~r~ Critical Error~w~ : Oopps! somthing has gone wrong, please retry, ifGTAV has just loaded, this is normal, if it continues after please contact ~g~HKH191~w~");
                }
              }
              if (Game.IsControlJustPressed(2, (Control) 75))
              {
                Game.DisableControl(2, (Control) 75);
                Script.Wait(1);
                Game.Player.Character.SetIntoVehicle(this.Kosatka, (VehicleSeat) -1);
                Script.Wait(200);
                Game.EnableControl(2, (Control) 75);
              }
            }
          }
          Vector3 offsetInWorldCoords2 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, 31f, 2.8f));
          if (!this.IsInInterior)
          {
            if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, offsetInWorldCoords2) < 200.0)
              World.DrawMarker((MarkerType) 1, offsetInWorldCoords2, Vector3.Zero, Vector3.Zero, new Vector3(0.65f, 0.65f, 0.65f), this.SubmarineMarkerColor);
            if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, offsetInWorldCoords2) < 2.0)
            {
              this.DisplayHelpTextThisFrame("Press ~INPUT_VEH_EXIT~ to Drive Vehicle, ~INPUT_CONTEXT~ to Enter Vehicle Interior");
              if (Game.IsControlJustPressed(2, (Control) 51))
              {
                try
                {
                  string dict = "anim@scripted@submarine@ig_27_submarine_door@male@";
                  KosatkaScript.LoadDict(dict);
                  Vector3 position1 = ((Entity) this.Kosatka).Position;
                  this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                  {
                    InputArgument.op_Implicit((float) position1.X),
                    InputArgument.op_Implicit((float) position1.Y),
                    InputArgument.op_Implicit((float) position1.Z),
                    InputArgument.op_Implicit(0.0),
                    InputArgument.op_Implicit(0.0),
                    InputArgument.op_Implicit((float) ((Entity) this.Kosatka).Rotation.Z),
                    InputArgument.op_Implicit(2)
                  });
                  Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                  {
                    InputArgument.op_Implicit(Game.Player.Character),
                    InputArgument.op_Implicit(this.Scene3),
                    InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                    InputArgument.op_Implicit("action"),
                    InputArgument.op_Implicit(16f),
                    InputArgument.op_Implicit(-16f),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(1148846080)
                  });
                  Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                  {
                    InputArgument.op_Implicit(this.Scene3),
                    InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                    {
                      InputArgument.op_Implicit(this.Scene3)
                    }))
                  });
                  Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                  {
                    InputArgument.op_Implicit(Game.Player.Character),
                    InputArgument.op_Implicit(this.Scene3),
                    InputArgument.op_Implicit("action"),
                    InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                    InputArgument.op_Implicit(16f),
                    InputArgument.op_Implicit(-16f),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(1148846080)
                  });
                  Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                  {
                    InputArgument.op_Implicit(this.Kosatka),
                    InputArgument.op_Implicit(this.Scene3),
                    InputArgument.op_Implicit("action_kosatka"),
                    InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                    InputArgument.op_Implicit(16f),
                    InputArgument.op_Implicit(-16f),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(1148846080)
                  });
                  Script.Wait(3000);
                  this.MOCPosSave = ((Entity) this.Kosatka).Position;
                  this.X = (float) offsetInWorldCoords1.X;
                  this.Config.SetValue<float>("Setup", "X", (M0) (double) this.X);
                  this.Y = (float) offsetInWorldCoords1.Y;
                  this.Config.SetValue<float>("Setup", "Y", (M0) (double) this.Y);
                  this.Z = (float) offsetInWorldCoords1.Z;
                  this.Config.SetValue<float>("Setup", "Z", (M0) (double) this.Z);
                  this.Config.SetValue<Vector3>("Setup", "SavePosition", (M0) this.MOCPosSave);
                  this.Config.Save();
                  this.VHeading = ((Entity) this.Kosatka).Heading;
                  this.Config.SetValue<float>("Setup", "VHeading", (M0) (double) this.VHeading);
                  this.Config.Save();
                  this.IsInInterior = true;
                  Game.FadeScreenOut(3200);
                  Script.Wait(3000);
                  Script.Wait(1);
                  this.IsInInterior = true;
                  Script.Wait(3000);
                  Game.FadeScreenIn(3200);
                  this.Scene3 = 0;
                  this.CanUseInteriorPeriscope = true;
                  Script.Wait(500);
                  ((Entity) Game.Player.Character).Position = new Vector3(1557.997f, 404.82f, -49.68f);
                  Script.Wait(1000);
                  Game.FadeScreenIn(3200);
                  ((Entity) Game.Player.Character).Position = new Vector3(1561.531f, 391.9f, -50.5f);
                }
                catch (Exception ex)
                {
                  UI.Notify("~r~ Critical Error~w~ : Oopps! somthing has gone wrong, please retry, ifGTAV has just loaded, this is normal, if it continues after please contact ~g~HKH191~w~");
                }
              }
              if (Game.IsControlJustPressed(2, (Control) 75))
              {
                Game.DisableControl(2, (Control) 75);
                Script.Wait(1);
                Game.Player.Character.SetIntoVehicle(this.Kosatka, (VehicleSeat) -1);
                Script.Wait(200);
                Game.EnableControl(2, (Control) 75);
              }
            }
          }
          Vector3 offsetInWorldCoords3 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, 37.9f, 2.8f));
          if (!this.IsInInterior)
          {
            if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, offsetInWorldCoords3) < 200.0)
              World.DrawMarker((MarkerType) 1, offsetInWorldCoords3, Vector3.Zero, Vector3.Zero, new Vector3(0.65f, 0.65f, 0.65f), this.SubmarineMarkerColor);
            if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, offsetInWorldCoords3) < 2.0)
            {
              this.DisplayHelpTextThisFrame("Press ~INPUT_VEH_EXIT~ to Drive Vehicle, ~INPUT_CONTEXT~ to Enter Vehicle Interior");
              if (Game.IsControlJustPressed(2, (Control) 51))
              {
                try
                {
                  string dict = "anim@scripted@submarine@ig26_submarine_enter@male@";
                  KosatkaScript.LoadDict(dict);
                  Prop exitChair = this.ExitChair;
                  KosatkaScript.LoadDict(dict);
                  Vector3 position1 = ((Entity) this.Kosatka).Position;
                  this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                  {
                    InputArgument.op_Implicit((float) position1.X),
                    InputArgument.op_Implicit((float) position1.Y),
                    InputArgument.op_Implicit((float) position1.Z),
                    InputArgument.op_Implicit(0.0),
                    InputArgument.op_Implicit(0.0),
                    InputArgument.op_Implicit((float) ((Entity) this.Kosatka).Rotation.Z),
                    InputArgument.op_Implicit(2)
                  });
                  Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                  {
                    InputArgument.op_Implicit(Game.Player.Character),
                    InputArgument.op_Implicit(this.Scene3),
                    InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                    InputArgument.op_Implicit("submarine_enter"),
                    InputArgument.op_Implicit(16f),
                    InputArgument.op_Implicit(-16f),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(1148846080)
                  });
                  Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                  {
                    InputArgument.op_Implicit(this.Scene3),
                    InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                    {
                      InputArgument.op_Implicit(this.Scene3)
                    }))
                  });
                  Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                  {
                    InputArgument.op_Implicit(Game.Player.Character),
                    InputArgument.op_Implicit(this.Scene3),
                    InputArgument.op_Implicit("submarine_enter"),
                    InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                    InputArgument.op_Implicit(16f),
                    InputArgument.op_Implicit(-16f),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(1148846080)
                  });
                  Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                  {
                    InputArgument.op_Implicit(this.Kosatka),
                    InputArgument.op_Implicit(this.Scene3),
                    InputArgument.op_Implicit("submarine_enter_kosatka"),
                    InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                    InputArgument.op_Implicit(16f),
                    InputArgument.op_Implicit(-16f),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(1148846080)
                  });
                  Script.Wait(3000);
                  this.MOCPosSave = ((Entity) this.Kosatka).Position;
                  this.X = (float) offsetInWorldCoords1.X;
                  this.Config.SetValue<float>("Setup", "X", (M0) (double) this.X);
                  this.Y = (float) offsetInWorldCoords1.Y;
                  this.Config.SetValue<float>("Setup", "Y", (M0) (double) this.Y);
                  this.Z = (float) offsetInWorldCoords1.Z;
                  this.Config.SetValue<float>("Setup", "Z", (M0) (double) this.Z);
                  this.Config.SetValue<Vector3>("Setup", "SavePosition", (M0) this.MOCPosSave);
                  this.Config.Save();
                  this.VHeading = ((Entity) this.Kosatka).Heading;
                  this.Config.SetValue<float>("Setup", "VHeading", (M0) (double) this.VHeading);
                  this.Config.Save();
                  this.IsInInterior = true;
                  Game.FadeScreenOut(500);
                  Script.Wait(3000);
                  ((Entity) Game.Player.Character).Position = new Vector3(1563.54f, 370.6128f, -50.5f);
                  this.Scene3 = 0;
                  Function.Call((Hash) 2882391207405552608L, new InputArgument[4]
                  {
                    InputArgument.op_Implicit(this.Kosatka),
                    InputArgument.op_Implicit("submarine_enter_kosatka"),
                    InputArgument.op_Implicit("anim@scripted@submarine@ig26_submarine_enter@male@"),
                    InputArgument.op_Implicit(0.0f)
                  });
                  Script.Wait(500);
                  this.CanUseInteriorPeriscope = true;
                  Script.Wait(500);
                  ((Entity) Game.Player.Character).Position = new Vector3(1557.997f, 404.82f, -49.68f);
                  Script.Wait(1000);
                  Game.FadeScreenIn(3200);
                  ((Entity) Game.Player.Character).Position = new Vector3(1563.54f, 370.6128f, -50.5f);
                }
                catch (Exception ex)
                {
                  UI.Notify("~r~ Critical Error~w~ : Oopps! somthing has gone wrong, please retry, ifGTAV has just loaded, this is normal, if it continues after please contact ~g~HKH191~w~");
                }
              }
              if (Game.IsControlJustPressed(2, (Control) 75))
              {
                Game.DisableControl(2, (Control) 75);
                Script.Wait(1);
                Game.Player.Character.SetIntoVehicle(this.Kosatka, (VehicleSeat) -1);
                Script.Wait(200);
                Game.EnableControl(2, (Control) 75);
              }
            }
          }
        }
      }
      if (this.IsUsingSam || (double) World.GetDistance(((Entity) Game.Player.Character).Position, this.SamLoc) >= 1.25)
        ;
      if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
      {
        Vector3 offsetInWorldCoords1 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, -54.8f, 3.8f));
        Vector3 offsetInWorldCoords2 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, 31f, 2.8f));
        Vector3 offsetInWorldCoords3 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, 37.9f, 2.8f));
        if (this.IsInInterior)
        {
          if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1564.646f, 447.85f, -54.1f)) < 200.0)
            World.DrawMarker((MarkerType) 1, new Vector3(1564.646f, 447.85f, -54.1f), Vector3.Zero, Vector3.Zero, new Vector3(0.65f, 0.65f, 0.65f), this.SubmarineMarkerColor);
          if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1564.646f, 447.85f, -54.1f)) < 2.0)
          {
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Exit Vehicle Interior");
            if (Game.IsControlJustPressed(2, (Control) 51))
            {
              try
              {
                Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
                string dict = "anim@scripted@submarine@ig24_submarine_exit@male@";
                KosatkaScript.LoadDict(dict);
                ((Entity) Game.Player.Character).Position = new Vector3(1564.621f, 448.563f, -54.237f);
                ((Entity) Game.Player.Character).Heading = 0.0f;
                ((Entity) Game.Player.Character).Position = ((Entity) Game.Player.Character).GetOffsetInWorldCoords(new Vector3(0.0f, 0.02f, 0.1f));
                Vector3 position1 = ((Entity) Game.Player.Character).Position;
                this.EnterExitCam = World.CreateCamera(((Entity) Game.Player.Character).GetOffsetInWorldCoords(new Vector3(0.0f, -1f, 4f)), new Vector3(-90f, 0.0f, 0.0f), 60f);
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                World.RenderingCamera = this.EnterExitCam;
                this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) position1.X),
                  InputArgument.op_Implicit((float) position1.Y),
                  InputArgument.op_Implicit((float) position1.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(2.35f),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("action_male"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Scene3)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit("action_male"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Script.Wait(3000);
                Game.FadeScreenOut(500);
                Script.Wait(3000);
                this.EnterExitCam.Destroy();
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                World.RenderingCamera = (Camera) null;
                Script.Wait(1);
                Game.FadeScreenIn(3200);
                if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
                {
                  ((Entity) this.Kosatka).Delete();
                  Script.Wait(500);
                  this.SpawnMOC();
                  Script.Wait(500);
                  offsetInWorldCoords1 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, -54.8f, 3.8f));
                }
                this.IsInInterior = false;
                ((Entity) Game.Player.Character).Position = offsetInWorldCoords1;
                Game.Player.Character.Task.ClearAllImmediately();
                this.Scene3 = 0;
              }
              catch (Exception ex)
              {
                UI.Notify("~r~ Critical Error~w~ : Oopps! somthing has gone wrong, please retry, if GTAV has just loaded, this is normal, if it continues after please contact ~g~HKH191~w~");
              }
            }
          }
        }
        if (this.IsInInterior)
        {
          if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1561.531f, 391.9f, -50.5f)) < 200.0)
            World.DrawMarker((MarkerType) 1, new Vector3(1561.531f, 391.9f, -50.5f), Vector3.Zero, Vector3.Zero, new Vector3(0.65f, 0.65f, 0.65f), this.SubmarineMarkerColor);
          if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1561.531f, 391.9f, -50.5f)) < 2.0)
          {
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Exit Vehicle Interior");
            if (Game.IsControlJustPressed(2, (Control) 51))
            {
              try
              {
                Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
                string dict = "anim@scripted@submarine@ig24_submarine_exit@male@";
                KosatkaScript.LoadDict(dict);
                ((Entity) Game.Player.Character).Position = new Vector3(1561.502f, 392.491f, -50.679f);
                ((Entity) Game.Player.Character).Heading = 0.0f;
                ((Entity) Game.Player.Character).Position = ((Entity) Game.Player.Character).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.1f));
                Vector3 position1 = ((Entity) Game.Player.Character).Position;
                this.EnterExitCam = World.CreateCamera(((Entity) Game.Player.Character).GetOffsetInWorldCoords(new Vector3(0.0f, -1f, 4f)), new Vector3(-90f, 0.0f, 0.0f), 60f);
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                World.RenderingCamera = this.EnterExitCam;
                this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) position1.X),
                  InputArgument.op_Implicit((float) position1.Y),
                  InputArgument.op_Implicit((float) position1.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(-0.83f),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("action_male"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Scene3)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit("action_male"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Script.Wait(3000);
                Game.FadeScreenOut(500);
                Script.Wait(3000);
                if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
                {
                  ((Entity) this.Kosatka).Delete();
                  Script.Wait(500);
                  this.SpawnMOC();
                  Script.Wait(500);
                  offsetInWorldCoords2 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, 31f, 2.8f));
                }
                this.EnterExitCam.Destroy();
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                World.RenderingCamera = (Camera) null;
                this.IsInInterior = false;
                ((Entity) Game.Player.Character).Position = offsetInWorldCoords2;
                Script.Wait(3000);
                Game.FadeScreenIn(3200);
                Game.Player.Character.Task.ClearAllImmediately();
                this.Scene3 = 0;
              }
              catch (Exception ex)
              {
                UI.Notify("~r~ Critical Error~w~ : Oopps! somthing has gone wrong, please retry, ifGTAV has just loaded, this is normal, if it continues after please contact ~g~HKH191~w~");
              }
            }
          }
        }
        if (this.IsInInterior)
        {
          if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1563.54f, 370.6128f, -50.5f)) < 200.0)
            World.DrawMarker((MarkerType) 1, new Vector3(1563.54f, 370.6128f, -50.5f), Vector3.Zero, Vector3.Zero, new Vector3(0.65f, 0.65f, 0.65f), this.SubmarineMarkerColor);
          if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(1563.54f, 370.6128f, -50.5f)) < 2.0)
          {
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Exit Vehicle Interior");
            if (Game.IsControlJustPressed(2, (Control) 51))
            {
              try
              {
                Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
                string dict = "anim@scripted@submarine@ig24_submarine_exit@male@";
                KosatkaScript.LoadDict(dict);
                ((Entity) Game.Player.Character).Position = new Vector3(1563.448f, 369.754f, -50.679f);
                ((Entity) Game.Player.Character).Heading = 180f;
                ((Entity) Game.Player.Character).Position = ((Entity) Game.Player.Character).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.1f));
                Vector3 position1 = ((Entity) Game.Player.Character).Position;
                this.EnterExitCam = World.CreateCamera(((Entity) Game.Player.Character).GetOffsetInWorldCoords(new Vector3(0.0f, -1f, 4f)), new Vector3(-90f, 0.0f, 0.0f), 60f);
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                World.RenderingCamera = this.EnterExitCam;
                this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) position1.X),
                  InputArgument.op_Implicit((float) position1.Y),
                  InputArgument.op_Implicit((float) position1.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(178f),
                  InputArgument.op_Implicit(2)
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("action_male"),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Scene3)
                  }))
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit("action_male"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(16f),
                  InputArgument.op_Implicit(-16f),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080)
                });
                Script.Wait(3000);
                Game.FadeScreenOut(500);
                Script.Wait(3000);
                if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
                {
                  ((Entity) this.Kosatka).Delete();
                  Script.Wait(500);
                  this.SpawnMOC();
                  Script.Wait(500);
                  offsetInWorldCoords3 = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, 37.9f, 2.8f));
                }
                this.IsInInterior = false;
                this.EnterExitCam.Destroy();
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                World.RenderingCamera = (Camera) null;
                ((Entity) Game.Player.Character).Position = offsetInWorldCoords3;
                Script.Wait(2000);
                Game.FadeScreenIn(3200);
                Game.Player.Character.Task.ClearAllImmediately();
                this.Scene3 = 0;
              }
              catch (Exception ex)
              {
                UI.Notify("~r~ Critical Error~w~ : Oopps! somthing has gone wrong, please retry, ifGTAV has just loaded, this is normal, if it continues after please contact ~g~HKH191~w~");
              }
            }
          }
        }
      }
      else if (this.IsInInterior)
      {
        Script.Wait(500);
        this.SpawnMOC();
        Script.Wait(500);
      }
      if (this.IsInDroneMode)
      {
        KosatkaScript.DrawScaleformDrone();
        if (this.DroneInUse == 0)
        {
          if (Entity.op_Inequality((Entity) this.DroneProp, (Entity) null))
          {
            ((Entity) this.DroneProp).Position = ((Entity) this.Drone).GetOffsetInWorldCoords(new Vector3(0.0f, 0.2f, -0.05f));
            ((Entity) this.DroneProp).Rotation = ((Entity) this.Drone).Rotation;
            ((Entity) this.DroneProp).SetNoCollision((Entity) this.Drone, true);
            ((Entity) this.DroneProp).IsVisible = true;
          }
          if (Game.IsControlJustPressed(2, (Control) 0))
          {
            if (this.DronePropEnabled)
            {
              if (Entity.op_Inequality((Entity) this.DroneProp, (Entity) null))
              {
                this.DronePropEnabled = false;
                UI.Notify("Delete Drone 3d person");
                ((Entity) this.DroneProp).Delete();
              }
            }
            else if (!this.DronePropEnabled)
            {
              this.DronePropEnabled = true;
              UI.Notify("Activate Drone 3d person");
              this.DroneProp = World.CreateProp(this.RequestModel("ba_prop_battle_drone_quad"), ((Entity) this.Drone).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f)), false, false);
              ((Entity) this.DroneProp).FreezePosition = true;
            }
          }
          this.DisplayHelpTextThisFrameNoSound("Press ~INPUT_CONTEXT~ to Exit Drone, " + World.GetDistance(((Entity) Game.Player.Character).Position, this.Spawn).ToString() + "m From Terabyte, 400m is out of range");
        }
        if (this.DroneInUse == 1)
          this.DisplayHelpTextThisFrameNoSound("Press ~INPUT_CONTEXT~ to Exit Drone, " + World.GetDistance(((Entity) Game.Player.Character).Position, this.Spawn).ToString() + "m From Terabyte, 900m is out of range");
        ((Entity) Game.Player.Character).IsInvincible = true;
        if (Entity.op_Inequality((Entity) this.Drone, (Entity) null))
        {
          this.DroneCamPos = ((Entity) this.Drone).Position;
          this.DroneCam.Position = this.DroneCamPos;
          this.DroneCam.Rotation = ((Entity) this.Drone).Rotation;
          ((Entity) this.Drone).IsVisible = false;
        }
        if (this.DroneInUse == 0 && (double) World.GetDistance(((Entity) Game.Player.Character).Position, this.Spawn) > 400.0)
        {
          ((Entity) this.Drone).IsVisible = false;
          ((Entity) Game.Player.Character).IsInvincible = false;
          ((Entity) Game.Player.Character).IsVisible = true;
          ((Entity) this.Drone).Delete();
          this.IsInDroneMode = false;
          this.IsInInterior = true;
          ((Entity) Game.Player.Character).Position = this.CabOptions;
          Function.Call((Hash) 569060033405794044L, new InputArgument[5]
          {
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(3000),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0)
          });
          this.DroneCam.Destroy();
          this.DisplayHelpTextThisFrame("No signal to Drone, Reason : Drone Out of range");
        }
        if (this.DroneInUse == 1 && (double) World.GetDistance(((Entity) Game.Player.Character).Position, this.Spawn) > 900.0)
        {
          ((Entity) this.Drone).IsVisible = false;
          ((Entity) Game.Player.Character).IsInvincible = false;
          ((Entity) Game.Player.Character).IsVisible = true;
          ((Entity) this.Drone).Delete();
          this.IsInDroneMode = false;
          this.IsInInterior = true;
          ((Entity) Game.Player.Character).Position = this.CabOptions;
          Function.Call((Hash) 569060033405794044L, new InputArgument[5]
          {
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(3000),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0)
          });
          this.DroneCam.Destroy();
          this.DisplayHelpTextThisFrame("No signal to Drone, Reason : Drone Out of range");
        }
        if (!((Entity) this.Drone).IsAlive)
        {
          ((Entity) this.Drone).IsVisible = false;
          ((Entity) Game.Player.Character).IsInvincible = false;
          ((Entity) Game.Player.Character).IsVisible = true;
          ((Entity) this.Drone).Delete();
          this.IsInDroneMode = false;
          this.IsInInterior = true;
          ((Entity) Game.Player.Character).Position = this.CabOptions;
          Function.Call((Hash) 569060033405794044L, new InputArgument[5]
          {
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(3000),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0)
          });
          this.DroneCam.Destroy();
          this.DisplayHelpTextThisFrame("No signal to Drone, Reason : Drone Exploded");
        }
      }
      if (this.ResetMoc)
      {
        if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
          ((Entity) this.Kosatka).Delete();
        ((Entity) Game.Player.Character).Position = this.Spawn;
        this.X = (float) this.Spawn.X;
        this.Config.SetValue<float>("Setup", "X", (M0) (double) this.X);
        this.Y = (float) this.Spawn.Y;
        this.Config.SetValue<float>("Setup", "Y", (M0) (double) this.Y);
        this.Z = (float) this.Spawn.Z;
        this.Config.SetValue<float>("Setup", "Z", (M0) (double) this.Z);
        this.Config.SetValue<Vector3>("Setup", "SavePosition", (M0) this.MOCPosSave);
        this.Config.Save();
        this.Created = false;
        this.LoadIniFile("scripts//CayoPericoInSp//Submarine.ini");
        ((Entity) Game.Player.Character).Position = this.Spawn;
        this.ResetMoc = false;
        Game.Player.Character.SetIntoVehicle(this.Kosatka, (VehicleSeat) -1);
      }
      if (this.ReadIni && (double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(-163f, -1297f, 30f)) < 10.0)
      {
        this.Spawn = this.Strawberry;
        this.MOCPosSave = this.Spawn;
        this.Spawn = this.MOCPosSave;
        this.ResetMoc = true;
        this.ReadIni = false;
      }
      if (Entity.op_Inequality((Entity) this.SaveLoad.SavedVehicle, (Entity) null))
        this.VehicleinCargoBay = this.SaveLoad.SavedVehicle;
      if (Entity.op_Inequality((Entity) this.VehicleinCargoBay, (Entity) null) && this.VehicleinCargoBay.GetPedOnSeat((VehicleSeat) -1).IsPlayer)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Use Vehicle, Press ~INPUT_COVER~ to Save Vehicle");
      if (this.IsInInterior)
      {
        if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, this.CabOptions) >= 100.0)
          ;
        if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, this.CabOptions) >= 1.25)
          ;
      }
      if (this.SubPurchased == 1)
      {
        Vector3 spawn = this.Spawn;
        if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, this.Spawn) < 4000.0 && !this.Created)
        {
          this.LoadIniFile("scripts//CayoPericoInSp//Submarine.ini");
          Script.Wait(1);
          this.SpawnMOC();
        }
      }
      if (!Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
        return;
      this.LastKnownPos = ((Entity) this.Kosatka).Position;
      this.MOCBlip.Position = ((Entity) this.Kosatka).Position;
    }

    public void OnKeyDown()
    {
      if (Game.IsControlJustPressed(2, (Control) 44))
      {
        if (this.IsUsingSam)
        {
          this.IsUsingSam = false;
          ((Entity) Game.Player.Character).IsInvincible = false;
          ((Entity) Game.Player.Character).IsVisible = true;
          this.IsInInterior = true;
          ((Entity) Game.Player.Character).Position = this.CabOptions;
          Function.Call((Hash) 569060033405794044L, new InputArgument[5]
          {
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(3000),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0)
          });
          this.DroneCam.Destroy();
          this.DisplayHelpTextThisFrame("Deactivating SAM");
          string dict = "anim@amb@trailer@turret_controls@";
          KosatkaScript.LoadDict(dict);
          Prop exitChair = this.ExitChair;
          KosatkaScript.LoadDict(dict);
          int num = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
          {
            InputArgument.op_Implicit((float) ((Entity) exitChair).Position.X),
            InputArgument.op_Implicit((float) ((Entity) exitChair).Position.Y),
            InputArgument.op_Implicit((float) ((Entity) exitChair).Position.Z),
            InputArgument.op_Implicit(0.0),
            InputArgument.op_Implicit(0.0),
            InputArgument.op_Implicit((float) ((Entity) exitChair).Rotation.Z),
            InputArgument.op_Implicit(2)
          });
          Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
            InputArgument.op_Implicit("computer_exit"),
            InputArgument.op_Implicit(16f),
            InputArgument.op_Implicit(-16f),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1148846080)
          });
          Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
          {
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
            {
              InputArgument.op_Implicit(num)
            }))
          });
          Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
          {
            InputArgument.op_Implicit(Game.Player.Character),
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("computer_exit"),
            InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
            InputArgument.op_Implicit(16f),
            InputArgument.op_Implicit(-16f),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1148846080)
          });
          Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
          {
            InputArgument.op_Implicit(exitChair),
            InputArgument.op_Implicit(num),
            InputArgument.op_Implicit("computer_exit_chair"),
            InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
            InputArgument.op_Implicit(16f),
            InputArgument.op_Implicit(-16f),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1148846080)
          });
        }
        else if (this.IsUsingSam || (double) World.GetDistance(((Entity) Game.Player.Character).Position, this.SamLoc) >= 2.0)
          ;
      }
      if (Game.IsControlJustPressed(2, (Control) 132) && (this.IsUsingSam && this.CanFire))
      {
        this.CanFire = false;
        Model model = Model.op_Implicit((int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
        {
          InputArgument.op_Implicit("WEAPON_AIRSTRIKE_ROCKET")
        }));
        if (Function.Call<bool>((Hash) 3955096325251305710L, new InputArgument[1]
        {
          InputArgument.op_Implicit(model)
        }) == 0)
        {
          Function.Call((Hash) 6071771004139350467L, new InputArgument[1]
          {
            InputArgument.op_Implicit(model)
          });
          while (true)
          {
            if (Function.Call<bool>((Hash) 3955096325251305710L, new InputArgument[1]
            {
              InputArgument.op_Implicit(model)
            }) == 0)
              Script.Wait(0);
            else
              break;
          }
        }
        Vector3 position1 = this.DroneCam.Position;
        Vector3 position2 = ((Entity) Game.Player.Character).Position;
        Vector3 position3 = this.DroneCam.Position;
        Vector3 rotation = this.DroneCam.Rotation;
        float num1 = (float) (rotation.Z * (System.Math.PI / 180.0));
        float num2 = (float) (rotation.X * (System.Math.PI / 180.0));
        float num3 = (float) System.Math.Abs(System.Math.Cos((double) num2));
        Vector3 vector3;
        // ISSUE: explicit constructor call
        ((Vector3) ref vector3).\u002Ector((float) (System.Math.Sin((double) num1) * (double) num3 * -1.0), (float) System.Math.Cos((double) num1) * num3, (float) System.Math.Sin((double) num2));
        RaycastResult raycastResult = World.Raycast(position3, Vector3.op_Addition(position3, Vector3.op_Multiply(vector3, 100000f)), (IntersectOptions) -1);
        World.AddOwnedExplosion(Game.Player.Character, ((RaycastResult) ref raycastResult).HitCoords, (ExplosionType) 21, 0.5f, 0.0f);
        Vector3 hitCoords1 = ((RaycastResult) ref raycastResult).HitCoords;
        if (true)
        {
          float num4 = (float) (new Random().Next(-100, 100) / 100);
          Vector3 hitCoords2 = ((RaycastResult) ref raycastResult).HitCoords;
          World.ShootBullet(position1, hitCoords2, Game.Player.Character, model, 15000);
          Script.Wait(1000);
          this.CanFire = true;
        }
      }
      if (Game.IsControlJustPressed(2, (Control) 22) && (this.IsUsingSam && this.CanFire))
      {
        this.CanFire = false;
        Model model = Model.op_Implicit((int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
        {
          InputArgument.op_Implicit("WEAPON_AIRSTRIKE_ROCKET")
        }));
        if (Function.Call<bool>((Hash) 3955096325251305710L, new InputArgument[1]
        {
          InputArgument.op_Implicit(model)
        }) == 0)
        {
          Function.Call((Hash) 6071771004139350467L, new InputArgument[1]
          {
            InputArgument.op_Implicit(model)
          });
          while (true)
          {
            if (Function.Call<bool>((Hash) 3955096325251305710L, new InputArgument[1]
            {
              InputArgument.op_Implicit(model)
            }) == 0)
              Script.Wait(0);
            else
              break;
          }
        }
        Vector3 position1 = this.DroneCam.Position;
        Vector3 position2 = ((Entity) Game.Player.Character).Position;
        Vector3 position3 = this.DroneCam.Position;
        Vector3 rotation = this.DroneCam.Rotation;
        float num1 = (float) (rotation.Z * (System.Math.PI / 180.0));
        float num2 = (float) (rotation.X * (System.Math.PI / 180.0));
        float num3 = (float) System.Math.Abs(System.Math.Cos((double) num2));
        Vector3 vector3_1;
        // ISSUE: explicit constructor call
        ((Vector3) ref vector3_1).\u002Ector((float) (System.Math.Sin((double) num1) * (double) num3 * -1.0), (float) System.Math.Cos((double) num1) * num3, (float) System.Math.Sin((double) num2));
        RaycastResult raycastResult = World.Raycast(position3, Vector3.op_Addition(position3, Vector3.op_Multiply(vector3_1, 100000f)), (IntersectOptions) -1);
        World.AddOwnedExplosion(Game.Player.Character, ((RaycastResult) ref raycastResult).HitCoords, (ExplosionType) 21, 0.5f, 0.0f);
        Vector3 hitCoords1 = ((RaycastResult) ref raycastResult).HitCoords;
        if (true)
        {
          Random random = new Random();
          float num4 = (float) (random.Next(-100, 100) / 100);
          Vector3 hitCoords2 = ((RaycastResult) ref raycastResult).HitCoords;
          World.ShootBullet(position1, hitCoords2, Game.Player.Character, model, 15000);
          Vector3 vector3_2 = position1;
          Script.Wait(100);
          float num5 = (float) (random.Next(-100, 100) / 100);
          // ISSUE: explicit constructor call
          ((Vector3) ref vector3_2).\u002Ector((float) position1.X + num5, (float) position1.Y, (float) position1.Z + num5);
          World.ShootBullet(vector3_2, hitCoords2, Game.Player.Character, model, 15000);
          Vector3 vector3_3 = position1;
          Script.Wait(100);
          float num6 = (float) (random.Next(-100, 100) / 100);
          // ISSUE: explicit constructor call
          ((Vector3) ref vector3_3).\u002Ector((float) position1.X + num6, (float) position1.Y, (float) position1.Z + num6);
          World.ShootBullet(vector3_3, hitCoords2, Game.Player.Character, model, 15000);
          Vector3 vector3_4 = position1;
          Script.Wait(100);
          float num7 = (float) (random.Next(-100, 100) / 100);
          // ISSUE: explicit constructor call
          ((Vector3) ref vector3_4).\u002Ector((float) position1.X + num7, (float) position1.Y, (float) position1.Z + num7);
          World.ShootBullet(vector3_4, hitCoords2, Game.Player.Character, model, 15000);
          Script.Wait(3000);
          this.CanFire = true;
        }
      }
      if (!Game.IsControlJustPressed(2, (Control) 74) || !Entity.op_Inequality((Entity) this.Kosatka, (Entity) null) || !this.Kosatka.GetPedOnSeat((VehicleSeat) -1).IsPlayer)
        ;
      if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null) && Entity.op_Equality((Entity) Game.Player.Character.CurrentVehicle, (Entity) this.Kosatka))
      {
        if (this.HoldToEnterInterior)
        {
          if (Game.IsControlJustReleased(2, (Control) 75))
          {
            Game.FadeScreenOut(500);
            Script.Wait(500);
            this.CanUseInteriorPeriscope = true;
            Script.Wait(500);
            ((Entity) Game.Player.Character).Position = new Vector3(1557.997f, 404.82f, -49.68f);
            this.HoldDelay = 0;
            this.Kosatka.Speed = 0.0f;
            ((Entity) Game.Player.Character).HasCollision = false;
            Function.Call((Hash) 6410651044935755444L, Array.Empty<InputArgument>());
            Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
            Function.Call((Hash) 4362080213785518366L, Array.Empty<InputArgument>());
            Function.Call((Hash) 3211975551654944577L, new InputArgument[1]
            {
              InputArgument.op_Implicit("default")
            });
            if (Function.Call<int>((Hash) -147535234440955034L, Array.Empty<InputArgument>()) != -1)
              Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
            this.UnderWater = false;
            ((Entity) Game.Player.Character).HasCollision = true;
            ((Entity) Game.Player.Character).Position = new Vector3(1559.427f, 381.3182f, -50.68f);
            ((Entity) Game.Player.Character).Heading = 0.0f;
            this.IsInInterior = true;
            this.CreatedChairs = false;
            this.CreatedChairs = true;
            if (Entity.op_Inequality((Entity) this.Chair1, (Entity) null))
              ((Entity) this.Chair1).Delete();
            if (Entity.op_Inequality((Entity) this.Chair2, (Entity) null))
              ((Entity) this.Chair2).Delete();
            if (Entity.op_Inequality((Entity) this.Chair3, (Entity) null))
              ((Entity) this.Chair3).Delete();
            if (Entity.op_Inequality((Entity) this.Chair4, (Entity) null))
              ((Entity) this.Chair4).Delete();
            if (Entity.op_Inequality((Entity) this.Chair5, (Entity) null))
              ((Entity) this.Chair5).Delete();
            if (Entity.op_Inequality((Entity) this.Chair6, (Entity) null))
              ((Entity) this.Chair6).Delete();
            if (Entity.op_Inequality((Entity) this.Chair7, (Entity) null))
              ((Entity) this.Chair7).Delete();
            if (Entity.op_Inequality((Entity) this.Chair8, (Entity) null))
              ((Entity) this.Chair8).Delete();
            if (Entity.op_Inequality((Entity) this.Chair9, (Entity) null))
              ((Entity) this.Chair9).Delete();
            if (Entity.op_Inequality((Entity) this.Chair10, (Entity) null))
              ((Entity) this.Chair10).Delete();
            if (Entity.op_Inequality((Entity) this.Console1, (Entity) null))
              ((Entity) this.Console1).Delete();
            if (Entity.op_Inequality((Entity) this.Console2, (Entity) null))
              ((Entity) this.Console2).Delete();
            if (Entity.op_Inequality((Entity) this.Console3, (Entity) null))
              ((Entity) this.Console3).Delete();
            this.Chair1 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_02"), new Vector3(1558.718f, 388.6768f, -50.68f), new Vector3(0.0f, 0.0f, -90f), false, false);
            ((Entity) this.Chair1).FreezePosition = true;
            this.Chair2 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_02"), new Vector3(1558.765f, 387.4181f, -50.68f), new Vector3(0.0f, 0.0f, -90f), false, false);
            ((Entity) this.Chair2).FreezePosition = true;
            this.Chair3 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1558.862f, 385.974f, -50.68f), new Vector3(0.0f, 0.0f, -90f), false, false);
            ((Entity) this.Chair3).FreezePosition = true;
            this.Chair4 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1558.751f, 384.6591f, -50.68f), new Vector3(0.0f, 0.0f, -90f), false, false);
            ((Entity) this.Chair4).FreezePosition = true;
            this.Chair5 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1558.74f, 383.2693f, -50.68727f), new Vector3(0.0f, 0.0f, -90f), false, false);
            ((Entity) this.Chair5).FreezePosition = true;
            this.Chair7 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1558.801f, 382.0339f, -50.68f), new Vector3(0.0f, 0.0f, -90f), false, false);
            ((Entity) this.Chair7).FreezePosition = true;
            this.Chair8 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_02"), new Vector3(1559.427f, 381.3182f, -50.68f), new Vector3(0.0f, 0.0f, 0.0f), false, false);
            ((Entity) this.Chair8).FreezePosition = true;
            this.Chair9 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1564.07f, 386.1208f, -50.68f), new Vector3(0.0f, 0.0f, 98f), false, false);
            ((Entity) this.Chair9).FreezePosition = true;
            this.Chair10 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1564.01f, 384.9416f, -50.68727f), new Vector3(0.0f, 0.0f, 90f), false, false);
            ((Entity) this.Chair10).FreezePosition = true;
            int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
            {
              InputArgument.op_Implicit(1561.541f),
              InputArgument.op_Implicit(419.4447f),
              InputArgument.op_Implicit(-55.30978f)
            });
            this.Console1 = World.CreateProp(this.RequestModel("h4_prop_h4_console_01a"), new Vector3(1557.958f, 388.6993f, -49.93543f), new Vector3(0.0f, 0.0f, 90f), false, false);
            this.Console2 = World.CreateProp(this.RequestModel("h4_prop_h4_console_01a"), new Vector3(1557.958f, 387.3052f, -49.93543f), new Vector3(0.0f, 0.0f, 90f), false, false);
            this.Console3 = World.CreateProp(this.RequestModel("h4_prop_h4_console_01a"), new Vector3(1559.388f, 380.5829f, -49.93543f), new Vector3(0.0f, 0.0f, 180f), false, false);
            foreach (Prop chest in this.Chests)
            {
              if (Entity.op_Inequality((Entity) chest, (Entity) null))
                ((Entity) chest).Delete();
            }
            if (this.ShowTreasureCollectioninSub)
            {
              Prop prop1 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), new Vector3(1563.3f, 400.4742f, -50.6f), new Vector3(0.0f, 0.0f, 0.0f), true, false);
              this.Chests.Add(prop1);
              ((Entity) prop1).IsVisible = false;
              ((Entity) prop1).FreezePosition = true;
              if (this.ChestCollected >= 1 && this.ChestCollected < 7)
                ((Entity) prop1).IsVisible = true;
              if (this.ChestCollected >= 2 && this.ChestCollected < 16)
              {
                Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, 0.0f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop2);
                ((Entity) prop2).FreezePosition = true;
              }
              if (this.ChestCollected >= 3)
              {
                Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(-0.5f, 0.0f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop2);
                ((Entity) prop2).FreezePosition = true;
              }
              if (this.ChestCollected >= 4)
              {
                Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, 0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop2);
                ((Entity) prop2).FreezePosition = true;
              }
              if (this.ChestCollected >= 5 && this.ChestCollected < 24)
              {
                Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, -0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop2);
                ((Entity) prop2).FreezePosition = true;
              }
              if (this.ChestCollected >= 6)
              {
                Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a_land"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, 0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
                Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, 0.3f, 0.05f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop2);
                ((Entity) prop2).FreezePosition = true;
                this.Chests.Add(prop3);
                ((Entity) prop3).FreezePosition = true;
              }
              if (this.ChestCollected >= 7)
              {
                Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop2);
                ((Entity) prop2).FreezePosition = true;
              }
              if (this.ChestCollected >= 9)
              {
                Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(-0.5f, 0.0f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop2);
                ((Entity) prop2).FreezePosition = true;
                Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(-0.5f, 0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop3);
                ((Entity) prop3).FreezePosition = true;
              }
              if (this.ChestCollected >= 11)
              {
                Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, 0.6f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop2);
                ((Entity) prop2).FreezePosition = true;
                Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a_land"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, 0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
                Prop prop4 = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, 0.3f, 0.23f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop3);
                ((Entity) prop3).FreezePosition = true;
                this.Chests.Add(prop4);
                ((Entity) prop4).FreezePosition = true;
              }
              if (this.ChestCollected >= 12 && this.ChestCollected < 24)
              {
                Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, -0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop2);
                ((Entity) prop2).FreezePosition = true;
              }
              if (this.ChestCollected >= 13)
              {
                Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a_land"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, 0.0f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
                Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, 0.0f, 0.23f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop2);
                ((Entity) prop2).FreezePosition = true;
                this.Chests.Add(prop3);
                ((Entity) prop3).FreezePosition = true;
              }
              if (this.ChestCollected >= 16)
              {
                Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, 0.0f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop2);
                ((Entity) prop2).FreezePosition = true;
                Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, 0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop3);
                ((Entity) prop3).FreezePosition = true;
                Prop prop4 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, 0.0f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop4);
                ((Entity) prop4).FreezePosition = true;
              }
              if (this.ChestCollected >= 18)
              {
                Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a_land"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, 0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
                Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, 0.3f, 0.23f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop2);
                ((Entity) prop2).FreezePosition = true;
                this.Chests.Add(prop3);
                ((Entity) prop3).FreezePosition = true;
              }
              if (this.ChestCollected >= 24)
              {
                Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, -0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop2);
                ((Entity) prop2).FreezePosition = true;
                Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, -0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop3);
                ((Entity) prop3).FreezePosition = true;
                Prop prop4 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, -0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop4);
                ((Entity) prop4).FreezePosition = true;
                Prop prop5 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, -0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop5);
                ((Entity) prop5).FreezePosition = true;
                Prop prop6 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(-0.5f, -0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop6);
                ((Entity) prop6).FreezePosition = true;
                Prop prop7 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(-1f, -0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop7);
                ((Entity) prop7).FreezePosition = true;
              }
              if (this.ChestCollected >= 26)
              {
                Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, -0.3f, 0.36f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop2);
                ((Entity) prop2).FreezePosition = true;
                Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a_land"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, -0.3f, 0.36f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
                Prop prop4 = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, -0.3f, 0.41f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop3);
                ((Entity) prop3).FreezePosition = true;
                this.Chests.Add(prop4);
                ((Entity) prop4).FreezePosition = true;
              }
            }
            while (Entity.op_Equality((Entity) this.Chair8, (Entity) null))
              Script.Wait(1);
            Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
            this.PlayingConsoleIdleAnim_8 = true;
            string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
            KosatkaScript.LoadDict(dict);
            Prop chair8 = this.Chair8;
            this.ExitChair = this.Chair8;
            this.Chair8_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
            {
              InputArgument.op_Implicit((float) ((Entity) chair8).Position.X),
              InputArgument.op_Implicit((float) ((Entity) chair8).Position.Y),
              InputArgument.op_Implicit((float) ((Entity) chair8).Position.Z),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit(0.0),
              InputArgument.op_Implicit((float) ((Entity) chair8).Rotation.Z),
              InputArgument.op_Implicit(2)
            });
            Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
            {
              InputArgument.op_Implicit(Game.Player.Character),
              InputArgument.op_Implicit(this.Chair8_Scene),
              InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
              InputArgument.op_Implicit("computer_enter"),
              InputArgument.op_Implicit(16f),
              InputArgument.op_Implicit(-16f),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1148846080)
            });
            Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
            {
              InputArgument.op_Implicit(Game.Player.Character),
              InputArgument.op_Implicit(this.Chair8_Scene),
              InputArgument.op_Implicit("computer_enter"),
              InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
              InputArgument.op_Implicit(16f),
              InputArgument.op_Implicit(-16f),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1148846080)
            });
            Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
            {
              InputArgument.op_Implicit(this.Console3),
              InputArgument.op_Implicit(this.Chair8_Scene),
              InputArgument.op_Implicit("enter_console"),
              InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
              InputArgument.op_Implicit(16f),
              InputArgument.op_Implicit(-16f),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1148846080)
            });
            Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
            this.SittinginSeat = true;
            if (this.UsingPeriscope)
            {
              Function.Call((Hash) 569060033405794044L, new InputArgument[5]
              {
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(3000),
                InputArgument.op_Implicit(1),
                InputArgument.op_Implicit(0)
              });
              ((Entity) Game.Player.Character).IsInvincible = false;
              ((Entity) Game.Player.Character).IsVisible = true;
              this.DroneCam.Destroy();
              this.UsingPeriscope = false;
            }
            this.MOCPosSave = ((Entity) this.Kosatka).Position;
            this.Spawn = this.MOCPosSave;
            this.X = (float) this.Spawn.X;
            this.Config.SetValue<float>("Setup", "X", (M0) (double) this.X);
            this.Y = (float) this.Spawn.Y;
            this.Config.SetValue<float>("Setup", "Y", (M0) (double) this.Y);
            this.Z = (float) this.Spawn.Z;
            this.Config.SetValue<float>("Setup", "Z", (M0) (double) this.Z);
            this.Config.SetValue<Vector3>("Setup", "SavePosition", (M0) this.MOCPosSave);
            this.Config.Save();
            this.VHeading = ((Entity) this.Kosatka).Heading;
            this.Config.SetValue<float>("Setup", "VHeading", (M0) (double) this.VHeading);
            this.Config.Save();
            Script.Wait(100);
            this.IsInInterior = false;
            ((Entity) this.Kosatka).FreezePosition = false;
            Script.Wait(500);
            Game.FadeScreenIn(500);
          }
          if (Game.IsControlPressed(2, (Control) 75))
          {
            ++this.HoldDelay;
            if (this.HoldDelay == 30)
            {
              this.HoldDelay = 0;
              if (((Entity) this.Kosatka).Position.Z > -14.0)
              {
                ((Entity) this.Kosatka).FreezePosition = true;
                this.Kosatka.Speed = 0.0f;
                Game.Player.Character.Task.LeaveVehicle(this.Kosatka, (LeaveVehicleFlags) 16);
                this.Kosatka.OpenDoor((VehicleDoor) 0, false, true);
                ((Entity) Game.Player.Character).Position = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, 29f, 2.8f));
                string dict = "anim@move_m@prison_gaurd";
                KosatkaScript.LoadDict(dict);
                Function.Call((Hash) 6410651044935755444L, Array.Empty<InputArgument>());
                Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
                Function.Call((Hash) 4362080213785518366L, Array.Empty<InputArgument>());
                Function.Call((Hash) 3211975551654944577L, new InputArgument[1]
                {
                  InputArgument.op_Implicit("default")
                });
                if (Function.Call<int>((Hash) -147535234440955034L, Array.Empty<InputArgument>()) != -1)
                  Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
                this.UnderWater = false;
                KosatkaScript.LoadDict(dict);
                Vector3 position = ((Entity) Game.Player.Character).Position;
                this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) position.X),
                  InputArgument.op_Implicit((float) position.Y),
                  InputArgument.op_Implicit((float) position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) this.Kosatka).Rotation.Z),
                  InputArgument.op_Implicit(1)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Scene3)
                  }))
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[10]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("walk"),
                  InputArgument.op_Implicit(3000.0),
                  InputArgument.op_Implicit(-2.0),
                  InputArgument.op_Implicit(128),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080),
                  InputArgument.op_Implicit(0)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[10]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit("walk"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(3000.0),
                  InputArgument.op_Implicit(-2f),
                  InputArgument.op_Implicit(-2f),
                  InputArgument.op_Implicit((float) ((Entity) this.Kosatka).Rotation.Z),
                  InputArgument.op_Implicit(1148846080),
                  InputArgument.op_Implicit(0)
                });
                Game.Player.Character.Weapons.Select(Game.Player.Character.Weapons.BestWeapon);
                if (this.UsingPeriscope)
                {
                  Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                  {
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(3000),
                    InputArgument.op_Implicit(1),
                    InputArgument.op_Implicit(0)
                  });
                  ((Entity) Game.Player.Character).IsInvincible = false;
                  ((Entity) Game.Player.Character).IsVisible = true;
                  this.DroneCam.Destroy();
                  this.UsingPeriscope = false;
                }
                this.MOCPosSave = ((Entity) this.Kosatka).Position;
                this.Spawn = this.MOCPosSave;
                this.X = (float) this.Spawn.X;
                this.Config.SetValue<float>("Setup", "X", (M0) (double) this.X);
                this.Y = (float) this.Spawn.Y;
                this.Config.SetValue<float>("Setup", "Y", (M0) (double) this.Y);
                this.Z = (float) this.Spawn.Z;
                this.Config.SetValue<float>("Setup", "Z", (M0) (double) this.Z);
                this.Config.SetValue<Vector3>("Setup", "SavePosition", (M0) this.MOCPosSave);
                this.Config.Save();
                this.VHeading = ((Entity) this.Kosatka).Heading;
                this.Config.SetValue<float>("Setup", "VHeading", (M0) (double) this.VHeading);
                this.Config.Save();
                Script.Wait(2200);
                this.IsInInterior = false;
                Game.Player.Character.Task.ClearAll();
                this.Kosatka.CloseDoor((VehicleDoor) 0, false);
                ((Entity) this.Kosatka).FreezePosition = false;
                ((Entity) Game.Player.Character).FreezePosition = false;
              }
              if (((Entity) this.Kosatka).Position.Z <= -14.0)
              {
                ((Entity) this.Kosatka).FreezePosition = true;
                this.Kosatka.Speed = 0.0f;
                ((Entity) Game.Player.Character).HasCollision = false;
                Game.Player.Character.Task.LeaveVehicle(this.Kosatka, (LeaveVehicleFlags) 16);
                this.Kosatka.OpenDoor((VehicleDoor) 0, false, true);
                ((Entity) Game.Player.Character).Position = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, 33f, 1.8f));
                Function.Call((Hash) 6410651044935755444L, Array.Empty<InputArgument>());
                Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
                Function.Call((Hash) 4362080213785518366L, Array.Empty<InputArgument>());
                Function.Call((Hash) 3211975551654944577L, new InputArgument[1]
                {
                  InputArgument.op_Implicit("default")
                });
                if (Function.Call<int>((Hash) -147535234440955034L, Array.Empty<InputArgument>()) != -1)
                  Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
                this.UnderWater = false;
                string dict = "missheistdocks2a@swimtocontainer";
                KosatkaScript.LoadDict(dict);
                KosatkaScript.LoadDict(dict);
                Vector3 position = ((Entity) Game.Player.Character).Position;
                this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
                {
                  InputArgument.op_Implicit((float) position.X),
                  InputArgument.op_Implicit((float) position.Y),
                  InputArgument.op_Implicit((float) position.Z),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit(0.0),
                  InputArgument.op_Implicit((float) ((Entity) this.Kosatka).Rotation.Z),
                  InputArgument.op_Implicit(1)
                });
                Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(this.Scene3)
                  }))
                });
                Function.Call((Hash) -1249422255215503276L, new InputArgument[10]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit("michael_swim_to_container"),
                  InputArgument.op_Implicit(3000.0),
                  InputArgument.op_Implicit(-2.0),
                  InputArgument.op_Implicit(128),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(1148846080),
                  InputArgument.op_Implicit(0)
                });
                Function.Call((Hash) -4073751461268206970L, new InputArgument[10]
                {
                  InputArgument.op_Implicit(Game.Player.Character),
                  InputArgument.op_Implicit(this.Scene3),
                  InputArgument.op_Implicit("michael_swim_to_container"),
                  InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                  InputArgument.op_Implicit(3000.0),
                  InputArgument.op_Implicit(-2f),
                  InputArgument.op_Implicit(-2f),
                  InputArgument.op_Implicit((float) ((Entity) this.Kosatka).Rotation.Z),
                  InputArgument.op_Implicit(1148846080),
                  InputArgument.op_Implicit(0)
                });
                Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
                if (this.UsingPeriscope)
                {
                  Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                  {
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(3000),
                    InputArgument.op_Implicit(1),
                    InputArgument.op_Implicit(0)
                  });
                  ((Entity) Game.Player.Character).IsInvincible = false;
                  ((Entity) Game.Player.Character).IsVisible = true;
                  this.DroneCam.Destroy();
                  this.UsingPeriscope = false;
                }
                this.MOCPosSave = ((Entity) this.Kosatka).Position;
                this.Spawn = this.MOCPosSave;
                this.X = (float) this.Spawn.X;
                this.Config.SetValue<float>("Setup", "X", (M0) (double) this.X);
                this.Y = (float) this.Spawn.Y;
                this.Config.SetValue<float>("Setup", "Y", (M0) (double) this.Y);
                this.Z = (float) this.Spawn.Z;
                this.Config.SetValue<float>("Setup", "Z", (M0) (double) this.Z);
                this.Config.SetValue<Vector3>("Setup", "SavePosition", (M0) this.MOCPosSave);
                this.Config.Save();
                this.VHeading = ((Entity) this.Kosatka).Heading;
                this.Config.SetValue<float>("Setup", "VHeading", (M0) (double) this.VHeading);
                this.Config.Save();
                Script.Wait(2200);
                this.IsInInterior = false;
                Game.Player.Character.Task.ClearAll();
                this.Kosatka.CloseDoor((VehicleDoor) 0, false);
                ((Entity) this.Kosatka).FreezePosition = false;
                ((Entity) Game.Player.Character).FreezePosition = false;
                ((Entity) Game.Player.Character).HasCollision = true;
              }
            }
          }
        }
        if (!this.HoldToEnterInterior)
        {
          if (Game.IsControlPressed(2, (Control) 75))
          {
            ++this.HoldDelay;
            if (this.HoldDelay == 30)
            {
              this.HoldDelay = 0;
              Game.FadeScreenOut(500);
              Script.Wait(500);
              this.CanUseInteriorPeriscope = true;
              Script.Wait(500);
              ((Entity) Game.Player.Character).Position = new Vector3(1557.997f, 404.82f, -49.68f);
              this.HoldDelay = 0;
              this.Kosatka.Speed = 0.0f;
              ((Entity) Game.Player.Character).HasCollision = false;
              Function.Call((Hash) 6410651044935755444L, Array.Empty<InputArgument>());
              Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
              Function.Call((Hash) 4362080213785518366L, Array.Empty<InputArgument>());
              Function.Call((Hash) 3211975551654944577L, new InputArgument[1]
              {
                InputArgument.op_Implicit("default")
              });
              if (Function.Call<int>((Hash) -147535234440955034L, Array.Empty<InputArgument>()) != -1)
                Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
              this.UnderWater = false;
              ((Entity) Game.Player.Character).HasCollision = true;
              ((Entity) Game.Player.Character).Position = new Vector3(1559.427f, 381.3182f, -50.68f);
              ((Entity) Game.Player.Character).Heading = 0.0f;
              this.IsInInterior = true;
              this.CreatedChairs = false;
              this.CreatedChairs = true;
              if (Entity.op_Inequality((Entity) this.Chair1, (Entity) null))
                ((Entity) this.Chair1).Delete();
              if (Entity.op_Inequality((Entity) this.Chair2, (Entity) null))
                ((Entity) this.Chair2).Delete();
              if (Entity.op_Inequality((Entity) this.Chair3, (Entity) null))
                ((Entity) this.Chair3).Delete();
              if (Entity.op_Inequality((Entity) this.Chair4, (Entity) null))
                ((Entity) this.Chair4).Delete();
              if (Entity.op_Inequality((Entity) this.Chair5, (Entity) null))
                ((Entity) this.Chair5).Delete();
              if (Entity.op_Inequality((Entity) this.Chair6, (Entity) null))
                ((Entity) this.Chair6).Delete();
              if (Entity.op_Inequality((Entity) this.Chair7, (Entity) null))
                ((Entity) this.Chair7).Delete();
              if (Entity.op_Inequality((Entity) this.Chair8, (Entity) null))
                ((Entity) this.Chair8).Delete();
              if (Entity.op_Inequality((Entity) this.Chair9, (Entity) null))
                ((Entity) this.Chair9).Delete();
              if (Entity.op_Inequality((Entity) this.Chair10, (Entity) null))
                ((Entity) this.Chair10).Delete();
              if (Entity.op_Inequality((Entity) this.Console1, (Entity) null))
                ((Entity) this.Console1).Delete();
              if (Entity.op_Inequality((Entity) this.Console2, (Entity) null))
                ((Entity) this.Console2).Delete();
              if (Entity.op_Inequality((Entity) this.Console3, (Entity) null))
                ((Entity) this.Console3).Delete();
              this.Chair1 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_02"), new Vector3(1558.718f, 388.6768f, -50.68f), new Vector3(0.0f, 0.0f, -90f), false, false);
              ((Entity) this.Chair1).FreezePosition = true;
              this.Chair2 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_02"), new Vector3(1558.765f, 387.4181f, -50.68f), new Vector3(0.0f, 0.0f, -90f), false, false);
              ((Entity) this.Chair2).FreezePosition = true;
              this.Chair3 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1558.862f, 385.974f, -50.68f), new Vector3(0.0f, 0.0f, -90f), false, false);
              ((Entity) this.Chair3).FreezePosition = true;
              this.Chair4 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1558.751f, 384.6591f, -50.68f), new Vector3(0.0f, 0.0f, -90f), false, false);
              ((Entity) this.Chair4).FreezePosition = true;
              this.Chair5 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1558.74f, 383.2693f, -50.68727f), new Vector3(0.0f, 0.0f, -90f), false, false);
              ((Entity) this.Chair5).FreezePosition = true;
              this.Chair7 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1558.801f, 382.0339f, -50.68f), new Vector3(0.0f, 0.0f, -90f), false, false);
              ((Entity) this.Chair7).FreezePosition = true;
              this.Chair8 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_02"), new Vector3(1559.427f, 381.3182f, -50.68f), new Vector3(0.0f, 0.0f, 0.0f), false, false);
              ((Entity) this.Chair8).FreezePosition = true;
              this.Chair9 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1564.07f, 386.1208f, -50.68f), new Vector3(0.0f, 0.0f, 98f), false, false);
              ((Entity) this.Chair9).FreezePosition = true;
              this.Chair10 = World.CreateProp(this.RequestModel("h4_int_lev_sub_chair_01"), new Vector3(1564.01f, 384.9416f, -50.68727f), new Vector3(0.0f, 0.0f, 90f), false, false);
              ((Entity) this.Chair10).FreezePosition = true;
              int num = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
              {
                InputArgument.op_Implicit(1561.541f),
                InputArgument.op_Implicit(419.4447f),
                InputArgument.op_Implicit(-55.30978f)
              });
              this.Console1 = World.CreateProp(this.RequestModel("h4_prop_h4_console_01a"), new Vector3(1557.958f, 388.6993f, -49.93543f), new Vector3(0.0f, 0.0f, 90f), false, false);
              this.Console2 = World.CreateProp(this.RequestModel("h4_prop_h4_console_01a"), new Vector3(1557.958f, 387.3052f, -49.93543f), new Vector3(0.0f, 0.0f, 90f), false, false);
              this.Console3 = World.CreateProp(this.RequestModel("h4_prop_h4_console_01a"), new Vector3(1559.388f, 380.5829f, -49.93543f), new Vector3(0.0f, 0.0f, 180f), false, false);
              foreach (Prop chest in this.Chests)
              {
                if (Entity.op_Inequality((Entity) chest, (Entity) null))
                  ((Entity) chest).Delete();
              }
              if (this.ShowTreasureCollectioninSub)
              {
                Prop prop1 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), new Vector3(1563.3f, 400.4742f, -50.6f), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                this.Chests.Add(prop1);
                ((Entity) prop1).IsVisible = false;
                ((Entity) prop1).FreezePosition = true;
                if (this.ChestCollected >= 1 && this.ChestCollected < 7)
                  ((Entity) prop1).IsVisible = true;
                if (this.ChestCollected >= 2 && this.ChestCollected < 16)
                {
                  Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, 0.0f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop2);
                  ((Entity) prop2).FreezePosition = true;
                }
                if (this.ChestCollected >= 3)
                {
                  Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(-0.5f, 0.0f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop2);
                  ((Entity) prop2).FreezePosition = true;
                }
                if (this.ChestCollected >= 4)
                {
                  Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, 0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop2);
                  ((Entity) prop2).FreezePosition = true;
                }
                if (this.ChestCollected >= 5 && this.ChestCollected < 24)
                {
                  Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, -0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop2);
                  ((Entity) prop2).FreezePosition = true;
                }
                if (this.ChestCollected >= 6)
                {
                  Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a_land"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, 0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
                  Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, 0.3f, 0.05f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop2);
                  ((Entity) prop2).FreezePosition = true;
                  this.Chests.Add(prop3);
                  ((Entity) prop3).FreezePosition = true;
                }
                if (this.ChestCollected >= 7)
                {
                  Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop2);
                  ((Entity) prop2).FreezePosition = true;
                }
                if (this.ChestCollected >= 9)
                {
                  Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(-0.5f, 0.0f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop2);
                  ((Entity) prop2).FreezePosition = true;
                  Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(-0.5f, 0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop3);
                  ((Entity) prop3).FreezePosition = true;
                }
                if (this.ChestCollected >= 11)
                {
                  Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, 0.6f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop2);
                  ((Entity) prop2).FreezePosition = true;
                  Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a_land"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, 0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
                  Prop prop4 = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, 0.3f, 0.23f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop3);
                  ((Entity) prop3).FreezePosition = true;
                  this.Chests.Add(prop4);
                  ((Entity) prop4).FreezePosition = true;
                }
                if (this.ChestCollected >= 12 && this.ChestCollected < 24)
                {
                  Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, -0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop2);
                  ((Entity) prop2).FreezePosition = true;
                }
                if (this.ChestCollected >= 13)
                {
                  Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a_land"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, 0.0f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
                  Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, 0.0f, 0.23f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop2);
                  ((Entity) prop2).FreezePosition = true;
                  this.Chests.Add(prop3);
                  ((Entity) prop3).FreezePosition = true;
                }
                if (this.ChestCollected >= 16)
                {
                  Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, 0.0f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop2);
                  ((Entity) prop2).FreezePosition = true;
                  Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, 0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop3);
                  ((Entity) prop3).FreezePosition = true;
                  Prop prop4 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, 0.0f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop4);
                  ((Entity) prop4).FreezePosition = true;
                }
                if (this.ChestCollected >= 18)
                {
                  Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a_land"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, 0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
                  Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, 0.3f, 0.23f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop2);
                  ((Entity) prop2).FreezePosition = true;
                  this.Chests.Add(prop3);
                  ((Entity) prop3).FreezePosition = true;
                }
                if (this.ChestCollected >= 24)
                {
                  Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, -0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop2);
                  ((Entity) prop2).FreezePosition = true;
                  Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, -0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop3);
                  ((Entity) prop3).FreezePosition = true;
                  Prop prop4 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, -0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop4);
                  ((Entity) prop4).FreezePosition = true;
                  Prop prop5 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.0f, -0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop5);
                  ((Entity) prop5).FreezePosition = true;
                  Prop prop6 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(-0.5f, -0.3f, 0.18f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop6);
                  ((Entity) prop6).FreezePosition = true;
                  Prop prop7 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(-1f, -0.3f, 0.0f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop7);
                  ((Entity) prop7).FreezePosition = true;
                }
                if (this.ChestCollected >= 26)
                {
                  Prop prop2 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(0.5f, -0.3f, 0.36f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop2);
                  ((Entity) prop2).FreezePosition = true;
                  Prop prop3 = World.CreateProp(this.RequestModel("h4_prop_h4_chest_01a_land"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, -0.3f, 0.36f)), new Vector3(0.0f, 0.0f, 0.0f), false, false);
                  Prop prop4 = World.CreateProp(this.RequestModel("h4_prop_h4_gold_pile_01a"), ((Entity) prop1).GetOffsetInWorldCoords(new Vector3(1f, -0.3f, 0.41f)), new Vector3(0.0f, 0.0f, 0.0f), true, false);
                  this.Chests.Add(prop3);
                  ((Entity) prop3).FreezePosition = true;
                  this.Chests.Add(prop4);
                  ((Entity) prop4).FreezePosition = true;
                }
              }
              while (Entity.op_Equality((Entity) this.Chair8, (Entity) null))
                Script.Wait(1);
              Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
              this.PlayingConsoleIdleAnim_8 = true;
              string dict = "anim@scripted@submarine@ig28_submarine_turret_control@male@";
              KosatkaScript.LoadDict(dict);
              Prop chair8 = this.Chair8;
              this.ExitChair = this.Chair8;
              this.Chair8_Scene = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
              {
                InputArgument.op_Implicit((float) ((Entity) chair8).Position.X),
                InputArgument.op_Implicit((float) ((Entity) chair8).Position.Y),
                InputArgument.op_Implicit((float) ((Entity) chair8).Position.Z),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit((float) ((Entity) chair8).Rotation.Z),
                InputArgument.op_Implicit(2)
              });
              Function.Call((Hash) -1249422255215503276L, new InputArgument[8]
              {
                InputArgument.op_Implicit(Game.Player.Character),
                InputArgument.op_Implicit(this.Chair8_Scene),
                InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                InputArgument.op_Implicit("computer_enter"),
                InputArgument.op_Implicit(16f),
                InputArgument.op_Implicit(-16f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(1148846080)
              });
              Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
              {
                InputArgument.op_Implicit(Game.Player.Character),
                InputArgument.op_Implicit(this.Chair8_Scene),
                InputArgument.op_Implicit("computer_enter"),
                InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                InputArgument.op_Implicit(16f),
                InputArgument.op_Implicit(-16f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(1148846080)
              });
              Function.Call((Hash) -4073751461268206970L, new InputArgument[8]
              {
                InputArgument.op_Implicit(this.Console3),
                InputArgument.op_Implicit(this.Chair8_Scene),
                InputArgument.op_Implicit("enter_console"),
                InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                InputArgument.op_Implicit(16f),
                InputArgument.op_Implicit(-16f),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(1148846080)
              });
              Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
              this.SittinginSeat = true;
              if (this.UsingPeriscope)
              {
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                ((Entity) Game.Player.Character).IsInvincible = false;
                ((Entity) Game.Player.Character).IsVisible = true;
                this.DroneCam.Destroy();
                this.UsingPeriscope = false;
              }
              this.MOCPosSave = ((Entity) this.Kosatka).Position;
              this.Spawn = this.MOCPosSave;
              this.X = (float) this.Spawn.X;
              this.Config.SetValue<float>("Setup", "X", (M0) (double) this.X);
              this.Y = (float) this.Spawn.Y;
              this.Config.SetValue<float>("Setup", "Y", (M0) (double) this.Y);
              this.Z = (float) this.Spawn.Z;
              this.Config.SetValue<float>("Setup", "Z", (M0) (double) this.Z);
              this.Config.SetValue<Vector3>("Setup", "SavePosition", (M0) this.MOCPosSave);
              this.Config.Save();
              this.VHeading = ((Entity) this.Kosatka).Heading;
              this.Config.SetValue<float>("Setup", "VHeading", (M0) (double) this.VHeading);
              this.Config.Save();
              Script.Wait(100);
              this.IsInInterior = false;
              ((Entity) this.Kosatka).FreezePosition = false;
              Script.Wait(500);
              Game.FadeScreenIn(500);
            }
          }
          if (Game.IsControlJustReleased(2, (Control) 75))
          {
            if (((Entity) this.Kosatka).Position.Z > -14.0)
            {
              ((Entity) this.Kosatka).FreezePosition = true;
              this.Kosatka.Speed = 0.0f;
              Game.Player.Character.Task.LeaveVehicle(this.Kosatka, (LeaveVehicleFlags) 16);
              this.Kosatka.OpenDoor((VehicleDoor) 0, false, true);
              ((Entity) Game.Player.Character).Position = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, 29f, 2.8f));
              string dict = "anim@move_m@prison_gaurd";
              KosatkaScript.LoadDict(dict);
              Function.Call((Hash) 6410651044935755444L, Array.Empty<InputArgument>());
              Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
              Function.Call((Hash) 4362080213785518366L, Array.Empty<InputArgument>());
              Function.Call((Hash) 3211975551654944577L, new InputArgument[1]
              {
                InputArgument.op_Implicit("default")
              });
              if (Function.Call<int>((Hash) -147535234440955034L, Array.Empty<InputArgument>()) != -1)
                Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
              this.UnderWater = false;
              KosatkaScript.LoadDict(dict);
              Vector3 position = ((Entity) Game.Player.Character).Position;
              this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
              {
                InputArgument.op_Implicit((float) position.X),
                InputArgument.op_Implicit((float) position.Y),
                InputArgument.op_Implicit((float) position.Z),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit((float) ((Entity) this.Kosatka).Rotation.Z),
                InputArgument.op_Implicit(1)
              });
              Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
              {
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(this.Scene3)
                }))
              });
              Function.Call((Hash) -1249422255215503276L, new InputArgument[10]
              {
                InputArgument.op_Implicit(Game.Player.Character),
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                InputArgument.op_Implicit("walk"),
                InputArgument.op_Implicit(3000.0),
                InputArgument.op_Implicit(-2.0),
                InputArgument.op_Implicit(128),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(1148846080),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) -4073751461268206970L, new InputArgument[10]
              {
                InputArgument.op_Implicit(Game.Player.Character),
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit("walk"),
                InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                InputArgument.op_Implicit(3000.0),
                InputArgument.op_Implicit(-2f),
                InputArgument.op_Implicit(-2f),
                InputArgument.op_Implicit((float) ((Entity) this.Kosatka).Rotation.Z),
                InputArgument.op_Implicit(1148846080),
                InputArgument.op_Implicit(0)
              });
              Game.Player.Character.Weapons.Select(Game.Player.Character.Weapons.BestWeapon);
              if (this.UsingPeriscope)
              {
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                ((Entity) Game.Player.Character).IsInvincible = false;
                ((Entity) Game.Player.Character).IsVisible = true;
                this.DroneCam.Destroy();
                this.UsingPeriscope = false;
              }
              this.MOCPosSave = ((Entity) this.Kosatka).Position;
              this.Spawn = this.MOCPosSave;
              this.X = (float) this.Spawn.X;
              this.Config.SetValue<float>("Setup", "X", (M0) (double) this.X);
              this.Y = (float) this.Spawn.Y;
              this.Config.SetValue<float>("Setup", "Y", (M0) (double) this.Y);
              this.Z = (float) this.Spawn.Z;
              this.Config.SetValue<float>("Setup", "Z", (M0) (double) this.Z);
              this.Config.SetValue<Vector3>("Setup", "SavePosition", (M0) this.MOCPosSave);
              this.Config.Save();
              this.VHeading = ((Entity) this.Kosatka).Heading;
              this.Config.SetValue<float>("Setup", "VHeading", (M0) (double) this.VHeading);
              this.Config.Save();
              Script.Wait(2200);
              this.IsInInterior = false;
              Game.Player.Character.Task.ClearAll();
              this.Kosatka.CloseDoor((VehicleDoor) 0, false);
              ((Entity) this.Kosatka).FreezePosition = false;
              ((Entity) Game.Player.Character).FreezePosition = false;
            }
            if (((Entity) this.Kosatka).Position.Z <= -14.0)
            {
              ((Entity) this.Kosatka).FreezePosition = true;
              this.Kosatka.Speed = 0.0f;
              ((Entity) Game.Player.Character).HasCollision = false;
              Game.Player.Character.Task.LeaveVehicle(this.Kosatka, (LeaveVehicleFlags) 16);
              this.Kosatka.OpenDoor((VehicleDoor) 0, false, true);
              ((Entity) Game.Player.Character).Position = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, 33f, 1.8f));
              Function.Call((Hash) 6410651044935755444L, Array.Empty<InputArgument>());
              Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
              Function.Call((Hash) 4362080213785518366L, Array.Empty<InputArgument>());
              Function.Call((Hash) 3211975551654944577L, new InputArgument[1]
              {
                InputArgument.op_Implicit("default")
              });
              if (Function.Call<int>((Hash) -147535234440955034L, Array.Empty<InputArgument>()) != -1)
                Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
              this.UnderWater = false;
              string dict = "missheistdocks2a@swimtocontainer";
              KosatkaScript.LoadDict(dict);
              KosatkaScript.LoadDict(dict);
              Vector3 position = ((Entity) Game.Player.Character).Position;
              this.Scene3 = (int) Function.Call<int>((Hash) -8351678148772176525L, new InputArgument[7]
              {
                InputArgument.op_Implicit((float) position.X),
                InputArgument.op_Implicit((float) position.Y),
                InputArgument.op_Implicit((float) position.Z),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit(0.0),
                InputArgument.op_Implicit((float) ((Entity) this.Kosatka).Rotation.Z),
                InputArgument.op_Implicit(1)
              });
              Function.Call((Hash) 8305362243532093136L, new InputArgument[2]
              {
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit((int) Function.Call<int>((Hash) -1971713855839374388L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(this.Scene3)
                }))
              });
              Function.Call((Hash) -1249422255215503276L, new InputArgument[10]
              {
                InputArgument.op_Implicit(Game.Player.Character),
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                InputArgument.op_Implicit("michael_swim_to_container"),
                InputArgument.op_Implicit(3000.0),
                InputArgument.op_Implicit(-2.0),
                InputArgument.op_Implicit(128),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(1148846080),
                InputArgument.op_Implicit(0)
              });
              Function.Call((Hash) -4073751461268206970L, new InputArgument[10]
              {
                InputArgument.op_Implicit(Game.Player.Character),
                InputArgument.op_Implicit(this.Scene3),
                InputArgument.op_Implicit("michael_swim_to_container"),
                InputArgument.op_Implicit(KosatkaScript.LoadDict(dict)),
                InputArgument.op_Implicit(3000.0),
                InputArgument.op_Implicit(-2f),
                InputArgument.op_Implicit(-2f),
                InputArgument.op_Implicit((float) ((Entity) this.Kosatka).Rotation.Z),
                InputArgument.op_Implicit(1148846080),
                InputArgument.op_Implicit(0)
              });
              Game.Player.Character.Weapons.Select((WeaponHash) -1569615261, true);
              if (this.UsingPeriscope)
              {
                Function.Call((Hash) 569060033405794044L, new InputArgument[5]
                {
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(0),
                  InputArgument.op_Implicit(3000),
                  InputArgument.op_Implicit(1),
                  InputArgument.op_Implicit(0)
                });
                ((Entity) Game.Player.Character).IsInvincible = false;
                ((Entity) Game.Player.Character).IsVisible = true;
                this.DroneCam.Destroy();
                this.UsingPeriscope = false;
              }
              this.MOCPosSave = ((Entity) this.Kosatka).Position;
              this.Spawn = this.MOCPosSave;
              this.X = (float) this.Spawn.X;
              this.Config.SetValue<float>("Setup", "X", (M0) (double) this.X);
              this.Y = (float) this.Spawn.Y;
              this.Config.SetValue<float>("Setup", "Y", (M0) (double) this.Y);
              this.Z = (float) this.Spawn.Z;
              this.Config.SetValue<float>("Setup", "Z", (M0) (double) this.Z);
              this.Config.SetValue<Vector3>("Setup", "SavePosition", (M0) this.MOCPosSave);
              this.Config.Save();
              this.VHeading = ((Entity) this.Kosatka).Heading;
              this.Config.SetValue<float>("Setup", "VHeading", (M0) (double) this.VHeading);
              this.Config.Save();
              Script.Wait(2200);
              this.IsInInterior = false;
              Game.Player.Character.Task.ClearAll();
              this.Kosatka.CloseDoor((VehicleDoor) 0, false);
              ((Entity) this.Kosatka).FreezePosition = false;
              ((Entity) Game.Player.Character).FreezePosition = false;
              ((Entity) Game.Player.Character).HasCollision = true;
            }
          }
        }
      }
      if (this.IsInDroneMode && Game.IsControlJustPressed(2, (Control) 51))
      {
        ((Entity) this.Drone).IsVisible = false;
        ((Entity) Game.Player.Character).IsVisible = true;
        ((Entity) this.Drone).Delete();
        this.IsInDroneMode = false;
        this.IsInInterior = true;
        ((Entity) Game.Player.Character).Position = this.CabOptions;
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        this.DroneCam.Destroy();
        this.DisplayHelpTextThisFrame("Calling back Drone");
      }
      if (this.IsInInterior)
      {
        if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, this.ExitMoc) >= 2.0)
          ;
        if ((double) World.GetDistance(((Entity) Game.Player.Character).Position, this.CabOptions) >= 2.0)
          ;
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && Entity.op_Inequality((Entity) Game.Player.Character.CurrentVehicle, (Entity) null) && (Game.Player.Character.CurrentVehicle.DisplayName == "KOSATKA" && (double) World.GetDistance(((Entity) Game.Player.Character).Position, new Vector3(-1627f, -3000f, -78f)) < 10.0))
        this.ReadIni = true;
      if (!Entity.op_Inequality((Entity) this.VehicleinCargoBay, (Entity) null) || !this.VehicleinCargoBay.GetPedOnSeat((VehicleSeat) -1).IsPlayer)
        return;
      if (Game.IsControlJustPressed(2, (Control) 44))
        this.SaveLoad.SaveWithoutDelete();
      if (Game.IsControlJustPressed(2, (Control) 51))
      {
        this.LoadIniFile("scripts//CayoPericoInSp//Submarine.ini");
        this.MOCPosSavestring = (string) this.Config.GetValue<string>("Setup", "SavePosition", (M0) this.MOCPosSavestring);
        this.MOCPosSave = this.ToVector3(this.MOCPosSavestring);
        this.Spawn = this.MOCPosSave;
        this.X = (float) this.Config.GetValue<float>("Setup", "X", (M0) (double) this.X);
        this.Y = (float) this.Config.GetValue<float>("Setup", "Y", (M0) (double) this.Y);
        this.Z = (float) this.Config.GetValue<float>("Setup", "Z", (M0) (double) this.Z);
        Script.Wait(1);
        this.SpawnMOC();
        Game.Player.Character.CurrentVehicle.IsDriveable = true;
        ((Entity) Game.Player.Character.CurrentVehicle).Position = ((Entity) this.Kosatka).GetOffsetInWorldCoords(new Vector3(0.0f, 25f, 0.0f));
        Game.Player.Character.CurrentVehicle.PlaceOnNextStreet();
        this.VehicleinCargoBay = (Vehicle) null;
        this.SaveLoad.SavedVehicle = (Vehicle) null;
      }
    }

    private void OnShutdown(object sender, EventArgs e)
    {
      if (false)
        return;
      if (Entity.op_Inequality((Entity) this.MainBoat, (Entity) null))
        ((Entity) this.MainBoat).Delete();
      foreach (Prop chest in this.Chests)
      {
        if (Entity.op_Inequality((Entity) chest, (Entity) null))
          ((Entity) chest).Delete();
      }
      foreach (KosatkaScript.Wreck underwaterChest in this.UnderwaterChests)
      {
        if (underwaterChest.SecondaryProps.Count > 0)
        {
          foreach (Prop secondaryProp in underwaterChest.SecondaryProps)
          {
            if (Entity.op_Inequality((Entity) secondaryProp, (Entity) null))
              ((Entity) secondaryProp).Delete();
          }
        }
        if (Pickup.op_Inequality(underwaterChest.Pickup, (Pickup) null))
          underwaterChest.Pickup.Delete();
        if (Blip.op_Inequality(underwaterChest.Blip, (Blip) null))
          underwaterChest.Blip.Remove();
        if (Entity.op_Inequality((Entity) underwaterChest.Coin, (Entity) null))
          ((Entity) underwaterChest.Coin).Delete();
        if (Entity.op_Inequality((Entity) underwaterChest.Chest, (Entity) null))
          ((Entity) underwaterChest.Chest).Delete();
        if (Entity.op_Inequality((Entity) underwaterChest.GoldCoins, (Entity) null))
          ((Entity) underwaterChest.GoldCoins).Delete();
      }
      if (Entity.op_Inequality((Entity) this.GuidedMissileTarget, (Entity) null))
        ((Entity) this.GuidedMissileTarget).Delete();
      Game.Player.CanControlCharacter = true;
      Function.Call((Hash) 6410651044935755444L, Array.Empty<InputArgument>());
      Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
      Function.Call((Hash) 4362080213785518366L, Array.Empty<InputArgument>());
      Function.Call((Hash) 3211975551654944577L, new InputArgument[1]
      {
        InputArgument.op_Implicit("default")
      });
      if (Function.Call<int>((Hash) -147535234440955034L, Array.Empty<InputArgument>()) != -1)
        Function.Call((Hash) 1083088722320385809L, Array.Empty<InputArgument>());
      foreach (flame flame in this.Flames)
      {
        if (flame.Type == 2)
          Function.Call((Hash) 9220355218917582655L, new InputArgument[1]
          {
            InputArgument.op_Implicit(flame.X1)
          });
        if (flame.Type == 1)
        {
          if ((bool) Function.Call<bool>((Hash) 8408201869211353243L, new InputArgument[1]
          {
            InputArgument.op_Implicit(flame.ID)
          }))
            Function.Call((Hash) -8109406742613235306L, new InputArgument[2]
            {
              InputArgument.op_Implicit(flame.ID),
              InputArgument.op_Implicit(false)
            });
        }
      }
      if (Entity.op_Inequality((Entity) this.Missile2, (Entity) null))
        ((Entity) this.Missile2).Delete();
      if (Blip.op_Inequality(this.PurchaseMarkerBlip, (Blip) null))
        this.PurchaseMarkerBlip.Remove();
      foreach (KosatkaScript.Wreck underwaterChest in this.UnderwaterChests)
      {
        if (Blip.op_Inequality(underwaterChest.Blip, (Blip) null))
          underwaterChest.Blip.Remove();
      }
      foreach (KosatkaScript.Wreck underWaterWreck in this.UnderWaterWrecks)
      {
        if (Blip.op_Inequality(underWaterWreck.Blip, (Blip) null))
          underWaterWreck.Blip.Remove();
      }
      if (Entity.op_Inequality((Entity) this.Avisa, (Entity) null) && this.AvisaOut && (this.AvisaDestroyedTimer <= 2500 && ((Entity) this.Avisa).IsAlive))
      {
        this.AvisaDestroyedTimer = 0;
        this.AvisaOut = false;
        this.Config.SetValue<int>("Moonpool", "AvisaDestroyedTimer", (M0) this.AvisaDestroyedTimer);
        this.Config.SetValue<bool>("Moonpool", "AvisaOut", (M0) (this.AvisaOut ? 1 : 0));
        this.Config.Save();
      }
      if (Entity.op_Inequality((Entity) this.Toreador, (Entity) null) && this.ToreadorOut && (this.ToreadorDestroyedTimer <= 2500 && ((Entity) this.Toreador).IsAlive))
      {
        this.ToreadorDestroyedTimer = 0;
        this.ToreadorOut = false;
        this.Config.SetValue<int>("Moonpool", "ToreadorDestroyedTimer", (M0) this.ToreadorDestroyedTimer);
        this.Config.SetValue<bool>("Moonpool", "ToreadorOut", (M0) (this.ToreadorOut ? 1 : 0));
        this.Config.Save();
      }
      if (Entity.op_Inequality((Entity) this.Seasparrow, (Entity) null) && this.SeaSparrowOut && (this.SeaSparrowDestroyedTimer <= 2500 && ((Entity) this.Seasparrow).IsAlive))
      {
        this.SeaSparrowDestroyedTimer = 0;
        this.SeaSparrowOut = false;
        this.Config.SetValue<int>("Moonpool", "SeaSparrowDestroyedTimer", (M0) this.SeaSparrowDestroyedTimer);
        this.Config.SetValue<bool>("Moonpool", "SeaSparrowOut", (M0) (this.SeaSparrowOut ? 1 : 0));
        this.Config.Save();
      }
      if (Entity.op_Inequality((Entity) this.Avisa, (Entity) null))
        ((Entity) this.Avisa).Delete();
      if (Entity.op_Inequality((Entity) this.Toreador, (Entity) null))
        ((Entity) this.Toreador).Delete();
      if (Entity.op_Inequality((Entity) this.Seasparrow, (Entity) null))
        ((Entity) this.Seasparrow).Delete();
      if (Entity.op_Inequality((Entity) this.Missile, (Entity) null))
        ((Entity) this.Missile).Delete();
      if (Entity.op_Inequality((Entity) this.PeriscopeProp, (Entity) null))
        ((Entity) this.PeriscopeProp).Delete();
      if (Entity.op_Inequality((Entity) this.Chair1, (Entity) null))
        ((Entity) this.Chair1).Delete();
      if (Entity.op_Inequality((Entity) this.Chair2, (Entity) null))
        ((Entity) this.Chair2).Delete();
      if (Entity.op_Inequality((Entity) this.Chair3, (Entity) null))
        ((Entity) this.Chair3).Delete();
      if (Entity.op_Inequality((Entity) this.Chair4, (Entity) null))
        ((Entity) this.Chair4).Delete();
      if (Entity.op_Inequality((Entity) this.Chair5, (Entity) null))
        ((Entity) this.Chair5).Delete();
      if (Entity.op_Inequality((Entity) this.Chair6, (Entity) null))
        ((Entity) this.Chair6).Delete();
      if (Entity.op_Inequality((Entity) this.Chair7, (Entity) null))
        ((Entity) this.Chair7).Delete();
      if (Entity.op_Inequality((Entity) this.Chair8, (Entity) null))
        ((Entity) this.Chair8).Delete();
      if (Entity.op_Inequality((Entity) this.Chair9, (Entity) null))
        ((Entity) this.Chair9).Delete();
      if (Entity.op_Inequality((Entity) this.Chair10, (Entity) null))
        ((Entity) this.Chair10).Delete();
      if (Entity.op_Inequality((Entity) this.Console1, (Entity) null))
        ((Entity) this.Console1).Delete();
      if (Entity.op_Inequality((Entity) this.Console2, (Entity) null))
        ((Entity) this.Console2).Delete();
      if (Entity.op_Inequality((Entity) this.Console3, (Entity) null))
        ((Entity) this.Console3).Delete();
      if (Entity.op_Inequality((Entity) this.Console1, (Entity) null))
        ((Entity) this.Console1).Delete();
      if (Entity.op_Inequality((Entity) this.Console2, (Entity) null))
        ((Entity) this.Console2).Delete();
      if (Entity.op_Inequality((Entity) this.Chair1, (Entity) null))
        ((Entity) this.Chair1).Delete();
      if (Entity.op_Inequality((Entity) this.Chair2, (Entity) null))
        ((Entity) this.Chair2).Delete();
      if (Entity.op_Inequality((Entity) this.DroneProp, (Entity) null))
        ((Entity) this.DroneProp).Delete();
      if (Entity.op_Inequality((Entity) this.Drone, (Entity) null))
      {
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        ((Entity) Game.Player.Character).IsInvincible = false;
        ((Entity) this.Drone).IsVisible = false;
        ((Entity) Game.Player.Character).IsVisible = true;
        ((Entity) this.Drone).Delete();
        this.DroneCam.Destroy();
      }
      if (Camera.op_Inequality(this.EnterExitCam, (Camera) null))
      {
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        ((Entity) Game.Player.Character).IsInvincible = false;
        ((Entity) Game.Player.Character).IsVisible = true;
        World.RenderingCamera = (Camera) null;
        this.EnterExitCam.Destroy();
      }
      if (Blip.op_Inequality(this.MOCBlip, (Blip) null))
        this.MOCBlip.Remove();
      if (Entity.op_Inequality((Entity) this.Kosatka, (Entity) null))
        ((Entity) this.Kosatka).Delete();
      this.Created = false;
    }

    public class Wreck : Script
    {
      public List<Prop> SecondaryProps = new List<Prop>();

      public Pickup Pickup { get; set; }

      public bool WasSwimming { get; set; }

      public int UnderwaterChestScene { get; set; }

      public int Type { get; set; }

      public Prop Chest { get; set; }

      public Prop GoldCoins { get; set; }

      public Prop Coin { get; set; }

      public bool RobbingChest { get; set; }

      public bool CreatedChest { get; set; }

      public Blip Blip { get; set; }

      public bool Created { get; set; }

      public Vector3 L { get; set; }

      public Wreck()
      {
      }

      public Wreck(Vector3 Location)
      {
        this.Created = false;
        this.L = Location;
      }
    }

    public enum Nodetype
    {
      AnyRoad,
      Road,
      Offroad,
      Water,
    }
  }
}
