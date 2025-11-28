Shader "Shader Graphs/S_Jet" {
	Properties {
		_Phase ("Phase", Float) = 0
		_Frequency ("Frequency", Float) = 0
		_Amplitude ("Amplitude", Float) = 0
		_Color1 ("Color1", Vector) = (0,0,0,0)
		_Color2 ("Color2", Vector) = (0,0,0,0)
		_ColorFrequency ("ColorFrequency", Float) = 0
		_ColorXTiling ("ColorXTiling", Float) = 0
		_UScale ("UScale", Float) = 0
		_FresnelPower ("FresnelPower", Float) = 0
		_DarkenFresnelPower ("DarkenFresnelPower", Float) = 0
		_DarkenFresnelColor ("DarkenFresnelColor", Vector) = (0,0,0,0)
		_LightenFresnelColor ("LightenFresnelColor", Vector) = (0,0,0,0)
		_ScrollSpeed ("ScrollSpeed", Float) = 0
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