# - Try to find Libhts
# Once done this will define
#  LIBHTS_FOUND - System has Libhts
#  LIBHTS_INCLUDE_DIRS - The Libhts include directories
#  LIBHTS_LIBRARIES - The libraries needed to use Libhts
#  LIBHTS_DEFINITIONS - Compiler switches required for using Libhts

find_package(PkgConfig)
pkg_check_modules(PC_LIBHTS QUIET htslib)
set(LIBHTS_DEFINITIONS ${PC_LIBHTS_CFLAGS_OTHER})

find_path(LIBHTS_INCLUDE_DIR libxml/xpath.h
        HINTS ${PC_LIBHTS_INCLUDEDIR} ${PC_LIBHTS_INCLUDE_DIRS}
        PATH_SUFFIXES libxml2 )

find_library(LIBHTS_LIBRARY NAMES xml2 libxml2
        HINTS ${PC_LIBHTS_LIBDIR} ${PC_LIBHTS_LIBRARY_DIRS} )

include(FindPackageHandleStandardArgs)
# handle the QUIETLY and REQUIRED arguments and set LIBHTS_FOUND to TRUE
# if all listed variables are TRUE
find_package_handle_standard_args(Libhts  DEFAULT_MSG
        LIBHTS_LIBRARY LIBHTS_INCLUDE_DIR)

mark_as_advanced(LIBHTS_INCLUDE_DIR LIBHTS_LIBRARY )

set(LIBHTS_LIBRARIES ${LIBHTS_LIBRARY} )
set(LIBHTS_INCLUDE_DIRS ${LIBHTS_INCLUDE_DIR} )
