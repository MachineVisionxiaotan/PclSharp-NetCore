
// Code generated by a template
#pragma once
#include "..\export.h"

#include <pcl/pcl_base.h>
#include <pcl/point_types.h>
#include <pcl/surface/convex_hull.h>

using namespace pcl;
using namespace std;

typedef std::shared_ptr<PointCloud<PointXYZ>> boost_cloud;
typedef std::shared_ptr<pcl::search::Search<PointXYZ>> search_ptr;

#ifdef __cplusplus
extern "C" {
#endif 

EXPORT(ConvexHull<PointXYZ>*) surface_convexhull_xyz_ctor()
{
	return new ConvexHull<PointXYZ>();
}

EXPORT(void) surface_convexhull_xyz_delete(ConvexHull<PointXYZ>** ptr)
{
	delete *ptr;
	*ptr = NULL;
}

EXPORT(void) surface_convexhull_xyz_setInputCloud(ConvexHull<PointXYZ>* ptr, PointCloud<PointXYZ>* cloud)
{ ptr->setInputCloud(boost_cloud(boost_cloud(), cloud)); }

EXPORT(void) surface_convexhull_xyz_setIndices(ConvexHull<PointXYZ>* ptr, vector<int>* indices)
{ ptr->setIndices(std::shared_ptr<vector<int>>(std::shared_ptr<vector<int>>(), indices)); }

EXPORT(void) surface_convexhull_xyz_setSearchMethod(ConvexHull<PointXYZ>* ptr, pcl::search::Search<PointXYZ>* search)
{ ptr->setSearchMethod(search_ptr(search_ptr(), search)); }

EXPORT(void) surface_convexhull_xyz_reconstruct(ConvexHull<PointXYZ>* ptr, PolygonMesh* mesh)
{ ptr->reconstruct(*mesh); }

EXPORT(void) surface_convexhull_xyz_setComputeAreaVolume(ConvexHull<PointXYZ>* ptr, int value)
{ ptr->setComputeAreaVolume(value); }

EXPORT(double) surface_convexhull_xyz_getTotalArea(ConvexHull<PointXYZ>* ptr)
{ return ptr->getTotalArea(); }

EXPORT(double) surface_convexhull_xyz_getTotalVolume(ConvexHull<PointXYZ>* ptr)
{ return ptr->getTotalVolume(); }

EXPORT(void) surface_convexhull_xyz_getHullPointIndices(ConvexHull<PointXYZ>* ptr, PointIndices* hullIndices)
{ ptr->getHullPointIndices(*hullIndices); }

EXPORT(void) surface_convexhull_xyz_setDimension(ConvexHull<PointXYZ>* ptr, int value)
{ ptr->setDimension(value); }
EXPORT(int) surface_convexhull_xyz_getDimension(ConvexHull<PointXYZ>* ptr)
{ return ptr->getDimension(); }

#ifdef __cplusplus  
}
#endif  
