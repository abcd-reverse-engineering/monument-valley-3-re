Shader "Castle/DepthMaskWobble" {
	Properties {
		_WobbleMagnitude ("Wobble Magnitude", Float) = 0.2
		_WobbleFrequency ("Wobble Frequency (1/s)", Float) = 1
		_WobbleSpace ("Wobble Space", Float) = 0
		_WobbleInvWavelength ("Wobble Inverse Wavelength (1/m)", Float) = 10
		_WobbleVectorDirection ("Wobble Vector Direction", Vector) = (0,0,0,0)
		_WobbleVectorOrthogonal ("Wobble Vector Orthoganol", Vector) = (0,0,0,0)
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
}