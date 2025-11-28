Shader "Shader Graphs/S_FlickeringStar" {
	Properties {
		_LowlightColor ("LowlightColor", Vector) = (0,0,0,0)
		_HighlightColor ("HighlightColor", Vector) = (0,0,0,0)
		_NoiseScale ("NoiseScale", Float) = 10
		_Frequency ("Frequency", Float) = 0
		_NoiseAmplitude ("NoiseAmplitude", Float) = 0
		_NoiseScale2 ("NoiseScale2", Float) = 0
		_Edge1 ("Edge1", Float) = 0
		_Edge2 ("Edge2", Float) = 0
		_RadialGradientPos ("RadialGradientPos", Vector) = (0,0,0,0)
		_Power ("Power", Float) = 0
		_Frequency2 ("Frequency2", Float) = 0
		_NoiseAmplitude2 ("NoiseAmplitude2", Float) = 0
		[HideInInspector] _BUILTIN_QueueOffset ("Float", Float) = 0
		[HideInInspector] _BUILTIN_QueueControl ("Float", Float) = -1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "UnityEditor.ShaderGraph.GenericShaderGraphMaterialGUI"
}