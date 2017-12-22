# See https://github.com/mesonbuild/meson/issues/341

swig = find_program('swig')

swig_includes = ['-I@CURRENT_SOURCE_DIR@/src',  '-I@CURRENT_SOURCE_DIR@/../include', '-I@CURRENT_SOURCE_DIR@/../contrib/xpdf/include', '-I@CURRENT_SOURCE_DIR@/../contrib/lemur/include', '-I@CURRENT_SOURCE_DIR@/../contrib/lemur/include/lemur']

swig_gen = generator(
    swig,
    output: ['@BASENAME@.cxx'],
    arguments: ['-c++', '-builtin', '-python', '-py3', '-o', './@OUTPUT@',
                '-outdir', '@BUILD_DIR@/..', 
                '-MD', '-MF', '@DEPFILE@'] 
                + swig_includes + ['@INPUT@'],
    depfile: '@BASENAME@.d'
)

wrapper_deps = [
    dependency('python3')
]


cpp_source = swig_gen.process('src/indri.i')
shared_library(
    '_indri',
    cpp_source,
    link_with: indri_lib,
    include_directories: incdirs,
    dependencies: wrapper_deps,
    install: true,
    install_dir: 'lib/',
    name_suffix: 'so',
    name_prefix: ''
)
