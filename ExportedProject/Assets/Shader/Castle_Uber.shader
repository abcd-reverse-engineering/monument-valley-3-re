Shader "Castle/Uber" {
	Properties {
		[HDR] _XColor ("X1 Color", Vector) = (1,0,0,1)
		[HDR] _X2Color ("X2 Color", Vector) = (1,0,0,1)
		_XGradStart ("X Start", Vector) = (0,0,-3,1)
		_XGradEnd ("X End", Vector) = (0,0,3,1)
		[HDR] _YColor ("Y1 Color", Vector) = (0,1,0,1)
		[HDR] _Y2Color ("Y2 Color", Vector) = (0,1,0,1)
		_YGradStart ("Y Start", Vector) = (0,0,-3,1)
		_YGradEnd ("Y End", Vector) = (0,0,3,1)
		[HDR] _ZColor ("Z1 Color", Vector) = (0,0,1,1)
		[HDR] _Z2Color ("Z2 Color", Vector) = (0,0,1,1)
		_ZGradStart ("Z Start", Vector) = (-3,0,0,1)
		_ZGradEnd ("Z End", Vector) = (3,0,0,1)
		_IlluminationMode ("Illumination Mode", Float) = 0
		_SrcMode ("Source Blend Mode", Float) = 1
		_DstMode ("Destination Blend Mode", Float) = 0
		_ZWrite ("Z-Buffer Writting", Float) = 1
		_ZTest ("Z-Buffer Test Mode", Float) = 4
		_CullMode ("Culling Mode", Float) = 2
		_MaxAlpha ("Max Alpha", Float) = 1
		_AdditiveColor ("Additive Color", Vector) = (0,0,0,1)
		_TintColor ("Tint Color", Vector) = (0,0,0,1)
		_HueShift ("Hue Shift", Range(0, 1)) = 0
		_SaturationShift ("Hue Shift", Range(-1, 1)) = 0
		_ValueShift ("Value Shift", Range(-1, 1)) = 0
		_BlackLevel ("Black Level", Range(0, 1)) = 0
		_WhiteLevel ("White Level", Range(0, 1)) = 1
		_MidtoneLevel ("Midtone Level", Range(0, 1)) = 0.5
		_CamDirection ("Camera Dir", Vector) = (0.5773506,-0.5773506,0.5773506,1)
		_MainTex ("Texture", 2D) = "white" {}
		_MainTexBlend ("Texture Blend Mode", Float) = 1
		_MainTexLerpTex ("Texture Lerp", 2D) = "white" {}
		_MainTexLerpValue ("Texture Lerp Value", Float) = 0
		_MainTexTint ("Texture Tint", Vector) = (1,1,1,1)
		_NormalMap ("Normal Map", 2D) = "bump" {}
		_NormalStrength ("Normal Strength", Range(0, 1)) = 1
		_CubeMap ("CubeMap", Cube) = "white" {}
		_CubeMapRotation ("Cube map rotation", Vector) = (0,0,0,1)
		_CubeMapViewDirection ("Cube map view direction", Vector) = (0,0,1,1)
		_Roughness ("Roughness", Range(0, 1)) = 1
		_RoughnessTexture ("Roughness Texture", 2D) = "white" {}
		_CubeMapExposure ("CubeMap Exposure", Float) = 1
		_CubeMapZoom ("CubeMapZoom", Range(0, 1)) = 0.5
		_FresnelStrength ("Fresnel Strength", Range(0, 1)) = 1
		_F0 ("F0", Float) = 0
		_CameraSpaceTex ("Camera Space Texture", 2D) = "white" {}
		_CameraSpaceTexStart ("Start", Vector) = (-10,-10,0,1)
		_CameraSpaceTexEnd ("End", Vector) = (10,10,0,1)
		_CameraSpaceTexAngle ("Angle", Float) = 0
		_CameraSpaceTexBlend ("Camera-Space Texture Blend Mode", Float) = 1
		_CameraSpaceTexWrap ("Camera-Space Texture Wrap Mode", Float) = 1
		_VertexColor ("Vertex Color", Vector) = (1,0,1,1)
		_VertexColorBlend ("Vertex Color Blend Mode", Float) = 2
		_RimColor ("Rim Color", Vector) = (0,0,0,1)
		_PointLightsMode ("Point Lights Mode", Float) = 0
		_PointLightsLift ("Point Lights Lift", Range(2, 10)) = 4
		_PointLightsReferenceDirection ("Point Lights Reference Direction", Vector) = (-0.44,0.86,-0.26,1)
		_LightLayer ("Light Layer", Int) = NaN
		_AOColor ("AO Color", Vector) = (0,0,0,1)
		_AOColorBlend ("AO Color Blend", Float) = 2
		_AODepthOffset ("AO Depth Offset", Float) = 0
		_YFogMin ("Y-Fog Min", Float) = 0
		_YFogMax ("Y-Fog Max", Float) = -10
		_YFogColor ("Y-Fog Color", Vector) = (0,1,0,1)
		_GlowInteractive ("Glow Interactive", Float) = 0
		_GlowAmount ("Glow Amount", Range(0, 1)) = 0
		_GlowColor ("Glow Color", Vector) = (0.5,0.5,0.5,0)
		_GlowMask ("Glow Mask", 2D) = "white" {}
		_GlowMaskLerp ("Glow Mask Lerp", 2D) = "white" {}
		_GlowMaskLerpValue ("Glow Mask Lerp Value", Float) = 0
		_Plane0 ("Clip Plane 0", Vector) = (0,1,0,1)
		_Plane1 ("Clip Plane 1", Vector) = (0,1,0,1)
		_MultiClipPlane0 ("Multi Clip Plane 0", Vector) = (0,1,0,-1000)
		_MultiClipPlane1 ("Multi Clip Plane 1", Vector) = (0,1,0,-1000)
		_MultiClipPlane2 ("Multi Clip Plane 2", Vector) = (0,1,0,-1000)
		_MultiClipPlane3 ("Multi Clip Plane 3", Vector) = (0,1,0,-1000)
		_MultiClipPlane4 ("Multi Clip Plane 4", Vector) = (0,1,0,-1000)
		_MultiClipPlane5 ("Multi Clip Plane 5", Vector) = (0,1,0,-1000)
		_WindTexture ("Wind Texture", 2D) = "white" {}
		_WobbleMagnitude ("Wobble Magnitude", Float) = 0.2
		_WobbleFrequency ("Wobble Frequency (1/s)", Float) = 1
		_WobbleSpace ("Wobble Space", Float) = 0
		_WobbleInvWavelength ("Wobble Inverse Wavelength (1/m)", Float) = 10
		_WobbleVectorDirection ("Wobble Vector Direction", Vector) = (0,0,0,0)
		_WobbleVectorOrthogonal ("Wobble Vector Orthoganol", Vector) = (0,0,0,0)
		_FollowWaterMagnitude ("Follow Water Magnitude", Float) = 1
		_UVScrollSpeed ("UV Scroll Speed", Float) = 1
		_UVScrollDirection ("UV Scroll Direction", Vector) = (0,1,0,1)
		_UVScrollMode ("UV Scroll Mode", Float) = 0
		_UVPingPongRange ("UV Ping Pong Range", Float) = 1
		_AltXColor ("Alt X Color", Vector) = (1,0,0,1)
		_AltYColor ("Alt Y Color", Vector) = (0,1,0,1)
		_AltZColor ("Alt Z Color", Vector) = (0,0,1,1)
		_AltColorMask ("Alt Color Mask", 2D) = "white" {}
		_NoiseTex ("Noise Texture", 2D) = "white" {}
		_NoiseIntensity ("Noise Intensity", Float) = 0
		_OffsetPosition ("Offset Position", Vector) = (0,0,0,0)
		_OffsetScale ("Offset Scale", Float) = 1
		_EditorTab ("Editor Tab", Float) = 0
		_UVRemap ("UV Remap", Vector) = (0,1,0,1)
		_MultiStableLerp ("Multi Stable Lerp", Float) = 0
		[IntRange] _StencilRef ("Stencil Reference Value", Range(0, 255)) = 0
		[Enum(UnityEngine.Rendering.CompareFunction)] _StencilComp ("StencilComp", Float) = 8
		[Enum(UnityEngine.Rendering.StencilOp)] _StencilOp ("Stencil Op", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy);
			}

			ENDHLSL
		}
	}
	//CustomEditor "MVUberGUI"
}