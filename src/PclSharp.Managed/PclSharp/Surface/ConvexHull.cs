﻿








// Code generated by a template
namespace PclSharp.Surface
{
	public abstract class ConvexHull<PointT> : MeshConstruction<PointT>
	{
		public abstract bool ComputeAreaVolume { set; }
		public abstract double TotalArea { get; }
		public abstract double TotalVolume { get; }
		public abstract int Dimension { get; set; }

		public abstract void GetHullPointIndices(PointIndices indices);
	}
}
