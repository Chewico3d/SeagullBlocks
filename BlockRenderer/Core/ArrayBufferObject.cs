using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL4;

namespace BlockRenderer.Core {
    public class ArrayBufferObject {
        int ID;
        public ArrayBufferObject(byte[] data, BR.BufferUsage BufferUsage = BR.BufferUsage.StaticDraw) {
            ID = GL.GenBuffer();
            
            GL.BufferData(BufferTarget.ArrayBuffer, data.Length, data, (BufferUsageHint)BufferUsage);
        }

        public void Bind() => GL.BindBuffer(BufferTarget.ArrayBuffer, ID);

        public void Delete() {
            if (ID == -1)
                return;
            GL.DeleteBuffer(ID);
            ID = -1;
        }
        ~ArrayBufferObject() => Delete();   
    }
}
