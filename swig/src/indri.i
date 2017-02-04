%module (directors="1") indri

%feature("autodoc", "3");

%{
#include <indri/CompressedCollection.hpp>
#include <indri/TagEvent.hpp>
#include <indri/Repository.hpp>
#include <indri/LocalQueryServer.hpp>
#include <indri/TokenizerFactory.hpp>
#include <indri/Index.hpp>
%}

// Handles strings
%include "std_string.i"
// Handles standard types e.g. uint8_t
%include "stdint.i"
// Handles exceptions
%include "exception.i"
// Handle attributes for languages supporting this (Python)
%include "attribute.i"

%exception {
   try {
      $action
   } catch (Swig::DirectorException &e) {
      SWIG_exception(SWIG_RuntimeError, e.what());
   } catch(lemur::api::Exception &e) {
       SWIG_exception(SWIG_RuntimeError, e.what().c_str());
   } catch(std::exception &e) {
      SWIG_exception(SWIG_RuntimeError, e.what());
   }
}

%feature("director:except") {
    if ($error != NULL) {
        throw Swig::DirectorMethodException();
    }
}


%immutable indri::parse::UnparsedDocument::text;
%immutable indri::parse::UnparsedDocument::textLength;
%immutable indri::parse::UnparsedDocument::content;
%immutable indri::parse::UnparsedDocument::contentLength;


%newobject indri::parse::TokenizerFactory::get;

%include <lemur/lemur-platform.h>
%include <lemur/IndexTypes.hpp>

%include "greedy_vector.i"


%include <indri/AttributeValuePair.hpp>
%include <indri/TagEvent.hpp>
%include <indri/ObjectHandler.hpp>

%include <indri/CompressedCollection.hpp>
%include <indri/Repository.hpp>
%include <indri/QueryServer.hpp>
%include <indri/LocalQueryServer.hpp>

%include <indri/MetadataPair.hpp>
%include <indri/TermExtent.hpp>

%include <indri/UnparsedDocument.hpp>

%include <indri/TokenizedDocument.hpp>
%include <indri/IndriTokenizer.hpp>
%include <indri/TokenizerFactory.hpp>

%include <indri/TermFieldStatistics.hpp>
%include <indri/TermData.hpp>
%include <indri/DiskTermData.hpp>
%include <indri/DocumentData.hpp>
%include <indri/DocListIterator.hpp>
%include <indri/DocListFileIterator.hpp>
%include <indri/DocExtentListIterator.hpp>
%include <indri/VocabularyIterator.hpp>
%include <indri/DocumentDataIterator.hpp>
%include <indri/TermList.hpp>
%include <indri/TermListFileIterator.hpp>
%include <indri/Index.hpp>


%extend indri::parse::UnparsedDocument {
    UnparsedDocument() {
        indri::parse::UnparsedDocument *d;
        d = (indri::parse::UnparsedDocument *)malloc(sizeof(indri::parse::UnparsedDocument));
        d->text = nullptr;
        d->textLength = 0;
        d->content = nullptr;
        d->contentLength = 0;
        return d;
    }
    ~UnparsedDocument() {
        delete($self->text);
        delete($self->content);
        delete($self);
    }

    void setText(std::string const &s) {
        delete $self->text;
        size_t len = s.length();
        self->text = (char*)malloc(sizeof(std::string::value_type) * (len + 1));
        strncpy((char*)self->text, s.c_str(), len);
        $self->textLength = s.length();
    }
    void setContent(std::string const &s) {
        delete $self->content;
        size_t len = s.length();
        self->content = (char*)malloc(sizeof(std::string::value_type) * (len + 1));
        strncpy((char*)self->content, s.c_str(), len);
        $self->contentLength = s.length();
    }
}


%ignore indri::collection::Repository::indexes();
%extend indri::collection::Repository {
    size_t indexCount() {
        return $self->indexes()->size();
    }
    indri::index::Index *getIndex(size_t index) {
        return $self->indexes()->at(index);
    }
}
