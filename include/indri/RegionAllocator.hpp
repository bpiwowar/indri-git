/*==========================================================================
 * Copyright (c) 2005 University of Massachusetts.  All Rights Reserved.
 *
 * Use of the Lemur Toolkit for Language Modeling and Information Retrieval
 * is subject to the terms of the software license set forth in the LICENSE
 * file included with this software, and also available at
 * http://www.lemurproject.org/license.html
 *
 *==========================================================================
 */

//
// RegionAllocator
//
// 9 March 2005 -- tds
//

#ifndef INDRI_REGIONALLOCATOR_HPP
#define INDRI_REGIONALLOCATOR_HPP

#include "indri/delete_range.hpp"
#include "indri/Buffer.hpp"
#include <memory>
#include <iostream>

namespace indri
{
  namespace utility
  {
    
    class RegionAllocator {
    private:
      std::vector<Buffer*> _buffers;
      std::vector<void*> _malloced;
      size_t _mallocBytes;

    public:
      RegionAllocator() :
        _mallocBytes(0)
      {
      }

      ~RegionAllocator() {
        delete_vector_contents( _buffers );

        for( size_t i=0; i<_malloced.size(); i++ )
          free( _malloced[i] );
      }

      void* allocate( size_t bytes, size_t align ) {
        if( bytes > 1024*32 ) {
          _mallocBytes += bytes;
          _malloced.push_back( malloc( bytes ) );
          return _malloced.back();
        }
    
        if (_buffers.size()) {    
          size_t _bpos = (size_t)(_buffers.back()->front() + _buffers.back()->position());
          size_t padding = _bpos % align;
          size_t padded_bytes = padding + bytes;

          if(_buffers.back()->remaining() >= padded_bytes ) {
            return _buffers.back()->write( padded_bytes ) + padding;
          }

        }
        _buffers.push_back( new Buffer( 1024*1024 ) );
        return allocate( bytes , align );
      }

      size_t allocatedBytes() {
        return _buffers.size() * 1024*1024 + _mallocBytes;
      }
    };
  }
}

#endif // INDRI_REGIONALLOCATOR_HPP

