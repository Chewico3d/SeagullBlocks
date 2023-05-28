using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockRenderer.Core {
    public class Mesh {
        private ArrayBufferObject[] arrayBuffers;
        public Mesh(ArrayBufferObject[] arrayBuffers) {
            this.arrayBuffers = arrayBuffers;

        }
    }
}
