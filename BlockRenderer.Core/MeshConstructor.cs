using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlockRenderer.Core.BR;

namespace BlockRenderer.Core {
    public class MeshConstructor {
        private class VertexInfo {
            internal byte[] Data;
            internal int ShaderIndex;
            internal int Size;
            internal BR.AttribType attribType;
            internal BR.BufferUsage bufferUsage;

            public VertexInfo(byte[] Data, int ShaderIndex, int Size,
                BR.AttribType attribType, BR.BufferUsage bufferUsage) {
                this.Data = Data;
                this.ShaderIndex = ShaderIndex;
                this.Size = Size;
                this.attribType = attribType;
                this.bufferUsage = bufferUsage;
            }
        }
        List<VertexInfo> VertexInfos = new List<VertexInfo>();

        public void AddVertices(byte[] Data, int ShaderIndex, int Size, 
            BR.AttribType attribType, BR.BufferUsage bufferUsage = BR.BufferUsage.StaticDraw) {
            VertexInfos.Add(new VertexInfo(Data, ShaderIndex, Size, attribType, bufferUsage));
        }


    }
}
