/*
	Copyright © Carl Emil Carlsen 2018-2025
	http://cec.dk
*/

using UnityEngine;

public class GizmoresExample : MonoBehaviour
{
	[SerializeField,Range(0f,1f)] float _radius = 0.5f;
	[SerializeField,Range(0f,2f)] float _length = 1.0f;
	[SerializeField,Range(0f,2f)] float _height = 1.0f;
	[SerializeField] float _angle = 110;
	[SerializeField] float _angleBegin = 0;
	[SerializeField] float _angleEnd = 110;
	[SerializeField] Camera _camera;

	public float coneAngle = 90;
 

	void OnDrawGizmos()
	{
		Vector3 pos = Vector3.zero;

		Gizmores.DrawLabel( pos, "DrawWireRect" );
		Next( ref pos );
		Gizmores.DrawWireRect( new Rect( pos.x, pos.y, 1f, 1f ) );
		Next( ref pos );

		pos.x = 0; pos.z += 2;
		Gizmores.DrawLabel( pos, "DrawWireQuad" );
		Next( ref pos );
		Gizmores.DrawWireQuad( pos, Vector2.one, Gizmores.Plane.ZY );
		Next( ref pos );
		Gizmores.DrawWireQuad( pos, Vector2.one, Gizmores.Plane.XZ );
		Next( ref pos );
		Gizmores.DrawWireQuad( pos, Vector2.one, Gizmores.Plane.XY );
		Next( ref pos );

		pos.x = 0; pos.z += 2;
		Gizmores.DrawLabel( pos, "DrawWireCircle" );
		Next( ref pos );
		Gizmores.DrawWireCircle( pos, _radius, Gizmores.Axis.X );
		Next( ref pos );
		Gizmores.DrawWireCircle( pos, _radius, Gizmores.Axis.Y );
		Next( ref pos );
		Gizmores.DrawWireCircle( pos, _radius, Gizmores.Axis.Z );
		Next( ref pos );

		pos.x = 0; pos.z += 2;
		Gizmores.DrawLabel( pos, "DrawWireArc" );
		Next( ref pos );
		Gizmores.DrawWireArc( pos, _radius, _angleBegin, _angleEnd, Gizmores.Axis.X );
		Next( ref pos );
		Gizmores.DrawWireArc( pos, _radius, _angleBegin, _angleEnd, Gizmores.Axis.Y );
		Next( ref pos );
		Gizmores.DrawWireArc( pos, _radius, _angleBegin, _angleEnd, Gizmores.Axis.Z );
		Next( ref pos );

		pos.x = 0; pos.z += 2;
		Gizmores.DrawLabel( pos, "DrawWireDome" );
		Next( ref pos );
		Gizmores.DrawWireDome( pos, _radius, Gizmores.Axis.X );
		Next( ref pos );
		Gizmores.DrawWireDome( pos, _radius, Gizmores.Axis.Y );
		Next( ref pos );
		Gizmores.DrawWireDome( pos, _radius, Gizmores.Axis.Z );
		Next( ref pos );
		Gizmores.DrawWireDome( pos, _radius, Gizmores.Axis.X, flip: true );
		Next( ref pos );
		Gizmores.DrawWireDome( pos, _radius, Gizmores.Axis.Y, flip: true );
		Next( ref pos );
		Gizmores.DrawWireDome( pos, _radius, Gizmores.Axis.Z, flip: true );
		Next( ref pos );

		pos.x = 0; pos.z += 2;
		Gizmores.DrawLabel( pos, "DrawWireCyllinder" );
		Next( ref pos );
		Gizmores.DrawWireCyllinder( pos, _length, _radius, Gizmores.Axis.X );
		Next( ref pos );
		Gizmores.DrawWireCyllinder( pos, _length, _radius, Gizmores.Axis.Y );
		Next( ref pos );
		Gizmores.DrawWireCyllinder( pos, _length, _radius, Gizmores.Axis.Z );
		Next( ref pos );

		pos.x = 0; pos.z += 2;
		Gizmores.DrawLabel( pos, "DrawWireCapsule" );
		Next( ref pos );
		Gizmores.DrawWireCapsule( pos, _length, _radius, Gizmores.Axis.X );
		Next( ref pos );
		Gizmores.DrawWireCapsule( pos, _length, _radius, Gizmores.Axis.Y );
		Next( ref pos );
		Gizmores.DrawWireCapsule( pos, _length, _radius, Gizmores.Axis.Z );
		Next( ref pos );

		pos.x = 0; pos.z += 2;
		Gizmores.DrawLabel( pos, "DrawWireCone" );
		Next( ref pos );
		Gizmores.DrawWireCone( pos, _height, coneAngle, Gizmores.Axis.X );
		Next( ref pos );
		Gizmores.DrawWireCone( pos, _height, coneAngle, Gizmores.Axis.Y );
		Next( ref pos );
		Gizmores.DrawWireCone( pos, _height, coneAngle, Gizmores.Axis.Z );
		Next( ref pos );
		Gizmores.DrawWireCone( pos, _height, coneAngle, Gizmores.Axis.X, flip: true );
		Next( ref pos );
		Gizmores.DrawWireCone( pos, _height, coneAngle, Gizmores.Axis.Y, flip: true );
		Next( ref pos );
		Gizmores.DrawWireCone( pos, _height, coneAngle, Gizmores.Axis.Z, flip: true );
		Next( ref pos );

		pos.x = 0; pos.z += 2;
		Gizmores.DrawLabel( pos, "DrawWireSphericalCone" );
		Next( ref pos );
		Gizmores.DrawWireSphericalCone( pos, _radius, coneAngle, Gizmores.Axis.X );
		Next( ref pos );
		Gizmores.DrawWireSphericalCone( pos, _radius, coneAngle, Gizmores.Axis.Y );
		Next( ref pos );
		Gizmores.DrawWireSphericalCone( pos, _radius, coneAngle, Gizmores.Axis.Z );
		Next( ref pos );
		Gizmores.DrawWireSphericalCone( pos, _radius, coneAngle, Gizmores.Axis.X, flip: true );
		Next( ref pos );
		Gizmores.DrawWireSphericalCone( pos, _radius, coneAngle, Gizmores.Axis.Y, flip: true );
		Next( ref pos );
		Gizmores.DrawWireSphericalCone( pos, _radius, coneAngle, Gizmores.Axis.Z, flip: true );
		Next( ref pos );

		pos.x = 0; pos.z += 2;
		Gizmores.DrawLabel( pos, "DrawWireSphericalSegment" );
		Next( ref pos );
		Gizmores.DrawWireSphericalSegment( pos, _radius, _angle, Gizmores.Axis.X );
		Next( ref pos );
		Gizmores.DrawWireSphericalSegment( pos, _radius, _angle, Gizmores.Axis.Y );
		Next( ref pos );
		Gizmores.DrawWireSphericalSegment( pos, _radius, _angle, Gizmores.Axis.Z );
		Next( ref pos );
		Gizmores.DrawWireSphericalSegment( pos, _radius, _angle, Gizmores.Axis.X, flip: true );
		Next( ref pos );
		Gizmores.DrawWireSphericalSegment( pos, _radius, _angle, Gizmores.Axis.Y, flip: true );
		Next( ref pos );
		Gizmores.DrawWireSphericalSegment( pos, _radius, _angle, Gizmores.Axis.Z, flip: true );
		Next( ref pos );

		pos.x = 0; pos.z += 2;
		Gizmores.DrawLabel( pos, "DrawWireBone" );
		Next( ref pos );
		Gizmores.DrawWireBone( pos, _radius, _length, Gizmores.Axis.X );
		Next( ref pos );
		Gizmores.DrawWireBone( pos, _radius, _length, Gizmores.Axis.Y );
		Next( ref pos );
		Gizmores.DrawWireBone( pos, _radius, _length, Gizmores.Axis.Z );
		Next( ref pos );
		Gizmores.DrawWireBone( pos, _radius, _length, Gizmores.Axis.X, flip: true );
		Next( ref pos );
		Gizmores.DrawWireBone( pos, _radius, _length, Gizmores.Axis.Y, flip: true );
		Next( ref pos );
		Gizmores.DrawWireBone( pos, _radius, _length, Gizmores.Axis.Z, flip: true );
		Next( ref pos );

		pos.x = 0; pos.z += 2;
		Gizmores.DrawLabel( pos, "DrawLabel" );
		Next( ref pos );
		Gizmores.DrawLabel( pos, "A" );
		Next( ref pos );
		Gizmores.DrawLabel( pos, "B" );
		Next( ref pos );
		Gizmores.DrawLabel( pos, "C" );
		Next( ref pos );

		pos.x = 0; pos.z += 2;
		Gizmores.DrawLabel( pos, "DrawWireCross" );
		Next( ref pos );
		Gizmores.DrawWireCross( pos, 1 );
		Next( ref pos );

		pos.x = 0; pos.z += 2;
		Gizmores.DrawLabel( pos, "DrawWireAxis" );
		Next( ref pos );
		Gizmores.DrawWireAxis( pos, 0.5f );
		Next( ref pos );

		if( _camera ) Gizmores.DrawFrustum( _camera ); // You can also pass a projection matrix instead.
	}


	static void Next( ref Vector3 position )
	{
		Gizmos.color = Color.red;
		Gizmos.DrawSphere( position, 0.04f );
		Gizmos.color = Color.white;

		position.x += 2;
	}
}
