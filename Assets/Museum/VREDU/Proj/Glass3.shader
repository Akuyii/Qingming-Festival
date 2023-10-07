Shader "IES/Glass3" {
	Properties {
		_Color ("Main Color", Color) = (1, 1, 1, 1)
		_Cube ("Reflection Cubemap", Cube) = "_Skybox" {TexGen CubeReflect}
	}
	
	SubShader {
		Tags {"Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType" = "Transparent"}
		//Blend SrcAlpha OneMinusSrcAlpha
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Lambert alpha
		
		samplerCUBE _Cube;
		fixed4 _Color;
		
		struct Input 
		{
			half2 uv_MainTex;
			half3 worldRefl;
		};
		
		void surf(Input IN, inout SurfaceOutput o) 
		{
			o.Albedo = _Color.rgb;
			fixed4 reflcol = texCUBE(_Cube, IN.worldRefl);
			o.Emission = reflcol.rgb;
			o.Alpha = _Color.a;
		}
		
		ENDCG
	}
	
	Fallback "Transparent/VertexLit"
} 
