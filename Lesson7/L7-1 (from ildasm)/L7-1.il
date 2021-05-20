
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0




// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 5:0:0:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 5:0:0:0
}
.assembly 'L7-1'
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 35 2E 30 01 00 54 0E 14   // ersion=v5.0..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 00 )                                  // Name.
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 04 4C 37 2D 31 00 00 )                      // ...L7-1..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 04 4C 37 2D 31 00 00 )                      // ...L7-1..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 04 4C 37 2D 31 00 00 )                      // ...L7-1..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module 'L7-1.dll'
// MVID: {7508F3E9-5F4C-4DC2-8CEC-EB0E47151399}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x090B0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit L7_1.Program
       extends [System.Runtime]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Размер кода:       70 (0x46)
    .maxstack  3
    .locals init (float32 V_0,
             float32 V_1)
    IL_0000:  nop
    IL_0001:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    3F 04 35 04 40 04 32 04 3E 04 35 04 20 00 47 04   // ?.5.@.2.>.5. .G.
                                    38 04 41 04 3B 04 3E 04 3A 00 )                   // 8.A.;.>.:.
    IL_0006:  call       void [System.Console]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  call       string [System.Console]System.Console::ReadLine()
    IL_0011:  call       float32 [System.Runtime]System.Convert::ToSingle(string)
    IL_0016:  stloc.0
    IL_0017:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    32 04 42 04 3E 04 40 04 3E 04 35 04 20 00 47 04   // 2.B.>.@.>.5. .G.
                                    38 04 41 04 3B 04 3E 04 3A 00 )                   // 8.A.;.>.:.
    IL_001c:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0021:  nop
    IL_0022:  call       string [System.Console]System.Console::ReadLine()
    IL_0027:  call       float32 [System.Runtime]System.Convert::ToSingle(string)
    IL_002c:  stloc.1
    IL_002d:  ldstr      bytearray (1F 04 40 04 3E 04 38 04 37 04 32 04 35 04 34 04   // ..@.>.8.7.2.5.4.
                                    35 04 3D 04 38 04 35 04 20 00 47 04 38 04 41 04   // 5.=.8.5. .G.8.A.
                                    35 04 3B 04 20 00 40 04 30 04 32 04 3D 04 3E 04   // 5.;. .@.0.2.=.>.
                                    3A 00 20 00 7B 00 30 00 7D 00 )                   // :. .{.0.}.
    IL_0032:  ldloc.0
    IL_0033:  ldloc.1
    IL_0034:  mul
    IL_0035:  box        [System.Runtime]System.Single
    IL_003a:  call       string [System.Runtime]System.String::Format(string,
                                                                      object)
    IL_003f:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0044:  nop
    IL_0045:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class L7_1.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 C:\Users\shaba\Documents\Programming\Lesson7\L7-1 (from ildasm)\L7-1 (from ildasm).res
