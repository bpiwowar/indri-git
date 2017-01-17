include(UseSWIG)
find_package(SWIG REQUIRED)

FIND_PACKAGE(PythonLibs 3 REQUIRED)
message(STATUS "Python version ${PYTHONLIBS_VERSION_STRING}")

set(CMAKE_SWIG_OUTDIR "${CMAKE_CURRENT_BINARY_DIR}/python")
if(NOT PYTHON_INSTALL_LOCATION)
    set(PYTHON_INSTALL_LOCATION ${CMAKE_INSTALL_PREFIX}/python)
else()
    set(PYTHON_INSTALL_LOCATION ${PYTHON_INSTALL_LOCATION})
endif()
file(MAKE_DIRECTORY ${CMAKE_SWIG_OUTDIR})
message(STATUS "Python library will be built in ${CMAKE_SWIG_OUTDIR} and installed in ${PYTHON_INSTALL_LOCATION}")



set(CMAKE_SWIG_FLAGS -builtin -c++)

# Build module indri

set_source_files_properties(src/indri.i PROPERTIES CPLUSPLUS ON)

set(SWIG_MODULE_indri_python_EXTRA_DEPS src/greedy_vector.i ${PUBLIC_HEADERS_ABSOLUTE})
include_directories(../include ../contrib/lemur/include ../contrib/xpdf/include ${LIBHTS_INCLUDE_DIRS} ${PYTHON_INCLUDE_PATH})
swig_add_module(indri_python python src/indri.i)

set_target_properties("_indri_python" PROPERTIES
        LIBRARY_OUTPUT_DIRECTORY "${CMAKE_SWIG_OUTDIR}"
        LIBRARY_OUTPUT_NAME "_indri"
        MACOSX_RPATH TRUE
        INSTALL_RPATH "@loader_path"
        CXX_STANDARD 11
        EXCLUDE_FROM_ALL true
)
swig_link_libraries("indri_python" ${PYTHON_LIBRARIES} indri ${ZLIB_LIBRARIES})

install(FILES "${CMAKE_SWIG_OUTDIR}/indri.py" COMPONENT python EXCLUDE_FROM_ALL DESTINATION ${PYTHON_INSTALL_LOCATION})
install(TARGETS "_indri_python" COMPONENT python EXCLUDE_FROM_ALL DESTINATION ${PYTHON_INSTALL_LOCATION})

# Add install target
add_custom_target(install-python
  DEPENDS _indri_python
  COMMAND "${CMAKE_COMMAND}" -DCMAKE_INSTALL_COMPONENT=python -P "${CMAKE_BINARY_DIR}/cmake_install.cmake"
)
