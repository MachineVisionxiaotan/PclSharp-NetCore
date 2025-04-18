
// Code generated by a template
#pragma once
#include "..\export.h"
#include <pcl/PolygonMesh.h>

using namespace pcl;
using namespace std;

#ifdef __cplusplus
extern "C" {
#endif

EXPORT(PolygonMesh*) polygonmesh_ctor()
{
	return new PolygonMesh();
}

EXPORT(void) polygonmesh_delete(PolygonMesh** ptr)
{
	delete *ptr;
	*ptr = NULL;
}

EXPORT(PCLHeader*) polygonmesh_getHeader(PolygonMesh* ptr)
{ return &ptr->header; }
EXPORT(void) polygonmesh_setHeader(PolygonMesh* ptr, PCLHeader* value)
{ ptr->header = *value; }

EXPORT(PCLPointCloud2*) polygonmesh_getCloud(PolygonMesh* ptr)
{ return &ptr->cloud; }
EXPORT(void) polygonmesh_setCloud(PolygonMesh* ptr, PCLPointCloud2* value)
{ ptr->cloud = *value; }

EXPORT(std::vector<pcl::Vertices>*) polygonmesh_getPolygons(PolygonMesh* ptr)
{ return &ptr->polygons; }
EXPORT(void) polygonmesh_setPolygons(PolygonMesh* ptr, std::vector<pcl::Vertices>* value)
{ ptr->polygons = *value; }

#ifdef __cplusplus  
}
#endif
