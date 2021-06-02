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
using NinjaTrader.NinjaScript.Indicators;
using NinjaTrader.NinjaScript.DrawingTools;
#endregion

//This namespace holds Strategies in this folder and is required. Do not change it. 
namespace NinjaTrader.NinjaScript.Strategies
{
	public class ATRBreakout : Strategy
	{
		private	double high;
		
		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description	= @"ATR Breakout from TASC June 2016.";
				Name		= "ATRBreakout";
				Calculate	= Calculate.OnBarClose;
				EntriesPerDirection	= 1;
				EntryHandling		= EntryHandling.AllEntries;
				IsExitOnSessionCloseStrategy	= true;
				ExitOnSessionCloseSeconds	= 30;
				IsFillLimitOnTouch		= false;
				MaximumBarsLookBack		= MaximumBarsLookBack.TwoHundredFiftySix;
				OrderFillResolution		= OrderFillResolution.Standard;
				Slippage			= 0;
				StartBehavior			= StartBehavior.WaitUntilFlat;
				TimeInForce			= TimeInForce.Gtc;
				TraceOrders			= false;
				RealtimeErrorHandling		= RealtimeErrorHandling.StopCancelClose;
				StopTargetHandling		= StopTargetHandling.PerEntryExecution;
				BarsRequiredToTrade		= 20;
				// Disable this property for performance gains in Strategy Analyzer optimizations
				// See the Help Guide for additional information
				IsInstantiatedOnEachOptimizationIteration	= true;				
				PriceRangeHi			= 70;
				PriceRangeLo			= 15;
				PriceRangeMin			= 5;
				AtrPeriod			= 14;
				MaPeriod			= 100;
				WideRange			= 1.5;
				TrailStop			= 2;
				VolumeRangeMin			= 1000000;
				
			}
			else if (State == State.Configure)
			{
				SetTrailStop(CalculationMode.Ticks, TrailStop);	
			}
			else if (State == State.DataLoaded)
			{
				AddChartIndicator(SMA(MaPeriod));
				AddChartIndicator(ATR(AtrPeriod));
				AddChartIndicator(VOL());
				
				high										= 0;
			}
		}

		protected override void OnBarUpdate()
		{
			if (Close[0] < PriceRangeHi														// Price is less than PriceRangeHi
				&& Close[0] > PriceRangeLo													// Price is greater than PriceRangeLo
				&& Math.Abs(High[0] - Low[0]) >= PriceRangeMin	// Difference of High and Low is greater than PriceRangeMin
				&& Volume[0] >= VolumeRangeMin			// Volume is greater than the minimum range
				&& ATR(AtrPeriod)[0] >= MAX(ATR(AtrPeriod), AtrPeriod)[0] // Current ATR value is the highest from its lookback period
				&& CrossAbove(Close, SMA(MaPeriod), 1)	// Current price crosses over Moving Average
				&& Math.Abs(High[0] - Low[0]) >= Math.Abs(High[1] - Low[1]) * WideRange // Current High/Low range is greater or equal to Previous High/Low range time the factor WideRange
				&& Volume[0] > Volume[1])  // Current Volume is greater than previous volume
			{
				high = High[0];																	// Use this High price
			}
			
			if (high != 0 && Close[0] >= high + .5)	// Current price is greater that our breakout level
			{
				if (High[0] > Close[0])		// Downward pivot in bar
					EnterLongStopMarket(High[0]);
				else
					EnterLong();
			}
		}

		#region Properties
		[NinjaScriptProperty]
		[Range(0, double.MaxValue)]
		[Display(ResourceType = typeof(Custom.Resource), Name="PriceRangeHi", Description="Highest level for price action", Order=1, GroupName="NinjaScriptStrategyParameters")]
		public double PriceRangeHi
		{ get; set; }

		[NinjaScriptProperty]
		[Range(0, double.MaxValue)]
		[Display(ResourceType = typeof(Custom.Resource), Name="PriceRangeLo", Description="Lowest level for price action", Order=2, GroupName="NinjaScriptStrategyParameters")]
		public double PriceRangeLo
		{ get; set; }

		[NinjaScriptProperty]
		[Range(0, double.MaxValue)]
		[Display(ResourceType = typeof(Custom.Resource), Name="PriceRangeMin", Description="Minimum movement of current bar in point value", Order=3, GroupName="NinjaScriptStrategyParameters")]
		public double PriceRangeMin
		{ get; set; }

		[NinjaScriptProperty]
		[Range(1, int.MaxValue)]
		[Display(ResourceType = typeof(Custom.Resource), Name="AtrPeriod", Description="ATR Period", Order=4, GroupName="NinjaScriptStrategyParameters")]
		public int AtrPeriod
		{ get; set; }

		[NinjaScriptProperty]
		[Range(1, int.MaxValue)]
		[Display(ResourceType = typeof(Custom.Resource), Name="MaPeriod", Description="MA Period", Order=5, GroupName="NinjaScriptStrategyParameters")]
		public int MaPeriod
		{ get; set; }

		[NinjaScriptProperty]
		[Range(0, double.MaxValue)]
		[Display(ResourceType = typeof(Custom.Resource), Name="WideRange", Description="Range of current bar against previous bar", Order=6, GroupName="NinjaScriptStrategyParameters")]
		public double WideRange
		{ get; set; }
		
		[NinjaScriptProperty]
		[Range(0, double.MaxValue)]
		[Display(ResourceType = typeof(Custom.Resource), Name="VolumeRangeMin", Description="Volume Range", Order=7, GroupName="NinjaScriptStrategyParameters")]
		public double VolumeRangeMin
		{ get; set; }

		[NinjaScriptProperty]
		[Range(1, int.MaxValue)]
		[Display(ResourceType = typeof(Custom.Resource), Name="TrailStop", Description="Trailing Stop value in tick value", Order=8, GroupName="NinjaScriptStrategyParameters")]
		public int TrailStop
		{ get; set; }
		#endregion

	}
}
