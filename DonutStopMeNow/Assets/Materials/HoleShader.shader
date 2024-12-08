Shader "HoleShader/Hole"
{
    //https://www.youtube.com/watch?v=p2-uQEG9-3Y

    Properties
    {
        //_MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        //LOD 100

        //Tags{"Queue" = "Geometry+1"}

       // ColorMask 0
        //ZWrite On

        Pass 
        {
         ZWrite Off
        }
    }
}