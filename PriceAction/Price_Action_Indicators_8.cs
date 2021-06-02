#region Using declarations
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Serialization;
using NinjaTrader.Cbi;
using NinjaTrader.Gui;
using NinjaTrader.Gui.Chart;
using NinjaTrader.Gui.SuperDom;
using NinjaTrader.Gui.Tools;
using NinjaTrader.Data;
using NinjaTrader.NinjaScript;
using NinjaTrader.Core.FloatingPoint;

#endregion



#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		
		private PriceActionIndicators.BarBear[] cacheBarBear;
		private PriceActionIndicators.BarBull[] cacheBarBull;
		private PriceActionIndicators.BarbWire[] cacheBarbWire;
		private PriceActionIndicators.BarDoji[] cacheBarDoji;
		private PriceActionIndicators.BarInside[] cacheBarInside;
		private PriceActionIndicators.BarInsideVariant[] cacheBarInsideVariant;
		private PriceActionIndicators.BarOutside[] cacheBarOutside;
		private PriceActionIndicators.Body[] cacheBody;
		private PriceActionIndicators.Overlap[] cacheOverlap;
		private PriceActionIndicators.PABuySellPressure[] cachePABuySellPressure;
		private PriceActionIndicators.PAReversalSignalBars[] cachePAReversalSignalBars;
		private PriceActionIndicators.PASignalBarBreakoutFailureTick[] cachePASignalBarBreakoutFailureTick;
		private PriceActionIndicators.PASuppResBreakoutFailureTick[] cachePASuppResBreakoutFailureTick;
		private PriceActionIndicators.PASuppResBreakoutTest[] cachePASuppResBreakoutTest;
		private PriceActionIndicators.PASuppResDBDT[] cachePASuppResDBDT;

		
		public PriceActionIndicators.BarBear BarBear()
		{
			return BarBear(Input);
		}

		public PriceActionIndicators.BarBull BarBull()
		{
			return BarBull(Input);
		}

		public PriceActionIndicators.BarbWire BarbWire()
		{
			return BarbWire(Input);
		}

		public PriceActionIndicators.BarDoji BarDoji()
		{
			return BarDoji(Input);
		}

		public PriceActionIndicators.BarInside BarInside()
		{
			return BarInside(Input);
		}

		public PriceActionIndicators.BarInsideVariant BarInsideVariant()
		{
			return BarInsideVariant(Input);
		}

		public PriceActionIndicators.BarOutside BarOutside()
		{
			return BarOutside(Input);
		}

		public PriceActionIndicators.Body Body()
		{
			return Body(Input);
		}

		public PriceActionIndicators.Overlap Overlap(int barsback)
		{
			return Overlap(Input, barsback);
		}

		public PriceActionIndicators.PABuySellPressure PABuySellPressure(bool show_MOM, bool show_EXH, bool showBodies, bool showTails, bool showOverlap, bool showBrsSrsOnOpen, int extend_Signals)
		{
			return PABuySellPressure(Input, show_MOM, show_EXH, showBodies, showTails, showOverlap, showBrsSrsOnOpen, extend_Signals);
		}

		public PriceActionIndicators.PAReversalSignalBars PAReversalSignalBars(bool showBW, bool showIB, bool showRVB, bool showII, bool showIOI, bool showOIO, bool show2BR, bool show3BR, bool showOO, bool showOB, bool showFF, bool showPB, bool showTBPB, int tickminRangeIB, int tickminRangeRVB, int tickminRangeII, int tickminRangeIOI, int tickminRangeOIO, int tickminRange2BR, int tickminRange3BR, int tickminRangeOO, int tickminRangeOB, int tickminRangePB, int tickmaxRange1stBar, int tickMinOvershoot_IB, int tickMinOvershoot_RVB, int tickMinOvershoot_II, int tickMinOvershoot_IOI, int tickMinOvershoot_OIO, int tickMinOvershoot_2BR, int tickMinOvershoot_3BR)
		{
			return PAReversalSignalBars(Input, showBW, showIB, showRVB, showII, showIOI, showOIO, show2BR, show3BR, showOO, showOB, showFF, showPB, showTBPB, tickminRangeIB, tickminRangeRVB, tickminRangeII, tickminRangeIOI, tickminRangeOIO, tickminRange2BR, tickminRange3BR, tickminRangeOO, tickminRangeOB, tickminRangePB, tickmaxRange1stBar, tickMinOvershoot_IB, tickMinOvershoot_RVB, tickMinOvershoot_II, tickMinOvershoot_IOI, tickMinOvershoot_OIO, tickMinOvershoot_2BR, tickMinOvershoot_3BR);
		}

		public PriceActionIndicators.PASignalBarBreakoutFailureTick PASignalBarBreakoutFailureTick(double percent, int myrearmSeconds, int xTF, int fontSize, int offset, int lineThickness)
		{
			return PASignalBarBreakoutFailureTick(Input, percent, myrearmSeconds, xTF, fontSize, offset, lineThickness);
		}

		public PriceActionIndicators.PASuppResBreakoutFailureTick PASuppResBreakoutFailureTick(int xTF, int tband, int strength, int lookback, bool lookback_Prior_Day, bool showHTF_B1, bool showHOYLOY, bool showShaved)
		{
			return PASuppResBreakoutFailureTick(Input, xTF, tband, strength, lookback, lookback_Prior_Day, showHTF_B1, showHOYLOY, showShaved);
		}

		public PriceActionIndicators.PASuppResBreakoutTest PASuppResBreakoutTest(int swingStrength, int tick_Pos_Tolerance, int tick_Neg_Tolerance, int tick_Min_Breakout, bool aTR_Tolerance, double aTR_Divisor, int lookback, bool lookback_Prior_Day, bool useFirstBar, bool no_MC_for_BO, bool use_Extend_Signals)
		{
			return PASuppResBreakoutTest(Input, swingStrength, tick_Pos_Tolerance, tick_Neg_Tolerance, tick_Min_Breakout, aTR_Tolerance, aTR_Divisor, lookback, lookback_Prior_Day, useFirstBar, no_MC_for_BO, use_Extend_Signals);
		}

		public PriceActionIndicators.PASuppResDBDT PASuppResDBDT(int swingStrength, int tick_Pos_Tolerance, int tick_Neg_Tolerance, bool aTR_Tolerance, double aTR_Divisor, int lookback, bool lookback_Prior_Day, bool useFirstBar, bool use_Extend_Signals, bool show_mDBDT)
		{
			return PASuppResDBDT(Input, swingStrength, tick_Pos_Tolerance, tick_Neg_Tolerance, aTR_Tolerance, aTR_Divisor, lookback, lookback_Prior_Day, useFirstBar, use_Extend_Signals, show_mDBDT);
		}


		
		public PriceActionIndicators.BarBear BarBear(ISeries<double> input)
		{
			if (cacheBarBear != null)
				for (int idx = 0; idx < cacheBarBear.Length; idx++)
					if ( cacheBarBear[idx].EqualsInput(input))
						return cacheBarBear[idx];
			return CacheIndicator<PriceActionIndicators.BarBear>(new PriceActionIndicators.BarBear(), input, ref cacheBarBear);
		}

		public PriceActionIndicators.BarBull BarBull(ISeries<double> input)
		{
			if (cacheBarBull != null)
				for (int idx = 0; idx < cacheBarBull.Length; idx++)
					if ( cacheBarBull[idx].EqualsInput(input))
						return cacheBarBull[idx];
			return CacheIndicator<PriceActionIndicators.BarBull>(new PriceActionIndicators.BarBull(), input, ref cacheBarBull);
		}

		public PriceActionIndicators.BarbWire BarbWire(ISeries<double> input)
		{
			if (cacheBarbWire != null)
				for (int idx = 0; idx < cacheBarbWire.Length; idx++)
					if ( cacheBarbWire[idx].EqualsInput(input))
						return cacheBarbWire[idx];
			return CacheIndicator<PriceActionIndicators.BarbWire>(new PriceActionIndicators.BarbWire(), input, ref cacheBarbWire);
		}

		public PriceActionIndicators.BarDoji BarDoji(ISeries<double> input)
		{
			if (cacheBarDoji != null)
				for (int idx = 0; idx < cacheBarDoji.Length; idx++)
					if ( cacheBarDoji[idx].EqualsInput(input))
						return cacheBarDoji[idx];
			return CacheIndicator<PriceActionIndicators.BarDoji>(new PriceActionIndicators.BarDoji(), input, ref cacheBarDoji);
		}

		public PriceActionIndicators.BarInside BarInside(ISeries<double> input)
		{
			if (cacheBarInside != null)
				for (int idx = 0; idx < cacheBarInside.Length; idx++)
					if ( cacheBarInside[idx].EqualsInput(input))
						return cacheBarInside[idx];
			return CacheIndicator<PriceActionIndicators.BarInside>(new PriceActionIndicators.BarInside(), input, ref cacheBarInside);
		}

		public PriceActionIndicators.BarInsideVariant BarInsideVariant(ISeries<double> input)
		{
			if (cacheBarInsideVariant != null)
				for (int idx = 0; idx < cacheBarInsideVariant.Length; idx++)
					if ( cacheBarInsideVariant[idx].EqualsInput(input))
						return cacheBarInsideVariant[idx];
			return CacheIndicator<PriceActionIndicators.BarInsideVariant>(new PriceActionIndicators.BarInsideVariant(), input, ref cacheBarInsideVariant);
		}

		public PriceActionIndicators.BarOutside BarOutside(ISeries<double> input)
		{
			if (cacheBarOutside != null)
				for (int idx = 0; idx < cacheBarOutside.Length; idx++)
					if ( cacheBarOutside[idx].EqualsInput(input))
						return cacheBarOutside[idx];
			return CacheIndicator<PriceActionIndicators.BarOutside>(new PriceActionIndicators.BarOutside(), input, ref cacheBarOutside);
		}

		public PriceActionIndicators.Body Body(ISeries<double> input)
		{
			if (cacheBody != null)
				for (int idx = 0; idx < cacheBody.Length; idx++)
					if ( cacheBody[idx].EqualsInput(input))
						return cacheBody[idx];
			return CacheIndicator<PriceActionIndicators.Body>(new PriceActionIndicators.Body(), input, ref cacheBody);
		}

		public PriceActionIndicators.Overlap Overlap(ISeries<double> input, int barsback)
		{
			if (cacheOverlap != null)
				for (int idx = 0; idx < cacheOverlap.Length; idx++)
					if (cacheOverlap[idx].barsback == barsback && cacheOverlap[idx].EqualsInput(input))
						return cacheOverlap[idx];
			return CacheIndicator<PriceActionIndicators.Overlap>(new PriceActionIndicators.Overlap(){ barsback = barsback }, input, ref cacheOverlap);
		}

		public PriceActionIndicators.PABuySellPressure PABuySellPressure(ISeries<double> input, bool show_MOM, bool show_EXH, bool showBodies, bool showTails, bool showOverlap, bool showBrsSrsOnOpen, int extend_Signals)
		{
			if (cachePABuySellPressure != null)
				for (int idx = 0; idx < cachePABuySellPressure.Length; idx++)
					if (cachePABuySellPressure[idx].Show_MOM == show_MOM && cachePABuySellPressure[idx].Show_EXH == show_EXH && cachePABuySellPressure[idx].showBodies == showBodies && cachePABuySellPressure[idx].showTails == showTails && cachePABuySellPressure[idx].showOverlap == showOverlap && cachePABuySellPressure[idx].showBrsSrsOnOpen == showBrsSrsOnOpen && cachePABuySellPressure[idx].Extend_Signals == extend_Signals && cachePABuySellPressure[idx].EqualsInput(input))
						return cachePABuySellPressure[idx];
			return CacheIndicator<PriceActionIndicators.PABuySellPressure>(new PriceActionIndicators.PABuySellPressure(){ Show_MOM = show_MOM, Show_EXH = show_EXH, showBodies = showBodies, showTails = showTails, showOverlap = showOverlap, showBrsSrsOnOpen = showBrsSrsOnOpen, Extend_Signals = extend_Signals }, input, ref cachePABuySellPressure);
		}

		public PriceActionIndicators.PAReversalSignalBars PAReversalSignalBars(ISeries<double> input, bool showBW, bool showIB, bool showRVB, bool showII, bool showIOI, bool showOIO, bool show2BR, bool show3BR, bool showOO, bool showOB, bool showFF, bool showPB, bool showTBPB, int tickminRangeIB, int tickminRangeRVB, int tickminRangeII, int tickminRangeIOI, int tickminRangeOIO, int tickminRange2BR, int tickminRange3BR, int tickminRangeOO, int tickminRangeOB, int tickminRangePB, int tickmaxRange1stBar, int tickMinOvershoot_IB, int tickMinOvershoot_RVB, int tickMinOvershoot_II, int tickMinOvershoot_IOI, int tickMinOvershoot_OIO, int tickMinOvershoot_2BR, int tickMinOvershoot_3BR)
		{
			if (cachePAReversalSignalBars != null)
				for (int idx = 0; idx < cachePAReversalSignalBars.Length; idx++)
					if (cachePAReversalSignalBars[idx].showBW == showBW && cachePAReversalSignalBars[idx].showIB == showIB && cachePAReversalSignalBars[idx].showRVB == showRVB && cachePAReversalSignalBars[idx].showII == showII && cachePAReversalSignalBars[idx].showIOI == showIOI && cachePAReversalSignalBars[idx].showOIO == showOIO && cachePAReversalSignalBars[idx].show2BR == show2BR && cachePAReversalSignalBars[idx].show3BR == show3BR && cachePAReversalSignalBars[idx].showOO == showOO && cachePAReversalSignalBars[idx].showOB == showOB && cachePAReversalSignalBars[idx].showFF == showFF && cachePAReversalSignalBars[idx].showPB == showPB && cachePAReversalSignalBars[idx].showTBPB == showTBPB && cachePAReversalSignalBars[idx].TickminRangeIB == tickminRangeIB && cachePAReversalSignalBars[idx].TickminRangeRVB == tickminRangeRVB && cachePAReversalSignalBars[idx].TickminRangeII == tickminRangeII && cachePAReversalSignalBars[idx].TickminRangeIOI == tickminRangeIOI && cachePAReversalSignalBars[idx].TickminRangeOIO == tickminRangeOIO && cachePAReversalSignalBars[idx].TickminRange2BR == tickminRange2BR && cachePAReversalSignalBars[idx].TickminRange3BR == tickminRange3BR && cachePAReversalSignalBars[idx].TickminRangeOO == tickminRangeOO && cachePAReversalSignalBars[idx].TickminRangeOB == tickminRangeOB && cachePAReversalSignalBars[idx].TickminRangePB == tickminRangePB && cachePAReversalSignalBars[idx].TickmaxRange1stBar == tickmaxRange1stBar && cachePAReversalSignalBars[idx].TickMinOvershoot_IB == tickMinOvershoot_IB && cachePAReversalSignalBars[idx].TickMinOvershoot_RVB == tickMinOvershoot_RVB && cachePAReversalSignalBars[idx].TickMinOvershoot_II == tickMinOvershoot_II && cachePAReversalSignalBars[idx].TickMinOvershoot_IOI == tickMinOvershoot_IOI && cachePAReversalSignalBars[idx].TickMinOvershoot_OIO == tickMinOvershoot_OIO && cachePAReversalSignalBars[idx].TickMinOvershoot_2BR == tickMinOvershoot_2BR && cachePAReversalSignalBars[idx].TickMinOvershoot_3BR == tickMinOvershoot_3BR && cachePAReversalSignalBars[idx].EqualsInput(input))
						return cachePAReversalSignalBars[idx];
			return CacheIndicator<PriceActionIndicators.PAReversalSignalBars>(new PriceActionIndicators.PAReversalSignalBars(){ showBW = showBW, showIB = showIB, showRVB = showRVB, showII = showII, showIOI = showIOI, showOIO = showOIO, show2BR = show2BR, show3BR = show3BR, showOO = showOO, showOB = showOB, showFF = showFF, showPB = showPB, showTBPB = showTBPB, TickminRangeIB = tickminRangeIB, TickminRangeRVB = tickminRangeRVB, TickminRangeII = tickminRangeII, TickminRangeIOI = tickminRangeIOI, TickminRangeOIO = tickminRangeOIO, TickminRange2BR = tickminRange2BR, TickminRange3BR = tickminRange3BR, TickminRangeOO = tickminRangeOO, TickminRangeOB = tickminRangeOB, TickminRangePB = tickminRangePB, TickmaxRange1stBar = tickmaxRange1stBar, TickMinOvershoot_IB = tickMinOvershoot_IB, TickMinOvershoot_RVB = tickMinOvershoot_RVB, TickMinOvershoot_II = tickMinOvershoot_II, TickMinOvershoot_IOI = tickMinOvershoot_IOI, TickMinOvershoot_OIO = tickMinOvershoot_OIO, TickMinOvershoot_2BR = tickMinOvershoot_2BR, TickMinOvershoot_3BR = tickMinOvershoot_3BR }, input, ref cachePAReversalSignalBars);
		}

		public PriceActionIndicators.PASignalBarBreakoutFailureTick PASignalBarBreakoutFailureTick(ISeries<double> input, double percent, int myrearmSeconds, int xTF, int fontSize, int offset, int lineThickness)
		{
			if (cachePASignalBarBreakoutFailureTick != null)
				for (int idx = 0; idx < cachePASignalBarBreakoutFailureTick.Length; idx++)
					if (cachePASignalBarBreakoutFailureTick[idx].percent == percent && cachePASignalBarBreakoutFailureTick[idx].myrearmSeconds == myrearmSeconds && cachePASignalBarBreakoutFailureTick[idx].xTF == xTF && cachePASignalBarBreakoutFailureTick[idx].fontSize == fontSize && cachePASignalBarBreakoutFailureTick[idx].offset == offset && cachePASignalBarBreakoutFailureTick[idx].lineThickness == lineThickness && cachePASignalBarBreakoutFailureTick[idx].EqualsInput(input))
						return cachePASignalBarBreakoutFailureTick[idx];
			return CacheIndicator<PriceActionIndicators.PASignalBarBreakoutFailureTick>(new PriceActionIndicators.PASignalBarBreakoutFailureTick(){ percent = percent, myrearmSeconds = myrearmSeconds, xTF = xTF, fontSize = fontSize, offset = offset, lineThickness = lineThickness }, input, ref cachePASignalBarBreakoutFailureTick);
		}

		public PriceActionIndicators.PASuppResBreakoutFailureTick PASuppResBreakoutFailureTick(ISeries<double> input, int xTF, int tband, int strength, int lookback, bool lookback_Prior_Day, bool showHTF_B1, bool showHOYLOY, bool showShaved)
		{
			if (cachePASuppResBreakoutFailureTick != null)
				for (int idx = 0; idx < cachePASuppResBreakoutFailureTick.Length; idx++)
					if (cachePASuppResBreakoutFailureTick[idx].xTF == xTF && cachePASuppResBreakoutFailureTick[idx].tband == tband && cachePASuppResBreakoutFailureTick[idx].strength == strength && cachePASuppResBreakoutFailureTick[idx].lookback == lookback && cachePASuppResBreakoutFailureTick[idx].lookback_Prior_Day == lookback_Prior_Day && cachePASuppResBreakoutFailureTick[idx].showHTF_B1 == showHTF_B1 && cachePASuppResBreakoutFailureTick[idx].showHOYLOY == showHOYLOY && cachePASuppResBreakoutFailureTick[idx].showShaved == showShaved && cachePASuppResBreakoutFailureTick[idx].EqualsInput(input))
						return cachePASuppResBreakoutFailureTick[idx];
			return CacheIndicator<PriceActionIndicators.PASuppResBreakoutFailureTick>(new PriceActionIndicators.PASuppResBreakoutFailureTick(){ xTF = xTF, tband = tband, strength = strength, lookback = lookback, lookback_Prior_Day = lookback_Prior_Day, showHTF_B1 = showHTF_B1, showHOYLOY = showHOYLOY, showShaved = showShaved }, input, ref cachePASuppResBreakoutFailureTick);
		}

		public PriceActionIndicators.PASuppResBreakoutTest PASuppResBreakoutTest(ISeries<double> input, int swingStrength, int tick_Pos_Tolerance, int tick_Neg_Tolerance, int tick_Min_Breakout, bool aTR_Tolerance, double aTR_Divisor, int lookback, bool lookback_Prior_Day, bool useFirstBar, bool no_MC_for_BO, bool use_Extend_Signals)
		{
			if (cachePASuppResBreakoutTest != null)
				for (int idx = 0; idx < cachePASuppResBreakoutTest.Length; idx++)
					if (cachePASuppResBreakoutTest[idx].swingStrength == swingStrength && cachePASuppResBreakoutTest[idx].tick_Pos_Tolerance == tick_Pos_Tolerance && cachePASuppResBreakoutTest[idx].tick_Neg_Tolerance == tick_Neg_Tolerance && cachePASuppResBreakoutTest[idx].tick_Min_Breakout == tick_Min_Breakout && cachePASuppResBreakoutTest[idx].aTR_Tolerance == aTR_Tolerance && cachePASuppResBreakoutTest[idx].aTR_Divisor == aTR_Divisor && cachePASuppResBreakoutTest[idx].lookback == lookback && cachePASuppResBreakoutTest[idx].lookback_Prior_Day == lookback_Prior_Day && cachePASuppResBreakoutTest[idx].useFirstBar == useFirstBar && cachePASuppResBreakoutTest[idx].No_MC_for_BO == no_MC_for_BO && cachePASuppResBreakoutTest[idx].use_Extend_Signals == use_Extend_Signals && cachePASuppResBreakoutTest[idx].EqualsInput(input))
						return cachePASuppResBreakoutTest[idx];
			return CacheIndicator<PriceActionIndicators.PASuppResBreakoutTest>(new PriceActionIndicators.PASuppResBreakoutTest(){ swingStrength = swingStrength, tick_Pos_Tolerance = tick_Pos_Tolerance, tick_Neg_Tolerance = tick_Neg_Tolerance, tick_Min_Breakout = tick_Min_Breakout, aTR_Tolerance = aTR_Tolerance, aTR_Divisor = aTR_Divisor, lookback = lookback, lookback_Prior_Day = lookback_Prior_Day, useFirstBar = useFirstBar, No_MC_for_BO = no_MC_for_BO, use_Extend_Signals = use_Extend_Signals }, input, ref cachePASuppResBreakoutTest);
		}

		public PriceActionIndicators.PASuppResDBDT PASuppResDBDT(ISeries<double> input, int swingStrength, int tick_Pos_Tolerance, int tick_Neg_Tolerance, bool aTR_Tolerance, double aTR_Divisor, int lookback, bool lookback_Prior_Day, bool useFirstBar, bool use_Extend_Signals, bool show_mDBDT)
		{
			if (cachePASuppResDBDT != null)
				for (int idx = 0; idx < cachePASuppResDBDT.Length; idx++)
					if (cachePASuppResDBDT[idx].swingStrength == swingStrength && cachePASuppResDBDT[idx].tick_Pos_Tolerance == tick_Pos_Tolerance && cachePASuppResDBDT[idx].tick_Neg_Tolerance == tick_Neg_Tolerance && cachePASuppResDBDT[idx].aTR_Tolerance == aTR_Tolerance && cachePASuppResDBDT[idx].aTR_Divisor == aTR_Divisor && cachePASuppResDBDT[idx].lookback == lookback && cachePASuppResDBDT[idx].lookback_Prior_Day == lookback_Prior_Day && cachePASuppResDBDT[idx].useFirstBar == useFirstBar && cachePASuppResDBDT[idx].use_Extend_Signals == use_Extend_Signals && cachePASuppResDBDT[idx].Show_mDBDT == show_mDBDT && cachePASuppResDBDT[idx].EqualsInput(input))
						return cachePASuppResDBDT[idx];
			return CacheIndicator<PriceActionIndicators.PASuppResDBDT>(new PriceActionIndicators.PASuppResDBDT(){ swingStrength = swingStrength, tick_Pos_Tolerance = tick_Pos_Tolerance, tick_Neg_Tolerance = tick_Neg_Tolerance, aTR_Tolerance = aTR_Tolerance, aTR_Divisor = aTR_Divisor, lookback = lookback, lookback_Prior_Day = lookback_Prior_Day, useFirstBar = useFirstBar, use_Extend_Signals = use_Extend_Signals, Show_mDBDT = show_mDBDT }, input, ref cachePASuppResDBDT);
		}

	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		
		public Indicators.PriceActionIndicators.BarBear BarBear()
		{
			return indicator.BarBear(Input);
		}

		public Indicators.PriceActionIndicators.BarBull BarBull()
		{
			return indicator.BarBull(Input);
		}

		public Indicators.PriceActionIndicators.BarbWire BarbWire()
		{
			return indicator.BarbWire(Input);
		}

		public Indicators.PriceActionIndicators.BarDoji BarDoji()
		{
			return indicator.BarDoji(Input);
		}

		public Indicators.PriceActionIndicators.BarInside BarInside()
		{
			return indicator.BarInside(Input);
		}

		public Indicators.PriceActionIndicators.BarInsideVariant BarInsideVariant()
		{
			return indicator.BarInsideVariant(Input);
		}

		public Indicators.PriceActionIndicators.BarOutside BarOutside()
		{
			return indicator.BarOutside(Input);
		}

		public Indicators.PriceActionIndicators.Body Body()
		{
			return indicator.Body(Input);
		}

		public Indicators.PriceActionIndicators.Overlap Overlap(int barsback)
		{
			return indicator.Overlap(Input, barsback);
		}

		public Indicators.PriceActionIndicators.PABuySellPressure PABuySellPressure(bool show_MOM, bool show_EXH, bool showBodies, bool showTails, bool showOverlap, bool showBrsSrsOnOpen, int extend_Signals)
		{
			return indicator.PABuySellPressure(Input, show_MOM, show_EXH, showBodies, showTails, showOverlap, showBrsSrsOnOpen, extend_Signals);
		}

		public Indicators.PriceActionIndicators.PAReversalSignalBars PAReversalSignalBars(bool showBW, bool showIB, bool showRVB, bool showII, bool showIOI, bool showOIO, bool show2BR, bool show3BR, bool showOO, bool showOB, bool showFF, bool showPB, bool showTBPB, int tickminRangeIB, int tickminRangeRVB, int tickminRangeII, int tickminRangeIOI, int tickminRangeOIO, int tickminRange2BR, int tickminRange3BR, int tickminRangeOO, int tickminRangeOB, int tickminRangePB, int tickmaxRange1stBar, int tickMinOvershoot_IB, int tickMinOvershoot_RVB, int tickMinOvershoot_II, int tickMinOvershoot_IOI, int tickMinOvershoot_OIO, int tickMinOvershoot_2BR, int tickMinOvershoot_3BR)
		{
			return indicator.PAReversalSignalBars(Input, showBW, showIB, showRVB, showII, showIOI, showOIO, show2BR, show3BR, showOO, showOB, showFF, showPB, showTBPB, tickminRangeIB, tickminRangeRVB, tickminRangeII, tickminRangeIOI, tickminRangeOIO, tickminRange2BR, tickminRange3BR, tickminRangeOO, tickminRangeOB, tickminRangePB, tickmaxRange1stBar, tickMinOvershoot_IB, tickMinOvershoot_RVB, tickMinOvershoot_II, tickMinOvershoot_IOI, tickMinOvershoot_OIO, tickMinOvershoot_2BR, tickMinOvershoot_3BR);
		}

		public Indicators.PriceActionIndicators.PASignalBarBreakoutFailureTick PASignalBarBreakoutFailureTick(double percent, int myrearmSeconds, int xTF, int fontSize, int offset, int lineThickness)
		{
			return indicator.PASignalBarBreakoutFailureTick(Input, percent, myrearmSeconds, xTF, fontSize, offset, lineThickness);
		}

		public Indicators.PriceActionIndicators.PASuppResBreakoutFailureTick PASuppResBreakoutFailureTick(int xTF, int tband, int strength, int lookback, bool lookback_Prior_Day, bool showHTF_B1, bool showHOYLOY, bool showShaved)
		{
			return indicator.PASuppResBreakoutFailureTick(Input, xTF, tband, strength, lookback, lookback_Prior_Day, showHTF_B1, showHOYLOY, showShaved);
		}

		public Indicators.PriceActionIndicators.PASuppResBreakoutTest PASuppResBreakoutTest(int swingStrength, int tick_Pos_Tolerance, int tick_Neg_Tolerance, int tick_Min_Breakout, bool aTR_Tolerance, double aTR_Divisor, int lookback, bool lookback_Prior_Day, bool useFirstBar, bool no_MC_for_BO, bool use_Extend_Signals)
		{
			return indicator.PASuppResBreakoutTest(Input, swingStrength, tick_Pos_Tolerance, tick_Neg_Tolerance, tick_Min_Breakout, aTR_Tolerance, aTR_Divisor, lookback, lookback_Prior_Day, useFirstBar, no_MC_for_BO, use_Extend_Signals);
		}

		public Indicators.PriceActionIndicators.PASuppResDBDT PASuppResDBDT(int swingStrength, int tick_Pos_Tolerance, int tick_Neg_Tolerance, bool aTR_Tolerance, double aTR_Divisor, int lookback, bool lookback_Prior_Day, bool useFirstBar, bool use_Extend_Signals, bool show_mDBDT)
		{
			return indicator.PASuppResDBDT(Input, swingStrength, tick_Pos_Tolerance, tick_Neg_Tolerance, aTR_Tolerance, aTR_Divisor, lookback, lookback_Prior_Day, useFirstBar, use_Extend_Signals, show_mDBDT);
		}


		
		public Indicators.PriceActionIndicators.BarBear BarBear(ISeries<double> input )
		{
			return indicator.BarBear(input);
		}

		public Indicators.PriceActionIndicators.BarBull BarBull(ISeries<double> input )
		{
			return indicator.BarBull(input);
		}

		public Indicators.PriceActionIndicators.BarbWire BarbWire(ISeries<double> input )
		{
			return indicator.BarbWire(input);
		}

		public Indicators.PriceActionIndicators.BarDoji BarDoji(ISeries<double> input )
		{
			return indicator.BarDoji(input);
		}

		public Indicators.PriceActionIndicators.BarInside BarInside(ISeries<double> input )
		{
			return indicator.BarInside(input);
		}

		public Indicators.PriceActionIndicators.BarInsideVariant BarInsideVariant(ISeries<double> input )
		{
			return indicator.BarInsideVariant(input);
		}

		public Indicators.PriceActionIndicators.BarOutside BarOutside(ISeries<double> input )
		{
			return indicator.BarOutside(input);
		}

		public Indicators.PriceActionIndicators.Body Body(ISeries<double> input )
		{
			return indicator.Body(input);
		}

		public Indicators.PriceActionIndicators.Overlap Overlap(ISeries<double> input , int barsback)
		{
			return indicator.Overlap(input, barsback);
		}

		public Indicators.PriceActionIndicators.PABuySellPressure PABuySellPressure(ISeries<double> input , bool show_MOM, bool show_EXH, bool showBodies, bool showTails, bool showOverlap, bool showBrsSrsOnOpen, int extend_Signals)
		{
			return indicator.PABuySellPressure(input, show_MOM, show_EXH, showBodies, showTails, showOverlap, showBrsSrsOnOpen, extend_Signals);
		}

		public Indicators.PriceActionIndicators.PAReversalSignalBars PAReversalSignalBars(ISeries<double> input , bool showBW, bool showIB, bool showRVB, bool showII, bool showIOI, bool showOIO, bool show2BR, bool show3BR, bool showOO, bool showOB, bool showFF, bool showPB, bool showTBPB, int tickminRangeIB, int tickminRangeRVB, int tickminRangeII, int tickminRangeIOI, int tickminRangeOIO, int tickminRange2BR, int tickminRange3BR, int tickminRangeOO, int tickminRangeOB, int tickminRangePB, int tickmaxRange1stBar, int tickMinOvershoot_IB, int tickMinOvershoot_RVB, int tickMinOvershoot_II, int tickMinOvershoot_IOI, int tickMinOvershoot_OIO, int tickMinOvershoot_2BR, int tickMinOvershoot_3BR)
		{
			return indicator.PAReversalSignalBars(input, showBW, showIB, showRVB, showII, showIOI, showOIO, show2BR, show3BR, showOO, showOB, showFF, showPB, showTBPB, tickminRangeIB, tickminRangeRVB, tickminRangeII, tickminRangeIOI, tickminRangeOIO, tickminRange2BR, tickminRange3BR, tickminRangeOO, tickminRangeOB, tickminRangePB, tickmaxRange1stBar, tickMinOvershoot_IB, tickMinOvershoot_RVB, tickMinOvershoot_II, tickMinOvershoot_IOI, tickMinOvershoot_OIO, tickMinOvershoot_2BR, tickMinOvershoot_3BR);
		}

		public Indicators.PriceActionIndicators.PASignalBarBreakoutFailureTick PASignalBarBreakoutFailureTick(ISeries<double> input , double percent, int myrearmSeconds, int xTF, int fontSize, int offset, int lineThickness)
		{
			return indicator.PASignalBarBreakoutFailureTick(input, percent, myrearmSeconds, xTF, fontSize, offset, lineThickness);
		}

		public Indicators.PriceActionIndicators.PASuppResBreakoutFailureTick PASuppResBreakoutFailureTick(ISeries<double> input , int xTF, int tband, int strength, int lookback, bool lookback_Prior_Day, bool showHTF_B1, bool showHOYLOY, bool showShaved)
		{
			return indicator.PASuppResBreakoutFailureTick(input, xTF, tband, strength, lookback, lookback_Prior_Day, showHTF_B1, showHOYLOY, showShaved);
		}

		public Indicators.PriceActionIndicators.PASuppResBreakoutTest PASuppResBreakoutTest(ISeries<double> input , int swingStrength, int tick_Pos_Tolerance, int tick_Neg_Tolerance, int tick_Min_Breakout, bool aTR_Tolerance, double aTR_Divisor, int lookback, bool lookback_Prior_Day, bool useFirstBar, bool no_MC_for_BO, bool use_Extend_Signals)
		{
			return indicator.PASuppResBreakoutTest(input, swingStrength, tick_Pos_Tolerance, tick_Neg_Tolerance, tick_Min_Breakout, aTR_Tolerance, aTR_Divisor, lookback, lookback_Prior_Day, useFirstBar, no_MC_for_BO, use_Extend_Signals);
		}

		public Indicators.PriceActionIndicators.PASuppResDBDT PASuppResDBDT(ISeries<double> input , int swingStrength, int tick_Pos_Tolerance, int tick_Neg_Tolerance, bool aTR_Tolerance, double aTR_Divisor, int lookback, bool lookback_Prior_Day, bool useFirstBar, bool use_Extend_Signals, bool show_mDBDT)
		{
			return indicator.PASuppResDBDT(input, swingStrength, tick_Pos_Tolerance, tick_Neg_Tolerance, aTR_Tolerance, aTR_Divisor, lookback, lookback_Prior_Day, useFirstBar, use_Extend_Signals, show_mDBDT);
		}
	
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		
		public Indicators.PriceActionIndicators.BarBear BarBear()
		{
			return indicator.BarBear(Input);
		}

		public Indicators.PriceActionIndicators.BarBull BarBull()
		{
			return indicator.BarBull(Input);
		}

		public Indicators.PriceActionIndicators.BarbWire BarbWire()
		{
			return indicator.BarbWire(Input);
		}

		public Indicators.PriceActionIndicators.BarDoji BarDoji()
		{
			return indicator.BarDoji(Input);
		}

		public Indicators.PriceActionIndicators.BarInside BarInside()
		{
			return indicator.BarInside(Input);
		}

		public Indicators.PriceActionIndicators.BarInsideVariant BarInsideVariant()
		{
			return indicator.BarInsideVariant(Input);
		}

		public Indicators.PriceActionIndicators.BarOutside BarOutside()
		{
			return indicator.BarOutside(Input);
		}

		public Indicators.PriceActionIndicators.Body Body()
		{
			return indicator.Body(Input);
		}

		public Indicators.PriceActionIndicators.Overlap Overlap(int barsback)
		{
			return indicator.Overlap(Input, barsback);
		}

		public Indicators.PriceActionIndicators.PABuySellPressure PABuySellPressure(bool show_MOM, bool show_EXH, bool showBodies, bool showTails, bool showOverlap, bool showBrsSrsOnOpen, int extend_Signals)
		{
			return indicator.PABuySellPressure(Input, show_MOM, show_EXH, showBodies, showTails, showOverlap, showBrsSrsOnOpen, extend_Signals);
		}

		public Indicators.PriceActionIndicators.PAReversalSignalBars PAReversalSignalBars(bool showBW, bool showIB, bool showRVB, bool showII, bool showIOI, bool showOIO, bool show2BR, bool show3BR, bool showOO, bool showOB, bool showFF, bool showPB, bool showTBPB, int tickminRangeIB, int tickminRangeRVB, int tickminRangeII, int tickminRangeIOI, int tickminRangeOIO, int tickminRange2BR, int tickminRange3BR, int tickminRangeOO, int tickminRangeOB, int tickminRangePB, int tickmaxRange1stBar, int tickMinOvershoot_IB, int tickMinOvershoot_RVB, int tickMinOvershoot_II, int tickMinOvershoot_IOI, int tickMinOvershoot_OIO, int tickMinOvershoot_2BR, int tickMinOvershoot_3BR)
		{
			return indicator.PAReversalSignalBars(Input, showBW, showIB, showRVB, showII, showIOI, showOIO, show2BR, show3BR, showOO, showOB, showFF, showPB, showTBPB, tickminRangeIB, tickminRangeRVB, tickminRangeII, tickminRangeIOI, tickminRangeOIO, tickminRange2BR, tickminRange3BR, tickminRangeOO, tickminRangeOB, tickminRangePB, tickmaxRange1stBar, tickMinOvershoot_IB, tickMinOvershoot_RVB, tickMinOvershoot_II, tickMinOvershoot_IOI, tickMinOvershoot_OIO, tickMinOvershoot_2BR, tickMinOvershoot_3BR);
		}

		public Indicators.PriceActionIndicators.PASignalBarBreakoutFailureTick PASignalBarBreakoutFailureTick(double percent, int myrearmSeconds, int xTF, int fontSize, int offset, int lineThickness)
		{
			return indicator.PASignalBarBreakoutFailureTick(Input, percent, myrearmSeconds, xTF, fontSize, offset, lineThickness);
		}

		public Indicators.PriceActionIndicators.PASuppResBreakoutFailureTick PASuppResBreakoutFailureTick(int xTF, int tband, int strength, int lookback, bool lookback_Prior_Day, bool showHTF_B1, bool showHOYLOY, bool showShaved)
		{
			return indicator.PASuppResBreakoutFailureTick(Input, xTF, tband, strength, lookback, lookback_Prior_Day, showHTF_B1, showHOYLOY, showShaved);
		}

		public Indicators.PriceActionIndicators.PASuppResBreakoutTest PASuppResBreakoutTest(int swingStrength, int tick_Pos_Tolerance, int tick_Neg_Tolerance, int tick_Min_Breakout, bool aTR_Tolerance, double aTR_Divisor, int lookback, bool lookback_Prior_Day, bool useFirstBar, bool no_MC_for_BO, bool use_Extend_Signals)
		{
			return indicator.PASuppResBreakoutTest(Input, swingStrength, tick_Pos_Tolerance, tick_Neg_Tolerance, tick_Min_Breakout, aTR_Tolerance, aTR_Divisor, lookback, lookback_Prior_Day, useFirstBar, no_MC_for_BO, use_Extend_Signals);
		}

		public Indicators.PriceActionIndicators.PASuppResDBDT PASuppResDBDT(int swingStrength, int tick_Pos_Tolerance, int tick_Neg_Tolerance, bool aTR_Tolerance, double aTR_Divisor, int lookback, bool lookback_Prior_Day, bool useFirstBar, bool use_Extend_Signals, bool show_mDBDT)
		{
			return indicator.PASuppResDBDT(Input, swingStrength, tick_Pos_Tolerance, tick_Neg_Tolerance, aTR_Tolerance, aTR_Divisor, lookback, lookback_Prior_Day, useFirstBar, use_Extend_Signals, show_mDBDT);
		}


		
		public Indicators.PriceActionIndicators.BarBear BarBear(ISeries<double> input )
		{
			return indicator.BarBear(input);
		}

		public Indicators.PriceActionIndicators.BarBull BarBull(ISeries<double> input )
		{
			return indicator.BarBull(input);
		}

		public Indicators.PriceActionIndicators.BarbWire BarbWire(ISeries<double> input )
		{
			return indicator.BarbWire(input);
		}

		public Indicators.PriceActionIndicators.BarDoji BarDoji(ISeries<double> input )
		{
			return indicator.BarDoji(input);
		}

		public Indicators.PriceActionIndicators.BarInside BarInside(ISeries<double> input )
		{
			return indicator.BarInside(input);
		}

		public Indicators.PriceActionIndicators.BarInsideVariant BarInsideVariant(ISeries<double> input )
		{
			return indicator.BarInsideVariant(input);
		}

		public Indicators.PriceActionIndicators.BarOutside BarOutside(ISeries<double> input )
		{
			return indicator.BarOutside(input);
		}

		public Indicators.PriceActionIndicators.Body Body(ISeries<double> input )
		{
			return indicator.Body(input);
		}

		public Indicators.PriceActionIndicators.Overlap Overlap(ISeries<double> input , int barsback)
		{
			return indicator.Overlap(input, barsback);
		}

		public Indicators.PriceActionIndicators.PABuySellPressure PABuySellPressure(ISeries<double> input , bool show_MOM, bool show_EXH, bool showBodies, bool showTails, bool showOverlap, bool showBrsSrsOnOpen, int extend_Signals)
		{
			return indicator.PABuySellPressure(input, show_MOM, show_EXH, showBodies, showTails, showOverlap, showBrsSrsOnOpen, extend_Signals);
		}

		public Indicators.PriceActionIndicators.PAReversalSignalBars PAReversalSignalBars(ISeries<double> input , bool showBW, bool showIB, bool showRVB, bool showII, bool showIOI, bool showOIO, bool show2BR, bool show3BR, bool showOO, bool showOB, bool showFF, bool showPB, bool showTBPB, int tickminRangeIB, int tickminRangeRVB, int tickminRangeII, int tickminRangeIOI, int tickminRangeOIO, int tickminRange2BR, int tickminRange3BR, int tickminRangeOO, int tickminRangeOB, int tickminRangePB, int tickmaxRange1stBar, int tickMinOvershoot_IB, int tickMinOvershoot_RVB, int tickMinOvershoot_II, int tickMinOvershoot_IOI, int tickMinOvershoot_OIO, int tickMinOvershoot_2BR, int tickMinOvershoot_3BR)
		{
			return indicator.PAReversalSignalBars(input, showBW, showIB, showRVB, showII, showIOI, showOIO, show2BR, show3BR, showOO, showOB, showFF, showPB, showTBPB, tickminRangeIB, tickminRangeRVB, tickminRangeII, tickminRangeIOI, tickminRangeOIO, tickminRange2BR, tickminRange3BR, tickminRangeOO, tickminRangeOB, tickminRangePB, tickmaxRange1stBar, tickMinOvershoot_IB, tickMinOvershoot_RVB, tickMinOvershoot_II, tickMinOvershoot_IOI, tickMinOvershoot_OIO, tickMinOvershoot_2BR, tickMinOvershoot_3BR);
		}

		public Indicators.PriceActionIndicators.PASignalBarBreakoutFailureTick PASignalBarBreakoutFailureTick(ISeries<double> input , double percent, int myrearmSeconds, int xTF, int fontSize, int offset, int lineThickness)
		{
			return indicator.PASignalBarBreakoutFailureTick(input, percent, myrearmSeconds, xTF, fontSize, offset, lineThickness);
		}

		public Indicators.PriceActionIndicators.PASuppResBreakoutFailureTick PASuppResBreakoutFailureTick(ISeries<double> input , int xTF, int tband, int strength, int lookback, bool lookback_Prior_Day, bool showHTF_B1, bool showHOYLOY, bool showShaved)
		{
			return indicator.PASuppResBreakoutFailureTick(input, xTF, tband, strength, lookback, lookback_Prior_Day, showHTF_B1, showHOYLOY, showShaved);
		}

		public Indicators.PriceActionIndicators.PASuppResBreakoutTest PASuppResBreakoutTest(ISeries<double> input , int swingStrength, int tick_Pos_Tolerance, int tick_Neg_Tolerance, int tick_Min_Breakout, bool aTR_Tolerance, double aTR_Divisor, int lookback, bool lookback_Prior_Day, bool useFirstBar, bool no_MC_for_BO, bool use_Extend_Signals)
		{
			return indicator.PASuppResBreakoutTest(input, swingStrength, tick_Pos_Tolerance, tick_Neg_Tolerance, tick_Min_Breakout, aTR_Tolerance, aTR_Divisor, lookback, lookback_Prior_Day, useFirstBar, no_MC_for_BO, use_Extend_Signals);
		}

		public Indicators.PriceActionIndicators.PASuppResDBDT PASuppResDBDT(ISeries<double> input , int swingStrength, int tick_Pos_Tolerance, int tick_Neg_Tolerance, bool aTR_Tolerance, double aTR_Divisor, int lookback, bool lookback_Prior_Day, bool useFirstBar, bool use_Extend_Signals, bool show_mDBDT)
		{
			return indicator.PASuppResDBDT(input, swingStrength, tick_Pos_Tolerance, tick_Neg_Tolerance, aTR_Tolerance, aTR_Divisor, lookback, lookback_Prior_Day, useFirstBar, use_Extend_Signals, show_mDBDT);
		}

	}
}

#endregion
