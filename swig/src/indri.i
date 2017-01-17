%module (directors="1") indri

%feature("autodoc", "3");

%{
#include <indri/CompressedCollection.hpp>
#include <indri/Repository.hpp>
#include <indri/LocalQueryServer.hpp>
%}

// Handles strings
%include "std_string.i"
// Handles standard types e.g. uint8_t
%include "stdint.i"

%include <lemur/lemur-platform.h>
%include <indri/CompressedCollection.hpp>
%include <indri/Repository.hpp>
%include <indri/QueryServer.hpp>
%include <indri/LocalQueryServer.hpp>
