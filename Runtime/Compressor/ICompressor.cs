﻿////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Martin Bustos @FronkonGames <fronkongames@gmail.com>
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of
// the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Threading.Tasks;

namespace FronkonGames.GameWork.Modules.LocalData
{
  /// <summary>
  /// Compression interface.
  /// </summary>
  public interface ICompressor
  {
    /// <summary>
    /// Compresses a stream.
    /// </summary>
    /// <param name="stream">Memory stream.</param>
    /// <param name="progress">Progress of the compression, from 0 to 1.</param>
    /// <returns>Compressed stream.</returns>
    public Task<MemoryStream> Compress(MemoryStream stream, Action<float> progress);

    /// <summary>
    /// Descompresses a stream.
    /// </summary>
    /// <param name="stream">Compressed memory stream.</param>
    /// <param name="originalSize">Size of the uncompressed stream.</param>
    /// <param name="progress">Progress of the decompression, from 0 to 1.</param>
    /// <returns>Decompressed stream.</returns>
    public Task<MemoryStream> Decompress(MemoryStream stream, int originalSize, Action<float> progress);
  }  
}