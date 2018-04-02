﻿using LiveCharts.Core.Abstractions;
using LiveCharts.Core.Abstractions.DataSeries;
using LiveCharts.Core.Coordinates;
using LiveCharts.Core.DataSeries.Data;
using LiveCharts.Core.ViewModels;
using LiveCharts.Wpf.Controls;

namespace LiveCharts.Wpf.Views.Providers
{
    /// <summary>
    /// The bezier view provider class.
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    /// <seealso cref="ISeriesViewProvider{TModel,TCoordinate,TViewModel}" />
    public class BezierSeriesViewProvider<TModel> : ISeriesViewProvider<TModel, Point, BezierViewModel>
    {
        public void OnUpdateStarted(IChartView chart, ISeries series)
        {
        }

        public IPointView<TModel, Point<TModel, Point, BezierViewModel>, Point, BezierViewModel> Getter()
        {
            return new BezierPointView<TModel, Point<TModel, Point, BezierViewModel>, DataLabel>();
        }

        public void OnUpdateFinished(IChartView chart, ISeries series)
        {
        }
    }
}