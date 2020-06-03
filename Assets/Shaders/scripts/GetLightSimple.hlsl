#ifndef CUSTOMHLSL_SIMPLE_LIGHTING
#define CUSTOMHLSL_SIMPLE_LIGHTING

void GetLightSimple_float( out float3 Direction, out float3 Color, out float Attenuation )
{
	#if SHADERGRAPH_PREVIEW
		Direction = float3(-0.5,0.5,-0.5);
		Color = float3(1,1,1);
		Attenuation = 0.4;
	#else
		Light light = GetMainLight();
		Direction = light.direction;
		Color = light.color;
		Attenuation = light.distanceAttenuation;
	#endif
}

#endif // CUSTOMHLSL_SIMPLE_LIGHTING
