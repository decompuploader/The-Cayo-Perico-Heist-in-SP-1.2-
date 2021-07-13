using GTA;
using GTA.Math;
using GTA.Native;
using NativeUI;
using System;
using System.Drawing;

namespace CayoPericoHeistInSP
{
  public class MissionScreen : Script
  {
    public Vector3 GetawayCarKosatkaSpawn = new Vector3(2701.902f, -361.279f, -55.5f);
    public float GetawayCarKosatkaHeading = 90f;
    public bool Ach_Fleeca_Bronze;
    public bool Ach_Fleeca_Silver;
    public bool Ach_Fleeca_Gold;
    public bool Ach_Fleeca_Shoottell;
    public bool Ach_Paleto_Bronze;
    public bool Ach_Paleto_Silver;
    public bool Ach_Paleto_Gold;
    public bool Ach_Paleto_Boat;
    public bool Ach_PacStandard_Bronze;
    public bool Ach_PacStandard_Silver;
    public bool Ach_PacStandard_Gold;
    public bool Ach_PacStandard_ShootMan;
    public bool Ach_JewelStore_Bronze;
    public bool Ach_JewelStore_Silver;
    public bool Ach_JewelStore_Gold;
    public bool Ach_JewelStore_NoWantedResponce;
    public bool Ach_UnionDp_Bronze;
    public bool Ach_UnionDp_Silver;
    public bool Ach_UnionDp_Gold;
    public bool Ach_UnionDp_UseTunnelEscape;
    public bool Ach_LuxRaid_Bronze;
    public bool Ach_LuxRaid_Silver;
    public bool Ach_LuxRaid_Gold;
    public bool Ach_LuxRaid_NoFailHack;
    public bool Ach_ServerDown_Bronze;
    public bool Ach_ServerDown_Silver;
    public bool Ach_ServerDown_Gold;
    public bool Ach_ServerDown_NoFailHack;
    public bool Ach_NuclExp_Bronze;
    public bool Ach_NuclExp_Silver;
    public bool Ach_NuclExp_Gold;
    public bool Ach_HumLabs_Bronze;
    public bool Ach_HumLabs_Silver;
    public bool Ach_HumLabs_Gold;
    public bool Ach_DeepDeapths_Bronze;
    public bool Ach_DeepDeapths_Silver;
    public bool Ach_DeepDeapths_Gold;
    public bool Ach_YachtHeist_Bronze;
    public bool Ach_YachtHeist_Silver;
    public bool Ach_YachtHeist_Gold;
    public bool Ach_YachtHeist_ExtraLoot;
    public bool Ach_BlkJob_Bronze;
    public bool Ach_BlkJob_Silver;
    public bool Ach_BlkJob_Gold;
    public bool Ach_BlkJob_NoWantedResponce;
    public bool Ach_CasinoHeist_Bronze;
    public bool Ach_CasinoHeist_Silver;
    public bool Ach_CasinoHeist_Gold;
    public bool Ach_CasinoHeist_ExtraLoot;
    public bool Ach_CasinoHeist_NoWantedResponce;
    public bool Ach_PrisonB_Bronze;
    public bool Ach_PrisonB_Silver;
    public bool Ach_PrisonB_Gold;
    public bool Ach_PrisonB_Rashkovsky_MinimalDamage;
    public bool Ach_NorthY_Bronze;
    public bool Ach_NorthY_Silver;
    public bool Ach_NorthY_Gold;
    public bool Ach_NorthY_NoWantedResponce;
    public bool Ach_CayoP_Bronze;
    public bool Ach_CayoP_Silver;
    public bool Ach_CayoP_Gold;
    public bool Ach_CayoP_NoGuardKills;
    public bool Ach_CayoP_NoCompoundDetection;
    public bool Ach_CayoP_NoFailHack;
    public float MaxHp;
    public float MaxArmour;
    public bool ShowCCTVBlipAliveDebug;
    public bool ShowCCTVBlipDeadDebug;
    public bool ShowPacificStandardVaultDebug;
    public bool CreateUnionDepositoryBlocker;
    public bool ShowTimeronShiftX;
    public bool AIinCasinoHeistCanWander;
    public int AIinCasinoWanderChance;
    public int AIinCasinoWanderRadius;
    private ScriptSettings Config;
    public bool Fail;
    public bool Pass;
    public bool FailSetup;
    public bool PassSetup;
    public int FleecaBestTime;
    public int PacificStandardBestTime;
    public int PaletoBestTime;
    public int VangelicoBestTime;
    public int UnionDelpositioryBestTime;
    public int LEXIGTONRAIDBestTime;
    public int SURVERDOWNBestTime;
    public int NUCLEAREXPANSIONHEISTBestTime;
    public int DEEPDEAPTHSHEISTBestTime;
    public int HUMANELABS2BestTime;
    public int YachtHeistBestTime;
    public int BerkraneJobBestTime;
    public int DiamondHeistBestTime;
    public int PrisonBreakBestTime;
    public int ContainerHeistBestTime;
    public int HumaneLabsOnlineBestTime;
    public int NorthYanktonBestTime;
    public int CayoPericoHeistBestTime;
    public int BestTime = 0;
    public string m;
    public int p;
    public string r;
    public int Timer;
    public float t;
    public int H;
    public int c;
    public int cp;
    public int ptc;
    public int AIselected;

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
      int alpha)
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
        InputArgument.op_Implicit(0)
      });
    }

    private void drawText(string text, float x, float y, float scale, int r, int g, int b)
    {
      Function.Call((Hash) 2736978246810207435L, new InputArgument[1]
      {
        InputArgument.op_Implicit("STRING")
      });
      Function.Call((Hash) 7789129354908300458L, new InputArgument[1]
      {
        InputArgument.op_Implicit(text)
      });
      Function.Call((Hash) -4725643803099155390L, new InputArgument[4]
      {
        InputArgument.op_Implicit(r),
        InputArgument.op_Implicit(g),
        InputArgument.op_Implicit(b),
        InputArgument.op_Implicit((int) byte.MaxValue)
      });
      Function.Call((Hash) 560759698880214217L, new InputArgument[2]
      {
        InputArgument.op_Implicit(0.0f),
        InputArgument.op_Implicit(scale)
      });
      Function.Call((Hash) -3674552073055540649L, new InputArgument[3]
      {
        InputArgument.op_Implicit(x),
        InputArgument.op_Implicit(y),
        InputArgument.op_Implicit(0.1)
      });
    }

    public void ShowCopsTimeUntill(string UntillWhat, int Waittime)
    {
      this.drawSprite2("timerbars", "all_black_bg", 0.89f, 0.97f, 0.21f, 0.04f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 130);
      this.drawSprite2("timerbars", "all_black_bg", 0.89f, 0.97f, 0.21f, 0.04f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 130);
      this.drawSprite2("timerbars", "all_black_bg", 0.89f, 0.97f, 0.21f, 0.04f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 130);
      TimeSpan timeSpan = TimeSpan.FromSeconds((double) Waittime);
      this.drawText(UntillWhat + " " + timeSpan.ToString(), 0.805f, 0.961f, 0.3f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    }

    public void ShowCopsTimeUntill_AndVault(
      string UntillWhat,
      string UntillWhat2,
      int Waittime,
      int Waittime2)
    {
      this.drawSprite2("timerbars", "all_black_bg", 0.89f, 0.95f, 0.21f, 0.08f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 130);
      this.drawSprite2("timerbars", "all_black_bg", 0.89f, 0.95f, 0.21f, 0.08f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 130);
      this.drawSprite2("timerbars", "all_black_bg", 0.89f, 0.95f, 0.21f, 0.08f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 130);
      TimeSpan timeSpan1 = TimeSpan.FromSeconds((double) Waittime);
      this.drawText(UntillWhat + " " + timeSpan1.ToString(), 0.89f, 0.95f, 0.3f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      TimeSpan timeSpan2 = TimeSpan.FromSeconds((double) Waittime2);
      this.drawText(UntillWhat2 + " " + timeSpan2.ToString(), 0.89f, 0.92f, 0.3f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    }

    public void ShowCopsTimeUntill_ShowTake(string UntillWhat, int Waittime, int Take)
    {
      this.drawSprite2("timerbars", "all_black_bg", 0.89f, 0.95f, 0.21f, 0.08f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 130);
      this.drawSprite2("timerbars", "all_black_bg", 0.89f, 0.95f, 0.21f, 0.08f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 130);
      this.drawSprite2("timerbars", "all_black_bg", 0.89f, 0.95f, 0.21f, 0.08f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 130);
      TimeSpan timeSpan = TimeSpan.FromSeconds((double) Waittime);
      this.drawText(UntillWhat + " " + timeSpan.ToString(), 0.89f, 0.92f, 0.3f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.drawText("Take ~g~" + Take.ToString("N"), 0.89f, 0.961f, 0.3f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    }

    public void ShowTake(int Waittime)
    {
      this.drawSprite2("timerbars", "all_black_bg", 0.89f, 0.97f, 0.21f, 0.04f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 130);
      this.drawSprite2("timerbars", "all_black_bg", 0.89f, 0.97f, 0.21f, 0.04f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 130);
      this.drawSprite2("timerbars", "all_black_bg", 0.89f, 0.97f, 0.21f, 0.04f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 130);
      this.drawText("Take ~g~" + Waittime.ToString("N"), 0.805f, 0.961f, 0.3f, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    }

    public void LoadIniFile(string iniName)
    {
      try
      {
        this.Config = ScriptSettings.Load(iniName);
        this.FleecaBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "FLEECA", (M0) this.FleecaBestTime);
        this.PaletoBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "PALETO", (M0) this.PaletoBestTime);
        this.PacificStandardBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "PACIFICSTANDARD", (M0) this.PacificStandardBestTime);
        this.VangelicoBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "VANGELICO", (M0) this.VangelicoBestTime);
        this.UnionDelpositioryBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "UNIONDEPOSITORY", (M0) this.UnionDelpositioryBestTime);
        this.LEXIGTONRAIDBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "LEXIGTONRAID", (M0) this.LEXIGTONRAIDBestTime);
        this.SURVERDOWNBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "SURVERDOWN", (M0) this.SURVERDOWNBestTime);
        this.NUCLEAREXPANSIONHEISTBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "NUCLEAREXPANSIONHEIST", (M0) this.NUCLEAREXPANSIONHEISTBestTime);
        this.DEEPDEAPTHSHEISTBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "DEEPDEAPTHSHEIST", (M0) this.DEEPDEAPTHSHEISTBestTime);
        this.HUMANELABS2BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "HUMANELABS#2", (M0) this.HUMANELABS2BestTime);
        this.YachtHeistBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "YachtHeist", (M0) this.YachtHeistBestTime);
        this.BerkraneJobBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "BerkraneJob", (M0) this.BerkraneJobBestTime);
        this.DiamondHeistBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "DiamondHeist", (M0) this.DiamondHeistBestTime);
        this.ContainerHeistBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "ContainerHeist", (M0) this.ContainerHeistBestTime);
        this.PrisonBreakBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "PrisonBreak", (M0) this.PrisonBreakBestTime);
        this.HumaneLabsOnlineBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "HUMANELABSONLINE", (M0) this.HumaneLabsOnlineBestTime);
        this.NorthYanktonBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "NorthYankton", (M0) this.NorthYanktonBestTime);
        this.CayoPericoHeistBestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "CayoPericoHeist", (M0) this.CayoPericoHeistBestTime);
        this.MaxHp = (float) this.Config.GetValue<float>("Misc", "MaxHp", (M0) (double) this.MaxHp);
        this.MaxArmour = (float) this.Config.GetValue<float>("Misc", "MaxArmour", (M0) (double) this.MaxArmour);
        this.ShowCCTVBlipAliveDebug = (bool) this.Config.GetValue<bool>("Misc", "ShowCCTVBlipAliveDebug", (M0) (this.ShowCCTVBlipAliveDebug ? 1 : 0));
        this.ShowCCTVBlipDeadDebug = (bool) this.Config.GetValue<bool>("Misc", "ShowCCTVBlipDeadDebug", (M0) (this.ShowCCTVBlipDeadDebug ? 1 : 0));
        this.ShowPacificStandardVaultDebug = (bool) this.Config.GetValue<bool>("Misc", "ShowPacificStandardVaultDebug", (M0) (this.ShowPacificStandardVaultDebug ? 1 : 0));
        this.CreateUnionDepositoryBlocker = (bool) this.Config.GetValue<bool>("Misc", "CreateUnionDepositoryBlocker", (M0) (this.CreateUnionDepositoryBlocker ? 1 : 0));
        this.ShowTimeronShiftX = (bool) this.Config.GetValue<bool>("Misc", "ShowTimeronShiftX", (M0) (this.ShowTimeronShiftX ? 1 : 0));
        this.AIinCasinoHeistCanWander = (bool) this.Config.GetValue<bool>("Misc", "AIinCasinoHeistCanWander", (M0) (this.AIinCasinoHeistCanWander ? 1 : 0));
        this.AIinCasinoWanderChance = (int) this.Config.GetValue<int>("Misc", "AIinCasinoWanderChance", (M0) this.AIinCasinoWanderChance);
        this.AIinCasinoWanderRadius = (int) this.Config.GetValue<int>("Misc", "AIinCasinoWanderRadius", (M0) this.AIinCasinoWanderRadius);
      }
      catch (Exception ex)
      {
        UI.Notify("~r~Error~w~: Config.ini Failed To Load.");
      }
    }

    public bool GetGoldAll()
    {
      this.LoadIniFile("scripts//Payday.ini");
      float num1 = 0.0f;
      int num2 = 0;
      int Heist1 = 1;
      int num3 = 0;
      int num4 = 0;
      if (Heist1 == 1)
      {
        num3 = this.GetTimeBronze(Heist1);
        int timeGold = this.GetTimeGold(Heist1);
        num4 = this.GetTimeSilver(Heist1);
        if (Heist1 == 1)
          num1 = (float) this.FleecaBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist2 = Heist1 + 1;
      if (Heist2 == 2)
      {
        num3 = this.GetTimeBronze(Heist2);
        int timeGold = this.GetTimeGold(Heist2);
        num4 = this.GetTimeSilver(Heist2);
        if (Heist2 == 2)
          num1 = (float) this.PaletoBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist3 = Heist2 + 1;
      if (Heist3 == 3)
      {
        num3 = this.GetTimeBronze(Heist3);
        int timeGold = this.GetTimeGold(Heist3);
        num4 = this.GetTimeSilver(Heist3);
        if (Heist3 == 3)
          num1 = (float) this.PacificStandardBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist4 = Heist3 + 1;
      if (Heist4 == 4)
      {
        num3 = this.GetTimeBronze(Heist4);
        int timeGold = this.GetTimeGold(Heist4);
        num4 = this.GetTimeSilver(Heist4);
        if (Heist4 == 4)
          num1 = (float) this.VangelicoBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist5 = Heist4 + 1;
      if (Heist5 == 5)
      {
        num3 = this.GetTimeBronze(Heist5);
        int timeGold = this.GetTimeGold(Heist5);
        num4 = this.GetTimeSilver(Heist5);
        if (Heist5 == 5)
          num1 = (float) this.UnionDelpositioryBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist6 = Heist5 + 1;
      if (Heist6 == 6)
      {
        num3 = this.GetTimeBronze(Heist6);
        int timeGold = this.GetTimeGold(Heist6);
        num4 = this.GetTimeSilver(Heist6);
        if (Heist6 == 6)
          num1 = (float) this.LEXIGTONRAIDBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist7 = Heist6 + 1;
      if (Heist7 == 7)
      {
        num3 = this.GetTimeBronze(Heist7);
        int timeGold = this.GetTimeGold(Heist7);
        num4 = this.GetTimeSilver(Heist7);
        if (Heist7 == 7)
          num1 = (float) this.SURVERDOWNBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist8 = Heist7 + 1;
      if (Heist8 == 8)
      {
        num3 = this.GetTimeBronze(Heist8);
        int timeGold = this.GetTimeGold(Heist8);
        num4 = this.GetTimeSilver(Heist8);
        if (Heist8 == 8)
          num1 = (float) this.NUCLEAREXPANSIONHEISTBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist9 = Heist8 + 1;
      if (Heist9 == 9)
      {
        num3 = this.GetTimeBronze(Heist9);
        int timeGold = this.GetTimeGold(Heist9);
        num4 = this.GetTimeSilver(Heist9);
        if (Heist9 == 9)
          num1 = (float) this.DEEPDEAPTHSHEISTBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist10 = Heist9 + 1;
      if (Heist10 == 10)
      {
        num3 = this.GetTimeBronze(Heist10);
        int timeGold = this.GetTimeGold(Heist10);
        num4 = this.GetTimeSilver(Heist10);
        if (Heist10 == 10)
          num1 = (float) this.HUMANELABS2BestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist11 = Heist10 + 1;
      if (Heist11 == 11)
      {
        num3 = this.GetTimeBronze(Heist11);
        int timeGold = this.GetTimeGold(Heist11);
        num4 = this.GetTimeSilver(Heist11);
        if (Heist11 == 11)
          num1 = (float) this.YachtHeistBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist12 = Heist11 + 1;
      if (Heist12 == 12)
      {
        num3 = this.GetTimeBronze(Heist12);
        int timeGold = this.GetTimeGold(Heist12);
        num4 = this.GetTimeSilver(Heist12);
        if (Heist12 == 12)
          num1 = (float) this.BerkraneJobBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist13 = Heist12 + 1;
      if (Heist13 == 13)
      {
        num3 = this.GetTimeBronze(Heist13);
        int timeGold = this.GetTimeGold(Heist13);
        num4 = this.GetTimeSilver(Heist13);
        if (Heist13 == 13)
          num1 = (float) this.DiamondHeistBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist14 = Heist13 + 1;
      if (Heist14 == 14)
      {
        num3 = this.GetTimeBronze(Heist14);
        int timeGold = this.GetTimeGold(Heist14);
        num4 = this.GetTimeSilver(Heist14);
        if (Heist14 == 14)
          num1 = (float) this.PrisonBreakBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist15 = Heist14 + 1;
      if (Heist15 == 15)
      {
        num3 = this.GetTimeBronze(Heist15);
        int timeGold = this.GetTimeGold(Heist15);
        num4 = this.GetTimeSilver(Heist15);
        if (Heist15 == 15)
          num1 = (float) this.ContainerHeistBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist16 = Heist15 + 1;
      if (Heist16 == 16)
      {
        num3 = this.GetTimeBronze(Heist16);
        int timeGold = this.GetTimeGold(Heist16);
        num4 = this.GetTimeSilver(Heist16);
        if (Heist16 == 16)
          num1 = (float) this.HumaneLabsOnlineBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist17 = Heist16 + 1;
      if (Heist17 == 17)
      {
        num3 = this.GetTimeBronze(Heist17);
        int timeGold = this.GetTimeGold(Heist17);
        num4 = this.GetTimeSilver(Heist17);
        if (Heist17 == 17)
          num1 = (float) this.NorthYanktonBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      int Heist18 = Heist17 + 1;
      if (Heist18 == 18)
      {
        num3 = this.GetTimeBronze(Heist18);
        int timeGold = this.GetTimeGold(Heist18);
        num4 = this.GetTimeSilver(Heist18);
        if (Heist18 == 18)
          num1 = (float) this.CayoPericoHeistBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      bool flag = false;
      if (num2 >= 16)
        flag = true;
      if (num2 < 16)
        flag = false;
      return flag;
    }

    public bool GetSliverAll()
    {
      this.LoadIniFile("scripts//Payday.ini");
      float num1 = 0.0f;
      int num2 = 0;
      int Heist1 = 1;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      if (Heist1 == 1)
      {
        num3 = this.GetTimeBronze(Heist1);
        num4 = this.GetTimeGold(Heist1);
        int timeSilver = this.GetTimeSilver(Heist1);
        if (Heist1 == 1)
          num1 = (float) this.FleecaBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist2 = Heist1 + 1;
      if (Heist2 == 2)
      {
        num3 = this.GetTimeBronze(Heist2);
        num4 = this.GetTimeGold(Heist2);
        int timeSilver = this.GetTimeSilver(Heist2);
        if (Heist2 == 2)
          num1 = (float) this.PaletoBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist3 = Heist2 + 1;
      if (Heist3 == 3)
      {
        num3 = this.GetTimeBronze(Heist3);
        num4 = this.GetTimeGold(Heist3);
        int timeSilver = this.GetTimeSilver(Heist3);
        if (Heist3 == 3)
          num1 = (float) this.PacificStandardBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist4 = Heist3 + 1;
      if (Heist4 == 4)
      {
        num3 = this.GetTimeBronze(Heist4);
        num4 = this.GetTimeGold(Heist4);
        int timeSilver = this.GetTimeSilver(Heist4);
        if (Heist4 == 4)
          num1 = (float) this.VangelicoBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist5 = Heist4 + 1;
      if (Heist5 == 5)
      {
        num3 = this.GetTimeBronze(Heist5);
        num4 = this.GetTimeGold(Heist5);
        int timeSilver = this.GetTimeSilver(Heist5);
        if (Heist5 == 5)
          num1 = (float) this.UnionDelpositioryBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist6 = Heist5 + 1;
      if (Heist6 == 6)
      {
        num3 = this.GetTimeBronze(Heist6);
        num4 = this.GetTimeGold(Heist6);
        int timeSilver = this.GetTimeSilver(Heist6);
        if (Heist6 == 6)
          num1 = (float) this.LEXIGTONRAIDBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist7 = Heist6 + 1;
      if (Heist7 == 7)
      {
        num3 = this.GetTimeBronze(Heist7);
        num4 = this.GetTimeGold(Heist7);
        int timeSilver = this.GetTimeSilver(Heist7);
        if (Heist7 == 7)
          num1 = (float) this.SURVERDOWNBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist8 = Heist7 + 1;
      if (Heist8 == 8)
      {
        num3 = this.GetTimeBronze(Heist8);
        num4 = this.GetTimeGold(Heist8);
        int timeSilver = this.GetTimeSilver(Heist8);
        if (Heist8 == 8)
          num1 = (float) this.NUCLEAREXPANSIONHEISTBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist9 = Heist8 + 1;
      if (Heist9 == 9)
      {
        num3 = this.GetTimeBronze(Heist9);
        num4 = this.GetTimeGold(Heist9);
        int timeSilver = this.GetTimeSilver(Heist9);
        if (Heist9 == 9)
          num1 = (float) this.DEEPDEAPTHSHEISTBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist10 = Heist9 + 1;
      if (Heist10 == 10)
      {
        num3 = this.GetTimeBronze(Heist10);
        num4 = this.GetTimeGold(Heist10);
        int timeSilver = this.GetTimeSilver(Heist10);
        if (Heist10 == 10)
          num1 = (float) this.HUMANELABS2BestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist11 = Heist10 + 1;
      if (Heist11 == 11)
      {
        num3 = this.GetTimeBronze(Heist11);
        num4 = this.GetTimeGold(Heist11);
        int timeSilver = this.GetTimeSilver(Heist11);
        if (Heist11 == 11)
          num1 = (float) this.YachtHeistBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist12 = Heist11 + 1;
      if (Heist12 == 12)
      {
        num3 = this.GetTimeBronze(Heist12);
        num4 = this.GetTimeGold(Heist12);
        int timeSilver = this.GetTimeSilver(Heist12);
        if (Heist12 == 12)
          num1 = (float) this.BerkraneJobBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist13 = Heist12 + 1;
      if (Heist13 == 13)
      {
        num3 = this.GetTimeBronze(Heist13);
        num4 = this.GetTimeGold(Heist13);
        int timeSilver = this.GetTimeSilver(Heist13);
        if (Heist13 == 13)
          num1 = (float) this.DiamondHeistBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist14 = Heist13 + 1;
      if (Heist14 == 14)
      {
        num3 = this.GetTimeBronze(Heist14);
        num4 = this.GetTimeGold(Heist14);
        int timeSilver = this.GetTimeSilver(Heist14);
        if (Heist14 == 14)
          num1 = (float) this.PrisonBreakBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist15 = Heist14 + 1;
      if (Heist15 == 15)
      {
        num3 = this.GetTimeBronze(Heist15);
        num4 = this.GetTimeGold(Heist15);
        int timeSilver = this.GetTimeSilver(Heist15);
        if (Heist15 == 15)
          num1 = (float) this.ContainerHeistBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist16 = Heist15 + 1;
      if (Heist16 == 16)
      {
        num3 = this.GetTimeBronze(Heist16);
        num4 = this.GetTimeGold(Heist16);
        int timeSilver = this.GetTimeSilver(Heist16);
        if (Heist16 == 16)
          num1 = (float) this.HumaneLabsOnlineBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist17 = Heist16 + 1;
      if (Heist17 == 17)
      {
        num3 = this.GetTimeBronze(Heist17);
        num4 = this.GetTimeGold(Heist17);
        int timeSilver = this.GetTimeSilver(Heist17);
        if (Heist17 == 16)
          num1 = (float) this.NorthYanktonBestTime;
        if ((double) num1 < (double) timeSilver)
          ++num2;
        if ((double) num1 > (double) timeSilver)
          num2 = num2;
      }
      int Heist18 = Heist17 + 1;
      if (Heist18 == 18)
      {
        num3 = this.GetTimeBronze(Heist18);
        int timeGold = this.GetTimeGold(Heist18);
        num5 = this.GetTimeSilver(Heist18);
        if (Heist18 == 18)
          num1 = (float) this.CayoPericoHeistBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      bool flag = false;
      if (num2 >= 15)
        flag = true;
      if (num2 < 15)
        flag = false;
      return flag;
    }

    public bool GetBronzeAll()
    {
      this.LoadIniFile("scripts//Payday.ini");
      float num1 = 0.0f;
      int num2 = 0;
      int Heist1 = 1;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      if (Heist1 == 1)
      {
        int timeBronze = this.GetTimeBronze(Heist1);
        num4 = this.GetTimeGold(Heist1);
        num5 = this.GetTimeSilver(Heist1);
        if (Heist1 == 1)
          num1 = (float) this.FleecaBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist2 = Heist1 + 1;
      if (Heist2 == 2)
      {
        int timeBronze = this.GetTimeBronze(Heist2);
        num4 = this.GetTimeGold(Heist2);
        num5 = this.GetTimeSilver(Heist2);
        if (Heist2 == 2)
          num1 = (float) this.PaletoBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist3 = Heist2 + 1;
      if (Heist3 == 3)
      {
        int timeBronze = this.GetTimeBronze(Heist3);
        num4 = this.GetTimeGold(Heist3);
        num5 = this.GetTimeSilver(Heist3);
        if (Heist3 == 3)
          num1 = (float) this.PacificStandardBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist4 = Heist3 + 1;
      if (Heist4 == 4)
      {
        int timeBronze = this.GetTimeBronze(Heist4);
        num4 = this.GetTimeGold(Heist4);
        num5 = this.GetTimeSilver(Heist4);
        if (Heist4 == 4)
          num1 = (float) this.VangelicoBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist5 = Heist4 + 1;
      if (Heist5 == 5)
      {
        int timeBronze = this.GetTimeBronze(Heist5);
        num4 = this.GetTimeGold(Heist5);
        num5 = this.GetTimeSilver(Heist5);
        if (Heist5 == 5)
          num1 = (float) this.UnionDelpositioryBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist6 = Heist5 + 1;
      if (Heist6 == 6)
      {
        int timeBronze = this.GetTimeBronze(Heist6);
        num4 = this.GetTimeGold(Heist6);
        num5 = this.GetTimeSilver(Heist6);
        if (Heist6 == 6)
          num1 = (float) this.LEXIGTONRAIDBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist7 = Heist6 + 1;
      if (Heist7 == 7)
      {
        int timeBronze = this.GetTimeBronze(Heist7);
        num4 = this.GetTimeGold(Heist7);
        num5 = this.GetTimeSilver(Heist7);
        if (Heist7 == 7)
          num1 = (float) this.SURVERDOWNBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist8 = Heist7 + 1;
      if (Heist8 == 8)
      {
        int timeBronze = this.GetTimeBronze(Heist8);
        num4 = this.GetTimeGold(Heist8);
        num5 = this.GetTimeSilver(Heist8);
        if (Heist8 == 8)
          num1 = (float) this.NUCLEAREXPANSIONHEISTBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist9 = Heist8 + 1;
      if (Heist9 == 9)
      {
        int timeBronze = this.GetTimeBronze(Heist9);
        num4 = this.GetTimeGold(Heist9);
        num5 = this.GetTimeSilver(Heist9);
        if (Heist9 == 9)
          num1 = (float) this.DEEPDEAPTHSHEISTBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist10 = Heist9 + 1;
      if (Heist10 == 10)
      {
        int timeBronze = this.GetTimeBronze(Heist10);
        num4 = this.GetTimeGold(Heist10);
        num5 = this.GetTimeSilver(Heist10);
        if (Heist10 == 10)
          num1 = (float) this.HUMANELABS2BestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist11 = Heist10 + 1;
      if (Heist11 == 11)
      {
        int timeBronze = this.GetTimeBronze(Heist11);
        num4 = this.GetTimeGold(Heist11);
        num5 = this.GetTimeSilver(Heist11);
        if (Heist11 == 11)
          num1 = (float) this.YachtHeistBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist12 = Heist11 + 1;
      if (Heist12 == 12)
      {
        int timeBronze = this.GetTimeBronze(Heist12);
        num4 = this.GetTimeGold(Heist12);
        num5 = this.GetTimeSilver(Heist12);
        if (Heist12 == 12)
          num1 = (float) this.BerkraneJobBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist13 = Heist12 + 1;
      if (Heist13 == 13)
      {
        int timeBronze = this.GetTimeBronze(Heist13);
        num4 = this.GetTimeGold(Heist13);
        num5 = this.GetTimeSilver(Heist13);
        if (Heist13 == 13)
          num1 = (float) this.DiamondHeistBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist14 = Heist13 + 1;
      if (Heist14 == 14)
      {
        int timeBronze = this.GetTimeBronze(Heist14);
        num4 = this.GetTimeGold(Heist14);
        num5 = this.GetTimeSilver(Heist14);
        if (Heist14 == 14)
          num1 = (float) this.PrisonBreakBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist15 = Heist14 + 1;
      if (Heist15 == 15)
      {
        int timeBronze = this.GetTimeBronze(Heist15);
        num4 = this.GetTimeGold(Heist15);
        num5 = this.GetTimeSilver(Heist15);
        if (Heist15 == 15)
          num1 = (float) this.ContainerHeistBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist16 = Heist15 + 1;
      if (Heist16 == 16)
      {
        int timeBronze = this.GetTimeBronze(Heist16);
        num4 = this.GetTimeGold(Heist16);
        num5 = this.GetTimeSilver(Heist16);
        if (Heist16 == 16)
          num1 = (float) this.HumaneLabsOnlineBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist17 = Heist16 + 1;
      if (Heist17 == 17)
      {
        int timeBronze = this.GetTimeBronze(Heist17);
        num4 = this.GetTimeGold(Heist17);
        num5 = this.GetTimeSilver(Heist17);
        if (Heist17 == 17)
          num1 = (float) this.NorthYanktonBestTime;
        if ((double) num1 < (double) timeBronze)
          ++num2;
        if ((double) num1 > (double) timeBronze)
          num2 = num2;
      }
      int Heist18 = Heist17 + 1;
      if (Heist18 == 18)
      {
        num3 = this.GetTimeBronze(Heist18);
        int timeGold = this.GetTimeGold(Heist18);
        num5 = this.GetTimeSilver(Heist18);
        if (Heist18 == 18)
          num1 = (float) this.CayoPericoHeistBestTime;
        if ((double) num1 < (double) timeGold)
          ++num2;
        if ((double) num1 > (double) timeGold)
          num2 = num2;
      }
      bool flag = false;
      if (num2 >= 15)
        flag = true;
      if (num2 < 15)
        flag = false;
      return flag;
    }

    public bool GetGold(int Heist)
    {
      this.LoadIniFile("scripts//Payday.ini");
      float num1 = 0.0f;
      if (Heist == 1)
        num1 = (float) this.FleecaBestTime;
      if (Heist == 2)
        num1 = (float) this.PaletoBestTime;
      if (Heist == 3)
        num1 = (float) this.PacificStandardBestTime;
      if (Heist == 4)
        num1 = (float) this.VangelicoBestTime;
      if (Heist == 5)
        num1 = (float) this.UnionDelpositioryBestTime;
      if (Heist == 6)
        num1 = (float) this.LEXIGTONRAIDBestTime;
      if (Heist == 7)
        num1 = (float) this.SURVERDOWNBestTime;
      if (Heist == 8)
        num1 = (float) this.NUCLEAREXPANSIONHEISTBestTime;
      if (Heist == 9)
        num1 = (float) this.DEEPDEAPTHSHEISTBestTime;
      if (Heist == 10)
        num1 = (float) this.HUMANELABS2BestTime;
      if (Heist == 11)
        num1 = (float) this.YachtHeistBestTime;
      if (Heist == 12)
        num1 = (float) this.BerkraneJobBestTime;
      if (Heist == 13)
        num1 = (float) this.DiamondHeistBestTime;
      if (Heist == 14)
        num1 = (float) this.PrisonBreakBestTime;
      if (Heist == 15)
        num1 = (float) this.ContainerHeistBestTime;
      if (Heist == 16)
        num1 = (float) this.HumaneLabsOnlineBestTime;
      if (Heist == 17)
        num1 = (float) this.NorthYanktonBestTime;
      if (Heist == 18)
        num1 = (float) this.CayoPericoHeistBestTime;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      string str = "";
      if (Heist == 1)
      {
        str = "The Fleeca Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 2)
      {
        str = "The Paleto Job";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 3)
      {
        str = "The Pacific Standard";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 4)
      {
        str = "The Jewel Store Job";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 5)
      {
        str = "The Union Depository";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 6)
      {
        str = "USS Luxington Raid";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 7)
      {
        str = "Surver Down Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 8)
      {
        str = "The Nuclear Expansion";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 9)
      {
        str = "Deep Deapths Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 10)
      {
        str = "Humane Labs #2";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 11)
      {
        str = "The Yacht Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 12)
      {
        str = "The Belkrane Job";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 13)
      {
        str = "The Diamond Casino Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 14)
      {
        str = "The Prison Break";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 15)
      {
        str = "The Container Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 16)
      {
        str = "The Humaine Labs (Online)";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 17)
      {
        str = "The North Yankton Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 18)
      {
        str = "The Cayo Perico Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      bool flag = false;
      if ((double) num1 < (double) num3)
        flag = true;
      if ((double) num1 > (double) num3)
        flag = false;
      return flag;
    }

    public bool GetSliver(int Heist)
    {
      this.LoadIniFile("scripts//Payday.ini");
      float num1 = 0.0f;
      if (Heist == 1)
        num1 = (float) this.FleecaBestTime;
      if (Heist == 2)
        num1 = (float) this.PaletoBestTime;
      if (Heist == 3)
        num1 = (float) this.PacificStandardBestTime;
      if (Heist == 4)
        num1 = (float) this.VangelicoBestTime;
      if (Heist == 5)
        num1 = (float) this.UnionDelpositioryBestTime;
      if (Heist == 6)
        num1 = (float) this.LEXIGTONRAIDBestTime;
      if (Heist == 7)
        num1 = (float) this.SURVERDOWNBestTime;
      if (Heist == 8)
        num1 = (float) this.NUCLEAREXPANSIONHEISTBestTime;
      if (Heist == 9)
        num1 = (float) this.DEEPDEAPTHSHEISTBestTime;
      if (Heist == 10)
        num1 = (float) this.HUMANELABS2BestTime;
      if (Heist == 11)
        num1 = (float) this.YachtHeistBestTime;
      if (Heist == 12)
        num1 = (float) this.BerkraneJobBestTime;
      if (Heist == 13)
        num1 = (float) this.DiamondHeistBestTime;
      if (Heist == 14)
        num1 = (float) this.PrisonBreakBestTime;
      if (Heist == 15)
        num1 = (float) this.ContainerHeistBestTime;
      if (Heist == 16)
        num1 = (float) this.HumaneLabsOnlineBestTime;
      if (Heist == 17)
        num1 = (float) this.NorthYanktonBestTime;
      if (Heist == 18)
        num1 = (float) this.CayoPericoHeistBestTime;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      string str = "";
      if (Heist == 1)
      {
        str = "The Fleeca Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 2)
      {
        str = "The Paleto Job";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 3)
      {
        str = "The Pacific Standard";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 4)
      {
        str = "The Jewel Store Job";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 5)
      {
        str = "The Union Depository";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 6)
      {
        str = "USS Luxington Raid";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 7)
      {
        str = "Surver Down Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 8)
      {
        str = "The Nuclear Expansion";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 9)
      {
        str = "Deep Deapths Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 10)
      {
        str = "Humane Labs #2";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 11)
      {
        str = "The Yacht Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 12)
      {
        str = "The Belkrane Job";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 13)
      {
        str = "The Diamond Casino Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 14)
      {
        str = "The Prison Break";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 15)
      {
        str = "The Container Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 16)
      {
        str = "The Humaine Labs (Online)";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 17)
      {
        str = "The North Yankton Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 18)
      {
        str = "The Cayo Perico Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      bool flag = false;
      if ((double) num1 < (double) num4)
        flag = true;
      if ((double) num1 > (double) num4)
        flag = false;
      return flag;
    }

    public bool GetBronze(int Heist)
    {
      this.LoadIniFile("scripts//Payday.ini");
      float num1 = 0.0f;
      if (Heist == 1)
        num1 = (float) this.FleecaBestTime;
      if (Heist == 2)
        num1 = (float) this.PaletoBestTime;
      if (Heist == 3)
        num1 = (float) this.PacificStandardBestTime;
      if (Heist == 4)
        num1 = (float) this.VangelicoBestTime;
      if (Heist == 5)
        num1 = (float) this.UnionDelpositioryBestTime;
      if (Heist == 6)
        num1 = (float) this.LEXIGTONRAIDBestTime;
      if (Heist == 7)
        num1 = (float) this.SURVERDOWNBestTime;
      if (Heist == 8)
        num1 = (float) this.NUCLEAREXPANSIONHEISTBestTime;
      if (Heist == 9)
        num1 = (float) this.DEEPDEAPTHSHEISTBestTime;
      if (Heist == 10)
        num1 = (float) this.HUMANELABS2BestTime;
      if (Heist == 11)
        num1 = (float) this.YachtHeistBestTime;
      if (Heist == 12)
        num1 = (float) this.BerkraneJobBestTime;
      if (Heist == 13)
        num1 = (float) this.DiamondHeistBestTime;
      if (Heist == 14)
        num1 = (float) this.PrisonBreakBestTime;
      if (Heist == 15)
        num1 = (float) this.ContainerHeistBestTime;
      if (Heist == 16)
        num1 = (float) this.HumaneLabsOnlineBestTime;
      if (Heist == 17)
        num1 = (float) this.NorthYanktonBestTime;
      if (Heist == 18)
        num1 = (float) this.CayoPericoHeistBestTime;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      string str = "";
      if (Heist == 1)
      {
        str = "The Fleeca Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 2)
      {
        str = "The Paleto Job";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 3)
      {
        str = "The Pacific Standard";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 4)
      {
        str = "The Jewel Store Job";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 5)
      {
        str = "The Union Depository";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 6)
      {
        str = "USS Luxington Raid";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 7)
      {
        str = "Surver Down Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 8)
      {
        str = "The Nuclear Expansion";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 9)
      {
        str = "Deep Deapths Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 10)
      {
        str = "Humane Labs #2";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 11)
      {
        str = "The Yacht Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 12)
      {
        str = "The Belkrane Job";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 13)
      {
        str = "The Diamond Casino Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 14)
      {
        str = "The Prison Break";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 15)
      {
        str = "The Container Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 16)
      {
        str = "The Humaine Labs (Online)";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 17)
      {
        str = "The North Yankton Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      if (Heist == 18)
      {
        str = "The Cayo Perico Heist";
        num2 = this.GetTimeBronze(Heist);
        num3 = this.GetTimeGold(Heist);
        num4 = this.GetTimeSilver(Heist);
      }
      bool flag = false;
      if ((double) num1 < (double) num2)
        flag = true;
      if ((double) num1 > (double) num2)
        flag = false;
      return flag;
    }

    public string GetHeistName(int Heist)
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      string str = "";
      if (Heist == 1)
      {
        str = "The Fleeca Heist";
        num1 = 18500;
        num2 = 9900;
        num3 = 14500;
      }
      if (Heist == 2)
      {
        str = "The Paleto Job";
        num1 = 22000;
        num2 = 11500;
        num3 = 15000;
      }
      if (Heist == 3)
      {
        str = "The Pacific Standard";
        num1 = 36000;
        num2 = 22500;
        num3 = 28000;
      }
      if (Heist == 4)
      {
        str = "The Jewel Store Job";
        num1 = 24000;
        num2 = 6500;
        num3 = 15000;
      }
      if (Heist == 5)
      {
        str = "The Union Depository";
        num1 = 35000;
        num2 = 16500;
        num3 = 24000;
      }
      if (Heist == 6)
      {
        str = "USS Luxington Raid";
        num1 = 26000;
        num2 = 19500;
        num3 = 23000;
      }
      if (Heist == 7)
      {
        str = "Surver Down Heist";
        num1 = 31000;
        num2 = 18500;
        num3 = 23000;
      }
      if (Heist == 8)
      {
        str = "The Nuclear Expansion";
        num1 = 28000;
        num2 = 14750;
        num3 = 20000;
      }
      if (Heist == 9)
      {
        str = "Deep Deapths Heist";
        num1 = 32000;
        num2 = 22500;
        num3 = 27000;
      }
      if (Heist == 10)
      {
        str = "Humane Labs #2";
        num1 = 29000;
        num2 = 17500;
        num3 = 22000;
      }
      if (Heist == 11)
      {
        str = "The Yacht Heist";
        num1 = 30000;
        num2 = 20500;
        num3 = 24000;
      }
      if (Heist == 12)
      {
        str = "The Belkrane Job";
        num1 = 36000;
        num2 = 18500;
        num3 = 25000;
      }
      if (Heist == 13)
      {
        str = "The Diamond Casino Heist";
        num1 = 42000;
        num2 = 22500;
        num3 = 17000;
      }
      if (Heist == 14)
      {
        str = "The Prison Break";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 15)
      {
        str = "The Container Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 16)
      {
        str = "The Humaine Labs (Online)";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 17)
      {
        str = "The North Yankton Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 18)
      {
        str = "The Cayo Perico Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      return str;
    }

    public void ShowTimes()
    {
      string str1 = "bronzemedal";
      this.Fail = false;
      this.Pass = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 2000), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("Heist Times", new Point(int32, 100), 1.8f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      int y = 230;
      for (int Heist = 0; Heist < 15; ++Heist)
      {
        int num1 = Heist;
        int num2 = 0;
        if (num1 == 1)
          num2 = this.FleecaBestTime;
        if (num1 == 2)
          num2 = this.PaletoBestTime;
        if (num1 == 3)
          num2 = this.PacificStandardBestTime;
        if (num1 == 4)
          num2 = this.VangelicoBestTime;
        if (num1 == 5)
          num2 = this.UnionDelpositioryBestTime;
        if (num1 == 6)
          num2 = this.LEXIGTONRAIDBestTime;
        if (num1 == 7)
          num2 = this.SURVERDOWNBestTime;
        if (num1 == 8)
          num2 = this.NUCLEAREXPANSIONHEISTBestTime;
        if (num1 == 9)
          num2 = this.DEEPDEAPTHSHEISTBestTime;
        if (num1 == 10)
          num2 = this.HUMANELABS2BestTime;
        if (num1 == 11)
          num2 = this.YachtHeistBestTime;
        if (num1 == 12)
          num2 = this.BerkraneJobBestTime;
        if (num1 == 13)
          num2 = this.DiamondHeistBestTime;
        if (num1 == 14)
          num2 = this.PrisonBreakBestTime;
        if (num1 == 15)
          num2 = this.ContainerHeistBestTime;
        if ((uint) Heist > 0U)
        {
          string str2 = !this.GetBronze(Heist) ? "Time Not Set" : "bronzemedal";
          if (this.GetSliver(Heist))
            str2 = "silvermedal";
          if (this.GetGold(Heist))
            str2 = "goldmedal";
          if (Heist == 1)
            num2 = this.FleecaBestTime;
          TimeSpan timeSpan = TimeSpan.FromSeconds((double) num2 / 10.5);
          if (!str2.Equals("Time Not Set"))
          {
            ((UIText) new UIResText(this.GetHeistName(Heist) + "   :    ", new Point(int32 - 300, y), 0.55f, Color.White, (Font) 1, (UIResText.Alignment) 1)).Draw();
            ((UIText) new UIResText(timeSpan.ToString("hh':'mm':'ss"), new Point(int32 - 100, y), 0.55f, Color.White, (Font) 1, (UIResText.Alignment) 1)).Draw();
            new Sprite("mpmissionend", str2, new Point(int32 + 100, y), new Size(46, 46)).Draw();
          }
          else
          {
            ((UIText) new UIResText(this.GetHeistName(Heist), new Point(int32 - 300, y), 0.55f, Color.White, (Font) 1, (UIResText.Alignment) 1)).Draw();
            ((UIText) new UIResText("No Qualifying Time", new Point(int32 + 200, y), 0.55f, Color.White, (Font) 1, (UIResText.Alignment) 1)).Draw();
          }
          y += 60;
          str1 = "";
        }
      }
    }

    public void ShowTimes2()
    {
      string str1 = "bronzemedal";
      this.Fail = false;
      this.Pass = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 2000), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("Heist Times", new Point(int32, 100), 1.8f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      int y = 230;
      for (int Heist = 14; Heist < 19; ++Heist)
      {
        int num1 = Heist;
        int num2 = 0;
        int num3 = 0;
        if (num1 == 14)
        {
          num3 = this.PrisonBreakBestTime;
          num2 = num3;
        }
        if (num1 == 15)
        {
          num3 = this.ContainerHeistBestTime;
          num2 = num3;
        }
        if (num1 == 16)
        {
          num3 = this.HumaneLabsOnlineBestTime;
          num2 = num3;
        }
        if (num1 == 17)
        {
          num3 = this.NorthYanktonBestTime;
          num2 = num3;
        }
        if (num1 == 18)
        {
          num3 = this.CayoPericoHeistBestTime;
          num2 = num3;
        }
        if ((uint) Heist > 0U)
        {
          string str2 = this.GetTimeBronze(Heist) <= num3 ? "Time Not Set" : "bronzemedal";
          if (this.GetTimeSilver(Heist) > num3)
            str2 = "silvermedal";
          if (this.GetTimeGold(Heist) > num3)
            str2 = "goldmedal";
          TimeSpan timeSpan = TimeSpan.FromSeconds((double) num2 / 10.5);
          if (!str2.Equals("Time Not Set"))
          {
            ((UIText) new UIResText(this.GetHeistName(Heist) + "   :    ", new Point(int32 - 300, y), 0.55f, Color.White, (Font) 1, (UIResText.Alignment) 1)).Draw();
            ((UIText) new UIResText(timeSpan.ToString("hh':'mm':'ss"), new Point(int32 - 100, y), 0.55f, Color.White, (Font) 1, (UIResText.Alignment) 1)).Draw();
            new Sprite("mpmissionend", str2, new Point(int32 + 100, y), new Size(46, 46)).Draw();
          }
          else
          {
            ((UIText) new UIResText(this.GetHeistName(Heist), new Point(int32 - 300, y), 0.55f, Color.White, (Font) 1, (UIResText.Alignment) 1)).Draw();
            ((UIText) new UIResText("No Qualifying Time", new Point(int32 + 200, y), 0.55f, Color.White, (Font) 1, (UIResText.Alignment) 1)).Draw();
          }
          y += 60;
          str1 = "";
        }
      }
    }

    public void ShowPage2_Help()
    {
      this.Fail = false;
      this.Pass = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 2020), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      this.AIinCasinoHeistCanWander = (bool) this.Config.GetValue<bool>("Misc", "AIinCasinoHeistCanWander", (M0) (this.AIinCasinoHeistCanWander ? 1 : 0));
      this.AIinCasinoWanderChance = (int) this.Config.GetValue<int>("Misc", "AIinCasinoWanderChance", (M0) this.AIinCasinoWanderChance);
      this.AIinCasinoWanderRadius = (int) this.Config.GetValue<int>("Misc", "AIinCasinoWanderRadius", (M0) this.AIinCasinoWanderRadius);
      ((UIText) new UIResText("Debug", new Point(int32, 100), 1f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("To Change these Open the 'Payday.ini' edit the values under [MISC] and Save!", new Point(int32, 160), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Player Options", new Point(int32 - 400, 200), 0.65f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Max HP : " + this.MaxHp.ToString(), new Point(int32 - 400, 240), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Max Armour : " + this.MaxArmour.ToString(), new Point(int32 - 400, 280), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Diamond Casino Heist", new Point(int32 - 400, 370), 0.65f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Allow AI Guards to Wander : " + this.AIinCasinoHeistCanWander.ToString(), new Point(int32 - 400, 410), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Wander Chance : " + this.AIinCasinoWanderChance.ToString(), new Point(int32 - 400, 450), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Wander Radius : " + this.AIinCasinoWanderRadius.ToString(), new Point(int32 - 400, 490), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Fleeca/Pacific Standard/Paleto CCTV", new Point(int32 + 400, 200), 0.65f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Show Camera Alive : " + this.ShowCCTVBlipAliveDebug.ToString(), new Point(int32 + 400, 240), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Show Camera Dead : " + this.ShowCCTVBlipDeadDebug.ToString(), new Point(int32 + 400, 280), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Pacific Standard Vault", new Point(int32 + 400, 360), 0.65f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Show Debug Vault : " + this.ShowPacificStandardVaultDebug.ToString(), new Point(int32 + 400, 400), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Union Depository Garage Doors", new Point(int32 + 400, 460), 0.65f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Block Enterance while not playing Finale/Setup : " + this.CreateUnionDepositoryBlocker.ToString(), new Point(int32 + 400, 500), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("All Heists", new Point(int32 + 400, 560), 0.65f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Show Timer on Shift + 8 : " + this.ShowTimeronShiftX.ToString(), new Point(int32 + 400, 600), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void ShowPage1_Help()
    {
      this.Fail = false;
      this.Pass = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 2020), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("Help", new Point(int32, 100), 1f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Recomended Mods", new Point(int32 - 400, 200), 0.65f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Lester's Bribes", new Point(int32 - 400, 240), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Advanced Vehicle Functions", new Point(int32 - 400, 280), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Mobile Money Vault", new Point(int32 - 400, 320), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Dispatch of Variety", new Point(int32 - 400, 360), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("How to Unlock Ai Outifts", new Point(int32 + 400, 200), 0.65f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Complete any of the Heists to get a time, if you beat Gold, Silver ", new Point(int32 + 400, 240), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("or Bronze Times you will then Unlock a new Vehicle or Outfit ", new Point(int32 + 400, 270), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("for Ai/Player, Get gold on all Heists to unlock Special Ai outfits", new Point(int32 + 400, 300), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Display Time", new Point(int32, 400), 0.65f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("To display you current time on a Heist, Hold Shift then press 8 while playing the Finale", new Point(int32, 440), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Reset Heist Progress", new Point(int32, 500), 0.65f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("to Reset you Heist Progress, Open the 'Payday.ini' and set Heiststage to 1 to restart the Heist, and Heiststage to 4 to Skip to Finale ", new Point(int32, 540), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Note : for Union Depository for setting Heist Stage to 4 for Finale wont work, you have to set Heist Stage to 6", new Point(int32, 580), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Reset Heist Time", new Point(int32, 640), 0.65f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("to Reset you Heist Times, Open the 'Payday.ini' and set each Heist Time under [BEST_TIMES] to a large number like 200000 ", new Point(int32, 680), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void ShowThankPage1()
    {
      this.Fail = false;
      this.Pass = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 2020), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("Thank You To Everyone who participated in Payday 3.0 Beta on Discord!", new Point(int32, 100), 1f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("YousifTheGamer1#1659", new Point(int32, 200), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Cabman#1943", new Point(int32, 230), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Hawk#5260", new Point(int32, 260), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Buttfat#9120", new Point(int32, 290), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("SomeTexanGuy#0816", new Point(int32, 320), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("W222#3032", new Point(int32, 350), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Yukikaze#0008", new Point(int32, 380), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("ROYOP#4247", new Point(int32, 410), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Mr.Capitalism#4748", new Point(int32, 440), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Kyberous#1268", new Point(int32, 470), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Agus#7755", new Point(int32, 500), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("*WIND*#3787", new Point(int32, 530), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("SoliaZ#0913", new Point(int32, 560), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("( V ) #8002", new Point(int32, 590), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Dumbledore27#3201", new Point(int32 - 400, 200), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Zennox564#7516", new Point(int32 - 400, 230), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Bobasnotdead#8145", new Point(int32 - 400, 260), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("chickenbreastwithsauce#0988", new Point(int32 - 400, 290), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("chucknorris#2602", new Point(int32 - 400, 320), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Cixiid Gacha#8428", new Point(int32 - 400, 350), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Cod3oz#4756", new Point(int32 - 400, 380), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Dripmass#5527", new Point(int32 - 400, 410), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("FuZe Z#3295", new Point(int32 - 400, 440), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Alberto096#8712", new Point(int32 - 400, 470), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("eXact#8443", new Point(int32 - 400, 500), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("FelixSG#1088", new Point(int32 - 400, 530), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("SEModder4™#0004", new Point(int32 - 400, 560), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Dryder Mataroa#3906", new Point(int32 + 400, 200), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("AttomicNut#4601", new Point(int32 + 400, 230), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Jesus 'Big Boss' Christ#5491", new Point(int32 + 400, 260), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("kill752_2#3277", new Point(int32 + 400, 290), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Leakme#2162", new Point(int32 + 400, 320), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Lexxie Slevaskos#0088", new Point(int32 + 400, 350), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("LOX SAMA#9672", new Point(int32 + 400, 380), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("marty#5961", new Point(int32 + 400, 410), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("metarchitect#0606", new Point(int32 + 400, 440), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("ODRAYMO#5084", new Point(int32 + 400, 470), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Punked#8781", new Point(int32 + 400, 500), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Darui#6495", new Point(int32 + 400, 530), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void ShowThankPage2()
    {
      this.Fail = false;
      this.Pass = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 2020), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("Thank You To Everyone who participated in Payday 4.0 Beta on Discord! (Page 1)", new Point(int32, 100), 1f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("splicist#3107", new Point(int32, 200), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("AnotherGreekDude#5572", new Point(int32, 230), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Pathfinder#5799", new Point(int32, 260), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("-SkyZ-#1101", new Point(int32, 290), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("chubby#6071", new Point(int32, 320), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("joey2498#5463", new Point(int32, 350), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Pioter21#7398", new Point(int32, 380), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("f1#3650", new Point(int32, 410), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("SEVA та GP37#4439", new Point(int32, 440), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("themen098s#1635", new Point(int32, 470), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Noga#8589", new Point(int32, 500), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("MrHappy#8740", new Point(int32, 530), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Blue-Sky#2151", new Point(int32, 560), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("IronLad#4068", new Point(int32, 590), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("M1ST£R'X'#5350", new Point(int32 - 400, 200), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("RetroGamer#8076", new Point(int32 - 400, 230), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("habhi_almasri#9734", new Point(int32 - 400, 260), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("0603#4279", new Point(int32 - 400, 290), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("OBSIDIAN ONE#8720", new Point(int32 - 400, 320), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("The Poetic Unknown#1705", new Point(int32 - 400, 350), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("JoshJOkayguy#2357", new Point(int32 - 400, 380), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("maximecks#6789", new Point(int32 - 400, 410), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Midas#7565", new Point(int32 - 400, 440), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("eXact#1955", new Point(int32 - 400, 470), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Gx_lover#5108", new Point(int32 - 400, 500), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("", new Point(int32 - 400, 530), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Dumbledore27#3201", new Point(int32 - 400, 560), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("D-E-N-N-I-S#4144", new Point(int32 + 400, 200), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Kirito_mini#2840", new Point(int32 + 400, 230), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("YousifTheGamer1#1659", new Point(int32 + 400, 260), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("rcristi#3129", new Point(int32 + 400, 290), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("mikeymumble#4892", new Point(int32 + 400, 320), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("JonnyLo#5388", new Point(int32 + 400, 350), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Lavobell#8859", new Point(int32 + 400, 380), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("kio#4596", new Point(int32 + 400, 410), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("whatever2654#7357", new Point(int32 + 400, 440), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("DaRealAdofire#8328", new Point(int32 + 400, 470), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Printer BOY#4953", new Point(int32 + 400, 500), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("IEKWJJDK#9125", new Point(int32 + 400, 530), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void ShowThankPage3()
    {
      this.Fail = false;
      this.Pass = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 2020), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("Thank You To Everyone who participated in Payday 4.0 Beta on Discord! (Page 2)", new Point(int32, 100), 1f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Donut97#1653", new Point(int32, 200), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("eggniqqa#7682", new Point(int32, 230), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("eric6768#7859", new Point(int32, 260), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("MrBicer#1890", new Point(int32, 290), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Michael Scarn#0805", new Point(int32, 320), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Palik#2398", new Point(int32, 350), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("AryJaey#6963", new Point(int32, 380), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("NiceGuyOgga#5203", new Point(int32, 410), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("GamerMax#0810", new Point(int32, 440), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("topsidewolf697#1085", new Point(int32, 470), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("AlpJustAlp#2979", new Point(int32, 500), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("GeistDesThor#0444", new Point(int32, 530), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Nic1285#8491", new Point(int32, 560), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("ang13_mo#7004", new Point(int32, 590), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("samshayn#6487", new Point(int32 - 400, 200), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("HZDRT#5488", new Point(int32 - 400, 230), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("joshdpboy#9040", new Point(int32 - 400, 260), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("AnAcKiNNN#7056", new Point(int32 - 400, 290), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("firepanther#6794", new Point(int32 - 400, 320), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("ILOVEFOOTBALL95#8535", new Point(int32 - 400, 350), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Poganator#1728", new Point(int32 - 400, 380), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("StuckInaDuck#0804", new Point(int32 - 400, 410), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Games_Graphics#9412", new Point(int32 - 400, 440), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Hjenning Hansen#5400", new Point(int32 - 400, 470), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Rogers#0151", new Point(int32 - 400, 500), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Elevatorisbest#5105", new Point(int32 - 400, 530), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Djtmac24#1566", new Point(int32 - 400, 560), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("NilsTheSwedishBoi#1648", new Point(int32 + 400, 200), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("TheHighMan#8784", new Point(int32 + 400, 230), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Juan Sanchez#3680", new Point(int32 + 400, 260), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Humphrey#7215", new Point(int32 + 400, 290), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void ShowThankPage4()
    {
      this.Fail = false;
      this.Pass = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 2020), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("Thank You To Everyone who participated in Payday 5.0 Beta on Discord! (Page 1)", new Point(int32, 100), 1f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Red Dinosaur#0666", new Point(int32, 200), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("MAVERICK#3481", new Point(int32, 230), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Dumbledore27#3201", new Point(int32, 260), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("LAL2020#6298", new Point(int32, 290), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("topsidewolf697#1085", new Point(int32, 320), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Fanis#4812", new Point(int32, 350), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("acemoir#9654", new Point(int32, 380), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("eXact#1955", new Point(int32, 410), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Subarurulessincelambossuck#6750", new Point(int32, 440), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Aiden Demeulenaere#1731", new Point(int32, 470), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("NoOneKnow#0718", new Point(int32, 500), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("ThatNuttySquirrel#1059", new Point(int32, 530), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Gx_lover#5108", new Point(int32, 560), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("James rack#5830", new Point(int32, 590), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("ODRAYMO#5084", new Point(int32 - 400, 200), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Palik#2398", new Point(int32 - 400, 230), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Ni ck#8651", new Point(int32 - 400, 260), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("DryderMataroa#1000", new Point(int32 - 400, 290), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("CrazyBoss V31#7983", new Point(int32 - 400, 320), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Javgarag#0085", new Point(int32 - 400, 350), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Don.K#1500", new Point(int32 - 400, 380), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("CurlyFrizzle#8437", new Point(int32 - 400, 410), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Games_Graphics#9412", new Point(int32 - 400, 440), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("PellaR#0646", new Point(int32 - 400, 470), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("RTX#4233", new Point(int32 - 400, 500), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Thomas Kao#5195", new Point(int32 - 400, 530), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("GTA Gamer#5555", new Point(int32 - 400, 560), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("SC - Xx_BirdPerson_xX#1869", new Point(int32 + 400, 200), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("KirameiRed2020#3753", new Point(int32 + 400, 230), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("-SkyZ-#1101", new Point(int32 + 400, 260), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Tryeme91#5166", new Point(int32 + 400, 290), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Chauvens#1984", new Point(int32 + 400, 320), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("patomenza#6733", new Point(int32 + 400, 350), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("JVOTI aka Mr Bitches#1905", new Point(int32 + 400, 380), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("dreamcatcher79#3884", new Point(int32 + 400, 410), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Kakashi Hatake#3146", new Point(int32 + 400, 440), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("DaRealAdofire#8328", new Point(int32 + 400, 470), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("NiceGuyOgga#5203", new Point(int32 + 400, 500), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Gaming G#8744", new Point(int32 + 400, 530), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void ShowThankPage5()
    {
      this.Fail = false;
      this.Pass = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 2020), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("Thank You To Everyone who participated in Payday 5.0 Beta on Discord! (Page 2)", new Point(int32, 100), 1f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("habhi_almasri#9734", new Point(int32, 200), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("rcristi#3129", new Point(int32, 230), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("gbeans77#3903", new Point(int32, 260), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Herms Niel#5555", new Point(int32, 290), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Edgar the Arctic Fox#8979", new Point(int32, 320), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Ender#5634", new Point(int32, 350), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Warm_Blue__#2973", new Point(int32, 380), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Tryeme91#5166", new Point(int32, 410), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("N0tAB00m3r#3419", new Point(int32, 440), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("StenadXD#8381", new Point(int32, 470), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("ikON#1853", new Point(int32, 500), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("iiFoxxer#1773", new Point(int32, 530), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Tryhard ( Hunting Griefers )#3765", new Point(int32, 560), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("YousifTheGamer1#1659", new Point(int32, 590), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Shazamm17#4620", new Point(int32 - 400, 200), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("RaphaP3#8879", new Point(int32 - 400, 230), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("batnow94#4155", new Point(int32 - 400, 260), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Leve#0666", new Point(int32 - 400, 290), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Don.K#1500", new Point(int32 - 400, 320), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("stopplzlosers#3778", new Point(int32 - 400, 350), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("bubbaj0423#9573", new Point(int32 - 400, 380), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("kelson8#8348", new Point(int32 - 400, 410), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Tommis Gaming#4006", new Point(int32 - 400, 440), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("mikio#1255", new Point(int32 - 400, 470), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("djtmac24#1566", new Point(int32 - 400, 500), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("KSP.fkrzys#4733", new Point(int32 - 400, 530), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("BoostedTupperware#8145", new Point(int32 - 400, 560), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Tiz666#6405", new Point(int32 + 400, 200), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("The Dark Unknown#1705", new Point(int32 + 400, 230), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Markovsky#2601", new Point(int32 + 400, 260), 0.45f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void MissionPassed(
      string MissionName,
      int Payout,
      int CrewCut,
      int CrewAlive,
      float Time,
      int Heist)
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      float num4 = Time / 10.5f;
      if (Heist == 1)
      {
        MissionName = "The Fleeca Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 2)
      {
        MissionName = "The Paleto Job";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 3)
      {
        MissionName = "The Pacific Standard";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 4)
      {
        MissionName = "The Jewel Store Job";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 5)
      {
        MissionName = "The Union Depository";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 6)
      {
        MissionName = "USS Luxington Raid";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 7)
      {
        MissionName = "Surver Down Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 8)
      {
        MissionName = "The Nuclear Expansion";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 9)
      {
        MissionName = "Deep Deapths Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 10)
      {
        MissionName = "Humane Labs #2";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 11)
      {
        MissionName = "The Yacht Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 12)
      {
        MissionName = "The Belkrane Job";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 13)
      {
        MissionName = "The Diamond Casino Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 14)
      {
        MissionName = "The Prison Break";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 15)
      {
        MissionName = "The Container Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 16)
      {
        MissionName = "The Humaine Labs (Online)";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 17)
      {
        MissionName = "The North Yankton Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 18)
      {
        MissionName = "The Cayo Perico Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      string str1 = "bronzemedal";
      this.Fail = false;
      this.Pass = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 1020), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("mission passed", new Point(int32, 100), 2.5f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText(MissionName, new Point(int32, 230), 1.25f, Color.White, (Font) 1, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Player Cut : $" + Payout.ToString("N"), new Point(int32, 330), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Crew Cut $" + CrewCut.ToString("N"), new Point(int32, 400), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      switch (CrewAlive)
      {
        case 3:
          str1 = "silvermedal";
          break;
        case 4:
          str1 = "goldmedal";
          break;
      }
      new Sprite("mpmissionend", str1, new Point(int32 - 180, 470), new Size(46, 46)).Draw();
      ((UIText) new UIResText("Crew Alive : " + CrewAlive.ToString() + "/4", new Point(int32, 471), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      if ((double) Time <= (double) num1)
        str1 = "bronzemedal";
      if ((double) Time <= (double) num3)
        str1 = "silvermedal";
      if ((double) Time <= (double) num2)
        str1 = "goldmedal";
      TimeSpan timeSpan1 = TimeSpan.FromSeconds((double) num4);
      new Sprite("mpmissionend", str1, new Point(int32 - 180, 551), new Size(46, 46)).Draw();
      ((UIText) new UIResText("Time : " + timeSpan1.ToString("hh':'mm':'ss"), new Point(int32, 550), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      float num5 = (float) num1 / 10.5f;
      float num6 = (float) num2 / 10.5f;
      float num7 = (float) num3 / 10.5f;
      string str2 = "goldmedal";
      TimeSpan timeSpan2 = TimeSpan.FromSeconds((double) num2 / 10.5);
      new Sprite("mpmissionend", str2, new Point(int32 - 300, 619), new Size(46, 46)).Draw();
      ((UIText) new UIResText(timeSpan2.ToString("hh':'mm':'ss") ?? "", new Point(int32 - 200, 620), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      TimeSpan timeSpan3 = TimeSpan.FromSeconds((double) num3 / 10.5);
      new Sprite("mpmissionend", "silvermedal", new Point(int32 - 100, 619), new Size(46, 46)).Draw();
      ((UIText) new UIResText(timeSpan3.ToString("hh':'mm':'ss") ?? "", new Point(int32, 620), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      TimeSpan timeSpan4 = TimeSpan.FromSeconds((double) num1 / 10.5);
      string str3 = "bronzemedal";
      new Sprite("mpmissionend", str3, new Point(int32 + 100, 619), new Size(46, 46)).Draw();
      ((UIText) new UIResText(timeSpan4.ToString("hh':'mm':'ss") ?? "", new Point(int32 + 200, 620), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      if (Heist == 1)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "FLEECA", (M0) this.BestTime);
      if (Heist == 2)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "PALETO", (M0) this.BestTime);
      if (Heist == 3)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "PACIFICSTANDARD", (M0) this.BestTime);
      if (Heist == 4)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "VANGELICO", (M0) this.BestTime);
      if (Heist == 5)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "UNIONDEPOSITORY", (M0) this.BestTime);
      if (Heist == 6)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "LEXIGTONRAID", (M0) this.BestTime);
      if (Heist == 7)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "SURVERDOWN", (M0) this.BestTime);
      if (Heist == 8)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "NUCLEAREXPANSIONHEIST", (M0) this.BestTime);
      if (Heist == 9)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "DEEPDEAPTHSHEIST", (M0) this.BestTime);
      if (Heist == 10)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "HUMANELABS#2", (M0) this.BestTime);
      if (Heist == 11)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "YachtHeist", (M0) this.BestTime);
      if (Heist == 12)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "BerkraneJob", (M0) this.BestTime);
      if (Heist == 13)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "DiamondHeist", (M0) this.BestTime);
      TimeSpan timeSpan5 = TimeSpan.FromSeconds((double) this.BestTime / 10.5);
      if ((double) Time <= (double) num1)
        str3 = "bronzemedal";
      if ((double) Time <= (double) num3)
        str3 = "silvermedal";
      if ((double) Time <= (double) num2)
        str3 = "goldmedal";
      if (this.BestTime < this.GetTimeBronze(Heist))
      {
        if ((double) Time >= (double) this.BestTime)
        {
          new Sprite("mpmissionend", str3, new Point(int32 - 180, 719), new Size(46, 46)).Draw();
          ((UIText) new UIResText("Best : " + timeSpan5.ToString("hh':'mm':'ss"), new Point(int32, 720), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
        }
        if ((double) Time < (double) this.BestTime)
        {
          new Sprite("mpmissionend", str3, new Point(int32 - 180, 719), new Size(46, 46)).Draw();
          ((UIText) new UIResText("Best : " + timeSpan1.ToString("hh':'mm':'ss"), new Point(int32, 720), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
        }
      }
      if (this.BestTime > this.GetTimeBronze(Heist))
        ((UIText) new UIResText("Best :  No Qualifying Time", new Point(int32, 720), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void MissionPassedPilotCut(
      string MissionName,
      int Payout,
      int CrewCut,
      int PilotCut,
      int CrewAlive,
      float Time,
      int Heist)
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      float num4 = Time / 10.5f;
      if (Heist == 1)
      {
        MissionName = "The Fleeca Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 2)
      {
        MissionName = "The Paleto Job";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 3)
      {
        MissionName = "The Pacific Standard";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 4)
      {
        MissionName = "The Jewel Store Job";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 5)
      {
        MissionName = "The Union Depository";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 6)
      {
        MissionName = "USS Luxington Raid";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 7)
      {
        MissionName = "Surver Down Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 8)
      {
        MissionName = "The Nuclear Expansion";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 9)
      {
        MissionName = "Deep Deapths Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 10)
      {
        MissionName = "Humane Labs #2";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 11)
      {
        MissionName = "The Yacht Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 12)
      {
        MissionName = "The Belkrane Job";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 13)
      {
        MissionName = "The Diamond Casino Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 14)
      {
        MissionName = "The Prison Break";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 15)
      {
        MissionName = "The Container Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 16)
      {
        MissionName = "The Humaine Labs (Online)";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 17)
      {
        MissionName = "The North Yankton Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 18)
      {
        MissionName = "The Cayo Perico Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      string str1 = "bronzemedal";
      this.Fail = false;
      this.Pass = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 1020), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("mission passed", new Point(int32, 100), 2.5f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText(MissionName, new Point(int32, 230), 1.25f, Color.White, (Font) 1, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Player Cut : $" + Payout.ToString("N"), new Point(int32, 330), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Crew Cut $" + CrewCut.ToString("N"), new Point(int32, 400), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Pilot Cut $" + PilotCut.ToString("N"), new Point(int32, 470), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      switch (CrewAlive)
      {
        case 3:
          str1 = "silvermedal";
          break;
        case 4:
          str1 = "goldmedal";
          break;
      }
      new Sprite("mpmissionend", str1, new Point(int32 - 180, 540), new Size(46, 46)).Draw();
      ((UIText) new UIResText("Crew Alive : " + CrewAlive.ToString() + "/4", new Point(int32, 541), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      if ((double) Time <= (double) num1)
        str1 = "bronzemedal";
      if ((double) Time <= (double) num3)
        str1 = "silvermedal";
      if ((double) Time <= (double) num2)
        str1 = "goldmedal";
      TimeSpan timeSpan1 = TimeSpan.FromSeconds((double) num4);
      new Sprite("mpmissionend", str1, new Point(int32 - 180, 610), new Size(46, 46)).Draw();
      ((UIText) new UIResText("Time : " + timeSpan1.ToString("hh':'mm':'ss"), new Point(int32, 610), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      float num5 = (float) num1 / 10.5f;
      float num6 = (float) num2 / 10.5f;
      float num7 = (float) num3 / 10.5f;
      string str2 = "goldmedal";
      TimeSpan timeSpan2 = TimeSpan.FromSeconds((double) num2 / 10.5);
      new Sprite("mpmissionend", str2, new Point(int32 - 300, 680), new Size(46, 46)).Draw();
      ((UIText) new UIResText(timeSpan2.ToString("hh':'mm':'ss") ?? "", new Point(int32 - 200, 680), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      TimeSpan timeSpan3 = TimeSpan.FromSeconds((double) num3 / 10.5);
      new Sprite("mpmissionend", "silvermedal", new Point(int32 - 100, 680), new Size(46, 46)).Draw();
      ((UIText) new UIResText(timeSpan3.ToString("hh':'mm':'ss") ?? "", new Point(int32, 680), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      TimeSpan timeSpan4 = TimeSpan.FromSeconds((double) num1 / 10.5);
      string str3 = "bronzemedal";
      new Sprite("mpmissionend", str3, new Point(int32 + 100, 680), new Size(46, 46)).Draw();
      ((UIText) new UIResText(timeSpan4.ToString("hh':'mm':'ss") ?? "", new Point(int32 + 200, 680), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      if (Heist == 1)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "FLEECA", (M0) this.BestTime);
      if (Heist == 2)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "PALETO", (M0) this.BestTime);
      if (Heist == 3)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "PACIFICSTANDARD", (M0) this.BestTime);
      if (Heist == 4)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "VANGELICO", (M0) this.BestTime);
      if (Heist == 5)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "UNIONDEPOSITORY", (M0) this.BestTime);
      if (Heist == 6)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "LEXIGTONRAID", (M0) this.BestTime);
      if (Heist == 7)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "SURVERDOWN", (M0) this.BestTime);
      if (Heist == 8)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "NUCLEAREXPANSIONHEIST", (M0) this.BestTime);
      if (Heist == 9)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "DEEPDEAPTHSHEIST", (M0) this.BestTime);
      if (Heist == 10)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "HUMANELABS#2", (M0) this.BestTime);
      if (Heist == 11)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "YachtHeist", (M0) this.BestTime);
      if (Heist == 12)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "BerkraneJob", (M0) this.BestTime);
      if (Heist == 13)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "DiamondHeist", (M0) this.BestTime);
      TimeSpan timeSpan5 = TimeSpan.FromSeconds((double) this.BestTime / 10.5);
      if ((double) Time <= (double) num1)
        str3 = "bronzemedal";
      if ((double) Time <= (double) num3)
        str3 = "silvermedal";
      if ((double) Time <= (double) num2)
        str3 = "goldmedal";
      if (this.BestTime < this.GetTimeBronze(Heist))
      {
        if ((double) Time >= (double) this.BestTime)
        {
          new Sprite("mpmissionend", str3, new Point(int32 - 180, 750), new Size(46, 46)).Draw();
          ((UIText) new UIResText("Best : " + timeSpan5.ToString("hh':'mm':'ss"), new Point(int32, 750), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
        }
        if ((double) Time < (double) this.BestTime)
        {
          new Sprite("mpmissionend", str3, new Point(int32 - 180, 750), new Size(46, 46)).Draw();
          ((UIText) new UIResText("Best : " + timeSpan1.ToString("hh':'mm':'ss"), new Point(int32, 750), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
        }
      }
      if (this.BestTime > this.GetTimeBronze(Heist))
        ((UIText) new UIResText("Best :  No Qualifying Time", new Point(int32, 750), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void MissionFailed(
      string Reason,
      string MissionName,
      int CrewCut,
      int CrewAlive,
      float Time,
      int Heist)
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      float num4 = Time / 10.5f;
      if (Heist == 1)
      {
        MissionName = "The Fleeca Heist";
        num1 = 18500;
        num2 = 9900;
        num3 = 14500;
      }
      if (Heist == 2)
      {
        MissionName = "The Paleto Job";
        num1 = 42000;
        num2 = 26500;
        num3 = 35000;
      }
      if (Heist == 3)
      {
        MissionName = "The Pacific Standard";
        num1 = 36000;
        num2 = 22500;
        num3 = 28000;
      }
      if (Heist == 4)
      {
        MissionName = "The Jewel Store Job";
        num1 = 28000;
        num2 = 7500;
        num3 = 18000;
      }
      if (Heist == 5)
      {
        MissionName = "The Union Depository";
        num1 = 90000;
        num2 = 25500;
        num3 = 36000;
      }
      if (Heist == 6)
      {
        MissionName = "USS Luxington Raid";
        num1 = 26000;
        num2 = 19500;
        num3 = 23000;
      }
      if (Heist == 7)
      {
        MissionName = "Surver Down Heist";
        num1 = 31000;
        num2 = 18500;
        num3 = 23000;
      }
      if (Heist == 8)
      {
        MissionName = "The Nuclear Expansion";
        num1 = 28000;
        num2 = 14750;
        num3 = 20000;
      }
      if (Heist == 9)
      {
        MissionName = "Deep Deapths Heist";
        num1 = 32000;
        num2 = 22500;
        num3 = 27000;
      }
      if (Heist == 10)
      {
        MissionName = "Humane Labs #2";
        num1 = 29000;
        num2 = 17500;
        num3 = 22000;
      }
      if (Heist == 11)
      {
        MissionName = "The Yacht Heist";
        num1 = 30000;
        num2 = 20500;
        num3 = 24000;
      }
      if (Heist == 12)
      {
        MissionName = "The Belkrane Job";
        num1 = 36000;
        num2 = 18500;
        num3 = 25000;
      }
      if (Heist == 13)
      {
        MissionName = "The Diamond Casino Heist";
        num1 = 42000;
        num2 = 22500;
        num3 = 17000;
      }
      if (Heist == 14)
      {
        MissionName = "The Prison Break";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 15)
      {
        MissionName = "The Container Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 16)
      {
        MissionName = "The Humaine Labs (Online)";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 17)
      {
        MissionName = "The North Yankton Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 18)
      {
        MissionName = "The Cayo Perico Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      this.Pass = false;
      this.Fail = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 30), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 450), 0.0f, Color.FromArgb(230, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("mission failed", new Point(int32, 100), 2.5f, Color.FromArgb((int) byte.MaxValue, 148, 27, 46), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText(MissionName, new Point(int32, 230), 1.25f, Color.White, (Font) 1, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Reason : " + Reason, new Point(int32, 310), 0.5f, Color.White, (Font) 4, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void MissionPassedSetup(string MissionName, int Heist)
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      if (Heist == 1)
      {
        MissionName = "The Fleeca Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 2)
      {
        MissionName = "The Paleto Job";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 3)
      {
        MissionName = "The Pacific Standard";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 4)
      {
        MissionName = "The Jewel Store Job";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 5)
      {
        MissionName = "The Union Depository";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 6)
      {
        MissionName = "USS Luxington Raid";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 7)
      {
        MissionName = "Surver Down Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 8)
      {
        MissionName = "The Nuclear Expansion";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 9)
      {
        MissionName = "Deep Deapths Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 10)
      {
        MissionName = "Humane Labs #2";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 11)
      {
        MissionName = "The Yacht Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 12)
      {
        MissionName = "The Belkrane Job";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 13)
      {
        MissionName = "The Diamond Casino Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 14)
      {
        MissionName = "The Prison Break";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 15)
      {
        MissionName = "The Container Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 16)
      {
        MissionName = "The Humaine Labs (Online)";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 17)
      {
        MissionName = "The North Yankton Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 18)
      {
        MissionName = "The Cayo Perico Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      this.Fail = false;
      this.Pass = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 350), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("Setup passed", new Point(int32, 100), 2.5f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText(MissionName, new Point(int32, 230), 1.25f, Color.White, (Font) 1, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void MissionFailedSetup(string MissionName, string Reason, int Heist)
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      if (Heist == 1)
      {
        MissionName = "The Fleeca Heist";
        num1 = 18500;
        num2 = 9900;
        num3 = 14500;
      }
      if (Heist == 2)
      {
        MissionName = "The Paleto Job";
        num1 = 42000;
        num2 = 26500;
        num3 = 35000;
      }
      if (Heist == 3)
      {
        MissionName = "The Pacific Standard";
        num1 = 36000;
        num2 = 22500;
        num3 = 28000;
      }
      if (Heist == 4)
      {
        MissionName = "The Jewel Store Job";
        num1 = 28000;
        num2 = 7500;
        num3 = 18000;
      }
      if (Heist == 5)
      {
        MissionName = "The Union Depository";
        num1 = 90000;
        num2 = 25500;
        num3 = 36000;
      }
      if (Heist == 6)
      {
        MissionName = "USS Luxington Raid";
        num1 = 35000;
        num2 = 17500;
        num3 = 24000;
      }
      if (Heist == 7)
      {
        MissionName = "Surver Down Heist";
        num1 = 35000;
        num2 = 16500;
        num3 = 24000;
      }
      if (Heist == 8)
      {
        MissionName = "The Nuclear Expansion";
        num1 = 35000;
        num2 = 16500;
        num3 = 24000;
      }
      if (Heist == 9)
      {
        MissionName = "Deep Deapths Heist";
        num1 = 35000;
        num2 = 16500;
        num3 = 24000;
      }
      if (Heist == 10)
      {
        MissionName = "Humane Labs #2";
        num1 = 35000;
        num2 = 16500;
        num3 = 24000;
      }
      if (Heist == 9)
      {
        MissionName = "Surver Down Heist";
        num1 = 35000;
        num2 = 16500;
        num3 = 24000;
      }
      if (Heist == 10)
      {
        MissionName = "Humane Labs #2";
        num1 = 35000;
        num2 = 16500;
        num3 = 24000;
      }
      if (Heist == 11)
      {
        MissionName = "The Yacht Heist";
        num1 = 35000;
        num2 = 21500;
        num3 = 15000;
      }
      if (Heist == 12)
      {
        MissionName = "The Belkrane Job";
        num1 = 42000;
        num2 = 22500;
        num3 = 17000;
      }
      if (Heist == 13)
      {
        MissionName = "The Diamond Casino Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 14)
      {
        MissionName = "The Prison Break";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 15)
      {
        MissionName = "The Container Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 16)
      {
        MissionName = "The Humaine Labs (Online)";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 17)
      {
        MissionName = "The North Yankton Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 18)
      {
        MissionName = "The Cayo Perico Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      this.Pass = false;
      this.Fail = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 30), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 450), 0.0f, Color.FromArgb(230, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("Setup failed", new Point(int32, 100), 2.5f, Color.FromArgb((int) byte.MaxValue, 148, 27, 46), (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText(MissionName, new Point(int32, 230), 1.25f, Color.White, (Font) 1, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Reason : " + Reason, new Point(int32, 310), 0.5f, Color.White, (Font) 4, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void SetFail(
      string MissionName,
      int Payout,
      int CrewCut,
      string Reason,
      int CrewAlive,
      float Time,
      int Heist)
    {
      Audio.SetAudioFlag("LoadMPData", true);
      Audio.PlaySoundFrontend("Bed", "WastedSounds");
      Audio.SetAudioFlag("LoadMPData", false);
      this.Timer = 300;
      this.m = MissionName;
      this.p = Payout;
      this.t = Time;
      this.c = CrewAlive;
      this.r = Reason;
      this.H = Heist;
      this.cp = CrewCut;
      this.Fail = true;
      for (int index = 0; index < 300; ++index)
      {
        if (this.Fail)
          this.MissionFailed(this.r, this.m, this.cp, this.c, this.t, this.H);
        if (this.Pass)
          this.MissionPassed(this.m, this.p, this.cp, this.c, this.t, this.H);
        Script.Wait(1);
      }
    }

    public void SetPass(
      string MissionName,
      int Payout,
      int CrewCut,
      string Reason,
      int CrewAlive,
      float Time,
      int Heist)
    {
      Audio.SetAudioFlag("LoadMPData", true);
      Audio.PlaySoundFrontend("Mission_Pass_Notify", "DLC_HEISTS_GENERAL_FRONTEND_SOUNDS");
      Audio.SetAudioFlag("LoadMPData", false);
      this.Timer = 300;
      this.m = MissionName;
      this.p = Payout;
      this.t = Time;
      this.c = CrewAlive;
      this.r = Reason;
      this.H = Heist;
      this.cp = CrewCut;
      this.Pass = true;
      for (int index = 0; index < 300; ++index)
      {
        if (this.Fail)
          this.MissionFailed(this.r, this.m, this.cp, this.c, this.t, this.H);
        if (this.Pass)
          this.MissionPassed(this.m, this.p, this.cp, this.c, this.t, this.H);
        Script.Wait(1);
      }
    }

    public void SetPass_PilotCut(
      string MissionName,
      int Payout,
      int CrewCut,
      int PilotCut,
      string Reason,
      int CrewAlive,
      float Time,
      int Heist)
    {
      Audio.SetAudioFlag("LoadMPData", true);
      Audio.PlaySoundFrontend("Mission_Pass_Notify", "DLC_HEISTS_GENERAL_FRONTEND_SOUNDS");
      Audio.SetAudioFlag("LoadMPData", false);
      this.Timer = 300;
      this.m = MissionName;
      this.p = Payout;
      this.t = Time;
      this.c = CrewAlive;
      this.r = Reason;
      this.H = Heist;
      this.cp = CrewCut;
      this.Pass = true;
      this.ptc = PilotCut;
      for (int index = 0; index < 300; ++index)
      {
        if (this.Fail)
          this.MissionFailed(this.r, this.m, this.cp, this.c, this.t, this.H);
        if (this.Pass)
          this.MissionPassedPilotCut(this.m, this.p, this.cp, this.ptc, this.c, this.t, this.H);
        Script.Wait(1);
      }
    }

    public void GetHeistTimes(int Heist)
    {
      this.LoadIniFile("scripts//Payday.ini");
      string str1 = "";
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      if (Heist == 1)
      {
        str1 = "The Fleeca Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 2)
      {
        str1 = "The Paleto Job";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 3)
      {
        str1 = "The Pacific Standard";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 4)
      {
        str1 = "The Jewel Store Job";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 5)
      {
        str1 = "The Union Depository";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 6)
      {
        str1 = "USS Luxington Raid";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 7)
      {
        str1 = "Surver Down Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 8)
      {
        str1 = "The Nuclear Expansion";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 9)
      {
        str1 = "Deep Deapths Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 10)
      {
        str1 = "Humane Labs #2";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 11)
      {
        str1 = "The Yacht Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 12)
      {
        str1 = "The Belkrane Job";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 13)
      {
        str1 = "The Diamond Casino Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 14)
      {
        str1 = "The Prison Break";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 15)
      {
        str1 = "The Container Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 16)
      {
        str1 = "The Humaine Labs (Online)";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 17)
      {
        str1 = "The North Yankton Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      if (Heist == 18)
      {
        str1 = "The Cayo Perico Heist";
        num1 = this.GetTimeBronze(Heist);
        num2 = this.GetTimeGold(Heist);
        num3 = this.GetTimeSilver(Heist);
      }
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width), 1020), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText(str1, new Point(int32, 100), 2.5f, Color.FromArgb((int) byte.MaxValue, 199, 168, 87), (Font) 7, (UIResText.Alignment) 1)).Draw();
      string str2 = "goldmedal";
      TimeSpan timeSpan1 = TimeSpan.FromSeconds((double) num2 / 10.5);
      new Sprite("mpmissionend", str2, new Point(int32 - 300, 300), new Size(46, 46)).Draw();
      ((UIText) new UIResText(timeSpan1.ToString("hh':'mm':'ss") ?? "", new Point(int32 - 200, 301), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      TimeSpan timeSpan2 = TimeSpan.FromSeconds((double) num3 / 10.5);
      new Sprite("mpmissionend", "silvermedal", new Point(int32 - 100, 300), new Size(46, 46)).Draw();
      ((UIText) new UIResText(timeSpan2.ToString("hh':'mm':'ss") ?? "", new Point(int32, 301), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      TimeSpan timeSpan3 = TimeSpan.FromSeconds((double) num1 / 10.5);
      new Sprite("mpmissionend", "bronzemedal", new Point(int32 + 100, 300), new Size(46, 46)).Draw();
      ((UIText) new UIResText(timeSpan3.ToString("hh':'mm':'ss") ?? "", new Point(int32 + 200, 301), 0.5f, Color.White, (Font) 0, (UIResText.Alignment) 1)).Draw();
      if (Heist == 1)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "FLEECA", (M0) this.BestTime);
      if (Heist == 2)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "PALETO", (M0) this.BestTime);
      if (Heist == 3)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "PACIFICSTANDARD", (M0) this.BestTime);
      if (Heist == 4)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "VANGELICO", (M0) this.BestTime);
      if (Heist == 5)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "UNIONDEPOSITORY", (M0) this.BestTime);
      if (Heist == 6)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "LEXIGTONRAID", (M0) this.BestTime);
      if (Heist == 7)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "SURVERDOWN", (M0) this.BestTime);
      if (Heist == 8)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "NUCLEAREXPANSIONHEIST", (M0) this.BestTime);
      if (Heist == 9)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "DEEPDEAPTHSHEIST", (M0) this.BestTime);
      if (Heist == 10)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "HUMANELABS#2", (M0) this.BestTime);
      if (Heist == 11)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "YachtHeist", (M0) this.BestTime);
      if (Heist == 12)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "BerkraneJob", (M0) this.BestTime);
      if (Heist == 13)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "DiamondHeist", (M0) this.BestTime);
      if (Heist == 14)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "PrisonBreak", (M0) this.BestTime);
      if (Heist == 15)
        this.BestTime = (int) this.Config.GetValue<int>("BEST_TIMES", "ContainerHeist", (M0) this.BestTime);
      if (this.BestTime < num1)
        ((UIText) new UIResText("Current   :   " + TimeSpan.FromSeconds((double) this.BestTime / 10.5).ToString("hh':'mm':'ss"), new Point(int32, 360), 0.65f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      if (this.BestTime > num1)
        ((UIText) new UIResText("Current   :  No Qaulifying Time", new Point(int32, 360), 0.65f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void SetFailSetup(string MissionName, string Reason, int Heist)
    {
      Audio.SetAudioFlag("LoadMPData", true);
      Audio.PlaySoundFrontend("Bed", "WastedSounds");
      Audio.SetAudioFlag("LoadMPData", false);
      this.Timer = 300;
      this.m = MissionName;
      this.r = Reason;
      this.H = Heist;
      this.FailSetup = true;
      this.PassSetup = false;
      for (int index = 0; index < 300; ++index)
      {
        if (this.FailSetup)
          this.MissionFailedSetup(this.m, this.r, this.H);
        if (this.PassSetup)
          this.MissionPassedSetup(this.m, this.H);
        Script.Wait(1);
      }
    }

    public void SetPassSetup(string MissionName, string Reason, int Heist)
    {
      Audio.SetAudioFlag("LoadMPData", true);
      Audio.PlaySoundFrontend("Mission_Pass_Notify", "DLC_HEISTS_GENERAL_FRONTEND_SOUNDS");
      Audio.SetAudioFlag("LoadMPData", false);
      this.Timer = 300;
      this.m = MissionName;
      this.r = Reason;
      this.H = Heist;
      this.FailSetup = false;
      this.PassSetup = true;
      for (int index = 0; index < 300; ++index)
      {
        if (this.FailSetup)
          this.MissionFailedSetup(this.m, this.r, this.H);
        if (this.PassSetup)
          this.MissionPassedSetup(this.m, this.H);
        Script.Wait(1);
      }
    }

    public void DisplayTime(float Time)
    {
      float num = Time / 10.5f;
      this.Fail = false;
      this.Pass = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(0, 10), new Size(Convert.ToInt32(resolutionMantainRatio.Width + 200f), 100), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("Time " + TimeSpan.FromSeconds((double) num).ToString(), new Point(int32 + 500, 30), 0.65f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("Hold Shift then press X to Disable Popup", new Point(int32 + 500, 70), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public void DisplayAIOrderMenu(int indexX, int indexY)
    {
      this.Fail = false;
      this.Pass = true;
      SizeF resolutionMantainRatio = UIMenu.GetScreenResolutionMantainRatio();
      int int32 = Convert.ToInt32(resolutionMantainRatio.Width / 2f);
      new Sprite("mpentry", "mp_modenotselected_gradient", new Point(int32 + 500, 90), new Size(Convert.ToInt32(resolutionMantainRatio.Width + 200f), 400), 0.0f, Color.FromArgb(200, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)).Draw();
      ((UIText) new UIResText("Use Arrow key to Navigate Menu", new Point(int32 + 500, 110), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      ((UIText) new UIResText("AI Orders", new Point(int32 + 500, 130), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      if (indexX == 0)
      {
        if (indexY < 0)
          indexY = 0;
        if (indexY > 3)
          indexY = 0;
        UI.Notify("indexY " + indexY.ToString());
        if (indexY == 0)
        {
          this.AIselected = 0;
          ((UIText) new UIResText("~g~All", new Point(int32 + 500, 150), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
        }
        if (indexY == 1)
        {
          this.AIselected = 1;
          ((UIText) new UIResText("~g~AI 1", new Point(int32 + 500, 150), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
        }
        if (indexY == 2)
        {
          this.AIselected = 2;
          ((UIText) new UIResText("~g~AI 2", new Point(int32 + 500, 150), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
        }
        if (indexY == 3)
        {
          this.AIselected = 3;
          ((UIText) new UIResText("~g~AI 3", new Point(int32 + 500, 150), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
        }
      }
      else
      {
        if (this.AIselected == 0)
          ((UIText) new UIResText("~y~All", new Point(int32 + 500, 150), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
        if (this.AIselected == 1)
          ((UIText) new UIResText("~y~AI 1", new Point(int32 + 500, 150), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
        if (this.AIselected == 2)
          ((UIText) new UIResText("~y~AI 2", new Point(int32 + 500, 150), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
        if (this.AIselected == 3)
          ((UIText) new UIResText("~y~AI 3", new Point(int32 + 500, 150), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      }
      if (indexX == 1)
        ((UIText) new UIResText("~b~Exit Vehicle", new Point(int32 + 500, 170), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      else
        ((UIText) new UIResText("Exit Vehicle", new Point(int32 + 500, 170), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      if (indexX == 2)
        ((UIText) new UIResText("~b~Enter Vehicle", new Point(int32 + 500, 200), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      else
        ((UIText) new UIResText("Enter Vehicle", new Point(int32 + 500, 200), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      if (indexX == 3)
        ((UIText) new UIResText("~b~Guard Current Pos", new Point(int32 + 500, 230), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      else
        ((UIText) new UIResText("Guard Current Pos", new Point(int32 + 500, 230), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      if (indexX == 4)
        ((UIText) new UIResText("~b~Return to Player", new Point(int32 + 500, 260), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      else
        ((UIText) new UIResText("Return to Player", new Point(int32 + 500, 260), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      if (indexX == 5)
        ((UIText) new UIResText("~b~TP to Player", new Point(int32 + 500, 290), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      else
        ((UIText) new UIResText("TP to Player", new Point(int32 + 500, 290), 0.35f, Color.White, (Font) 7, (UIResText.Alignment) 1)).Draw();
      Scaleform scaleform = new Scaleform(0);
      scaleform.Load("instructional_buttons");
      scaleform.Render2D();
    }

    public MissionScreen()
    {
      this.LoadIniFile("scripts//Payday.ini");
      this.Tick += new EventHandler(this.OnTick);
    }

    public void OnTick(object sender, EventArgs e)
    {
      if (this.Timer < 0)
        return;
      --this.Timer;
    }

    public int GetTimeGold(int Heist)
    {
      string str = "";
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      if (Heist == 1)
      {
        str = "The Fleeca Heist";
        num1 = 15500;
        num2 = 7200;
        num3 = 12500;
      }
      if (Heist == 2)
      {
        str = "The Paleto Job";
        num1 = 25000;
        num2 = 14500;
        num3 = 22000;
      }
      if (Heist == 3)
      {
        str = "The Pacific Standard";
        num1 = 36000;
        num2 = 22500;
        num3 = 28000;
      }
      if (Heist == 4)
      {
        str = "The Jewel Store Job";
        num1 = 34000;
        num2 = 14000;
        num3 = 23000;
      }
      if (Heist == 5)
      {
        str = "The Union Depository";
        num1 = 22000;
        num2 = 13500;
        num3 = 17000;
      }
      if (Heist == 6)
      {
        str = "USS Luxington Raid";
        num1 = 26000;
        num2 = 19500;
        num3 = 23000;
      }
      if (Heist == 7)
      {
        str = "Surver Down Heist";
        num1 = 31000;
        num2 = 18500;
        num3 = 23000;
      }
      if (Heist == 8)
      {
        str = "The Nuclear Expansion";
        num1 = 41000;
        num2 = 27750;
        num3 = 32000;
      }
      if (Heist == 9)
      {
        str = "Deep Deapths Heist";
        num1 = 26000;
        num2 = 15500;
        num3 = 22000;
      }
      if (Heist == 10)
      {
        str = "Humane Labs #2";
        num1 = 29000;
        num2 = 17500;
        num3 = 22000;
      }
      if (Heist == 11)
      {
        str = "The Yacht Heist";
        num1 = 30000;
        num2 = 20500;
        num3 = 24000;
      }
      if (Heist == 12)
      {
        str = "The Belkrane Job";
        num1 = 28000;
        num2 = 8500;
        num3 = 18000;
      }
      if (Heist == 13)
      {
        str = "The Diamond Casino Heist";
        num1 = 28000;
        num2 = 17500;
        num3 = 24000;
      }
      if (Heist == 14)
      {
        str = "The Prison Break";
        num1 = 22000;
        num2 = 14500;
        num3 = 19000;
      }
      if (Heist == 15)
      {
        str = "The Container Heist";
        num1 = 21000;
        num2 = 12500;
        num3 = 18000;
      }
      if (Heist == 16)
      {
        str = "The Container Heist";
        num1 = 25000;
        num2 = 14500;
        num3 = 21000;
      }
      if (Heist == 17)
      {
        str = "The North Yankton Heist";
        num1 = 33500;
        num2 = 21000;
        num3 = 26500;
      }
      if (Heist == 18)
      {
        str = "The Cayo Perico Heist";
        num1 = 35500;
        num2 = 22500;
        num3 = 26900;
      }
      return num2;
    }

    public int GetTimeSilver(int Heist)
    {
      string str = "";
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      if (Heist == 1)
      {
        str = "The Fleeca Heist";
        num1 = 15500;
        num2 = 7200;
        num3 = 12500;
      }
      if (Heist == 2)
      {
        str = "The Paleto Job";
        num1 = 25000;
        num2 = 14500;
        num3 = 22000;
      }
      if (Heist == 3)
      {
        str = "The Pacific Standard";
        num1 = 36000;
        num2 = 22500;
        num3 = 28000;
      }
      if (Heist == 4)
      {
        str = "The Jewel Store Job";
        num1 = 34000;
        num2 = 14000;
        num3 = 23000;
      }
      if (Heist == 5)
      {
        str = "The Union Depository";
        num1 = 22000;
        num2 = 13500;
        num3 = 17000;
      }
      if (Heist == 6)
      {
        str = "USS Luxington Raid";
        num1 = 26000;
        num2 = 19500;
        num3 = 23000;
      }
      if (Heist == 7)
      {
        str = "Surver Down Heist";
        num1 = 31000;
        num2 = 18500;
        num3 = 23000;
      }
      if (Heist == 8)
      {
        str = "The Nuclear Expansion";
        num1 = 41000;
        num2 = 27750;
        num3 = 32000;
      }
      if (Heist == 9)
      {
        str = "Deep Deapths Heist";
        num1 = 26000;
        num2 = 15500;
        num3 = 22000;
      }
      if (Heist == 10)
      {
        str = "Humane Labs #2";
        num1 = 29000;
        num2 = 17500;
        num3 = 22000;
      }
      if (Heist == 11)
      {
        str = "The Yacht Heist";
        num1 = 30000;
        num2 = 20500;
        num3 = 24000;
      }
      if (Heist == 12)
      {
        str = "The Belkrane Job";
        num1 = 28000;
        num2 = 8500;
        num3 = 18000;
      }
      if (Heist == 13)
      {
        str = "The Diamond Casino Heist";
        num1 = 28000;
        num2 = 17500;
        num3 = 24000;
      }
      if (Heist == 14)
      {
        str = "The Prison Break";
        num1 = 22000;
        num2 = 14500;
        num3 = 19000;
      }
      if (Heist == 15)
      {
        str = "The Container Heist";
        num1 = 21000;
        num2 = 12500;
        num3 = 18000;
      }
      if (Heist == 16)
      {
        str = "The Container Heist";
        num1 = 25000;
        num2 = 14500;
        num3 = 21000;
      }
      if (Heist == 17)
      {
        str = "The North Yankton Heist";
        num1 = 33500;
        num2 = 21000;
        num3 = 26500;
      }
      if (Heist == 18)
      {
        str = "The Cayo Perico Heist";
        num1 = 35500;
        num2 = 22500;
        num3 = 26900;
      }
      return num3;
    }

    public int GetTimeBronze(int Heist)
    {
      string str = "";
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      if (Heist == 1)
      {
        str = "The Fleeca Heist";
        num1 = 15500;
        num2 = 7200;
        num3 = 12500;
      }
      if (Heist == 2)
      {
        str = "The Paleto Job";
        num1 = 25000;
        num2 = 14500;
        num3 = 22000;
      }
      if (Heist == 3)
      {
        str = "The Pacific Standard";
        num1 = 36000;
        num2 = 22500;
        num3 = 28000;
      }
      if (Heist == 4)
      {
        str = "The Jewel Store Job";
        num1 = 34000;
        num2 = 14000;
        num3 = 23000;
      }
      if (Heist == 5)
      {
        str = "The Union Depository";
        num1 = 22000;
        num2 = 13500;
        num3 = 17000;
      }
      if (Heist == 6)
      {
        str = "USS Luxington Raid";
        num1 = 26000;
        num2 = 19500;
        num3 = 23000;
      }
      if (Heist == 7)
      {
        str = "Surver Down Heist";
        num1 = 31000;
        num2 = 18500;
        num3 = 23000;
      }
      if (Heist == 8)
      {
        str = "The Nuclear Expansion";
        num1 = 41000;
        num2 = 27750;
        num3 = 32000;
      }
      if (Heist == 9)
      {
        str = "Deep Deapths Heist";
        num1 = 26000;
        num2 = 15500;
        num3 = 22000;
      }
      if (Heist == 10)
      {
        str = "Humane Labs #2";
        num1 = 29000;
        num2 = 17500;
        num3 = 22000;
      }
      if (Heist == 11)
      {
        str = "The Yacht Heist";
        num1 = 30000;
        num2 = 20500;
        num3 = 24000;
      }
      if (Heist == 12)
      {
        str = "The Belkrane Job";
        num1 = 28000;
        num2 = 8500;
        num3 = 18000;
      }
      if (Heist == 13)
      {
        str = "The Diamond Casino Heist";
        num1 = 28000;
        num2 = 17500;
        num3 = 24000;
      }
      if (Heist == 14)
      {
        str = "The Prison Break";
        num1 = 22000;
        num2 = 14500;
        num3 = 19000;
      }
      if (Heist == 15)
      {
        str = "The Container Heist";
        num1 = 21000;
        num2 = 12500;
        num3 = 18000;
      }
      if (Heist == 16)
      {
        str = "The Container Heist";
        num1 = 25000;
        num2 = 14500;
        num3 = 21000;
      }
      if (Heist == 17)
      {
        str = "The North Yankton Heist";
        num1 = 33500;
        num2 = 21000;
        num3 = 26500;
      }
      if (Heist == 18)
      {
        str = "The Cayo Perico Heist";
        num1 = 35500;
        num2 = 22500;
        num3 = 26900;
      }
      return num1;
    }
  }
}
