namespace indri {
namespace utility {

template<typename _Type, int _Count = 16>
class greedy_vector {
    public:
    _Type const &at(size_t);
    size_t size() const;
};

// Specialize for strings to handle proper argument conversion
template<int _Count = 16>
class greedy_vector<char *, _Count> {
    public:
    char * const at(size_t);
    size_t size() const;
};


}}

/*%typemap(out) char *const &indri::utility::greedy_vector< char * >::at {
    $result = yes;
}

%apply indri::utility::greedy_vector< char * > { StringVector }
*/

%template(StringVector) indri::utility::greedy_vector< char * >;
%template(TermExtentVector) indri::utility::greedy_vector< indri::parse::TermExtent >;
%template(TermIdVector) indri::utility::greedy_vector< lemur::api::TERMID_T >;
