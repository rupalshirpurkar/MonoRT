prefix=/usr/local
exec_prefix=${prefix}
sysconfdir=${prefix}/etc
mono_libdir=${exec_prefix}/lib
MCS_FLAGS = $(PLATFORM_DEBUG_FLAGS)
IL_FLAGS = /debug
RUNTIME = /home/dev/Desktop/mono-rt/runtime/mono-wrapper
ILDISASM = /home/dev/Desktop/mono-rt/runtime/monodis-wrapper
INSTALL = /usr/bin/install -c
MONO_VERSION = 2.6.1.0
