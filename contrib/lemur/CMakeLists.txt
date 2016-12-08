add_library(lemur STATIC
        include/lemur/common_headers.hpp
        include/lemur/Exception.hpp
        include/lemur/fileio.h
        include/lemur/HarvestSortMerge.hpp
        include/lemur/IndexTypes.hpp
        include/lemur/integer_types.h
        include/lemur/InvFPTypes.hpp
        include/lemur/key_consts.h
        include/lemur/keydef.h
        include/lemur/keyerr.h
        include/lemur/keyfile.h
        include/lemur/Keyfile.hpp
        include/lemur/keyprint.h
        include/lemur/keyref.h
        include/lemur/kf6ref.h
        include/lemur/lemur-compat.hpp
        include/lemur/lemur-platform.h
        include/lemur/RVLCompress.hpp
        include/lemur/SHA1.hpp
        include/lemur/SortMergeTextFiles.hpp
        include/lemur/string-set.h
        src/fileio.c
        src/fn_f.c
        src/HarvestSortMerge.cpp
        src/Keyfile.cpp
        src/keyfilecode.c
        src/keyfilecompress.c
        src/keyprint.c
        src/lemur-compat.cpp
        src/RVLCompress.cpp
        src/SHA1.cpp
        src/SortMergeTextFiles.cpp
        src/string-set.c)

target_include_directories(lemur PUBLIC include/lemur)