using OpenTK.Graphics.OpenGL4;

namespace BlockRenderer.Core {

    //BR stands for Block render 
    public static class BR {
        public enum BufferUsage {
            StaticDraw = BufferUsageHint.StaticDraw,
            DynamicDraw = BufferUsageHint.DynamicDraw,
            StreamDraw = BufferUsageHint.StreamDraw
        }

        public enum AttribType {
            UnsignedByte = VertexAttribPointerType.UnsignedByte,
            Byte = VertexAttribPointerType.Byte,
            UnsignedShort = VertexAttribPointerType.UnsignedShort,
            Short = VertexAttribPointerType.Short,
            UnsignedInteger = VertexAttribPointerType.UnsignedInt,
            Integer = VertexAttribPointerType.Int,
            HalfFloat = VertexAttribPointerType.HalfFloat,
            Float = VertexAttribPointerType.Float,
            Double = VertexAttribPointerType.Double
        }

    }
}