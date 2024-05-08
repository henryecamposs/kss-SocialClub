using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Threading;

namespace KSS_DataObjects.kss_SocialClub.Capas.Entidades.Base
{
    public static partial class clsUtil_Class
    {


        /// <summary>
        /// Validar una entidad si una propiedad es requerida
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns>True si cumple requisitos</returns>
        /// <example>
        /// MyClass cc = new MyClass()
        /// {
        /// cost = 5
        /// };
        /// Validate(cc); // false, id required
        /// </example>
        public static bool ValidateEntity<T>(T obj, out string errMsj)
        {
            var properties = obj.GetType().GetProperties().ToList();
            string msj = "";
            foreach (var prop in properties)
            {
                if (prop.IsDefined(typeof(RequiredAttribute)))
                {
                    object value = prop.GetValue(obj);
                    if (value == null)
                    {
                        msj = "";
                    }
                }

                if (prop.IsDefined(typeof(ContainsNumericAttribute)))
                {
                    msj = "";

                }

                //if (prop.IsDefined(typeof(System.ComponentModel.DataAnnotations.MinLengthAttribute)))
                //{
                //    msj = "";

                //}

                //if (prop.IsDefined(typeof(System.ComponentModel.DataAnnotations.MaxLengthAttribute)))
                //{
                //    msj = "";

                //}

            }
            errMsj = msj;

            return false; // dummy value now
        }


    }

    class CreateClass1
    {
        public Type[] firstNameFieldOrderAttributeParams { get; private set; }

        ////void createOnlyAttribute()
        ////{
        ////    //get the builder to that field
        ////    FieldBuilder firstNameField =

        ////    //create the attribute [FieldOrder(0)]
        ////    Type[] firstNameFieldOrderAttributeParams = new Type[] { typeof(int) };
        ////    ConstructorInfo firstNameFieldOrderAttrInfo = typeof(FieldOrderAttribute).GetConstructor(firstNameFieldOrderAttributeParams);
        ////    CustomAttributeBuilder firstNameFieldOrderAttributeBuilder = new CustomAttributeBuilder(firstNameFieldOrderAttrInfo, new object[] { 0 });
        ////    firstNameField.SetCustomAttribute(firstNameFieldOrderAttributeBuilder);
        ////}
        void create()
        {
            //create the builder
            AssemblyName assembly = new AssemblyName("FileHelpersTests");
            AppDomain appDomain = System.Threading.Thread.GetDomain();
            AssemblyBuilder assemblyBuilder = appDomain.DefineDynamicAssembly(assembly, AssemblyBuilderAccess.Run);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(assembly.Name);

            //create the class
            TypeBuilder typeBuilder = moduleBuilder.DefineType("Person", TypeAttributes.Public | TypeAttributes.AutoClass | TypeAttributes.AnsiClass |
                                                                TypeAttributes.BeforeFieldInit, typeof(System.Object));

            //create the Delimiter attribute
            Type[] delimiterAttributeParams = new Type[] { typeof(string) };
            ConstructorInfo delimiterAttrInfo = typeof(DelimitedRecordAttribute).GetConstructor(delimiterAttributeParams);
            CustomAttributeBuilder delimiterAttributeBuilder = new CustomAttributeBuilder(delimiterAttrInfo, new object[] { ";" });
            typeBuilder.SetCustomAttribute(delimiterAttributeBuilder);

            //create the firstName field
            FieldBuilder firstNameField = typeBuilder.DefineField("firstName", typeof(System.String), FieldAttributes.Private);

            //create the firstName attribute [FieldOrder(0)]
            Type[] firstNameFieldOrderAttributeParams = new Type[] { typeof(int) };
            ConstructorInfo firstNameFieldOrderAttrInfo = typeof(FieldOrderAttribute).GetConstructor(firstNameFieldOrderAttributeParams);
            CustomAttributeBuilder firstNameFieldOrderAttributeBuilder = new CustomAttributeBuilder(firstNameFieldOrderAttrInfo, new object[] { 0 });
            firstNameField.SetCustomAttribute(firstNameFieldOrderAttributeBuilder);

            //create the FirstName property
            PropertyBuilder firstNameProperty = typeBuilder.DefineProperty("FirstName", PropertyAttributes.HasDefault, typeof(System.String), null);

            //create the FirstName Getter
            MethodBuilder firstNamePropertyGetter = typeBuilder.DefineMethod("get_FirstName", MethodAttributes.Public | MethodAttributes.SpecialName |
                                                                              MethodAttributes.HideBySig, typeof(System.String), Type.EmptyTypes);
            ILGenerator firstNamePropertyGetterIL = firstNamePropertyGetter.GetILGenerator();
            firstNamePropertyGetterIL.Emit(OpCodes.Ldarg_0);
            firstNamePropertyGetterIL.Emit(OpCodes.Ldfld, firstNameField);
            firstNamePropertyGetterIL.Emit(OpCodes.Ret);

            //create the FirstName Setter
            MethodBuilder firstNamePropertySetter = typeBuilder.DefineMethod("set_FirstName", MethodAttributes.Public | MethodAttributes.SpecialName |
                                                                MethodAttributes.HideBySig, null, new Type[] { typeof(System.String) });
            ILGenerator firstNamePropertySetterIL = firstNamePropertySetter.GetILGenerator();
            firstNamePropertySetterIL.Emit(OpCodes.Ldarg_0);
            firstNamePropertySetterIL.Emit(OpCodes.Ldarg_1);
            firstNamePropertySetterIL.Emit(OpCodes.Stfld, firstNameField);
            firstNamePropertySetterIL.Emit(OpCodes.Ret);

            //assign getter and setter
            firstNameProperty.SetGetMethod(firstNamePropertyGetter);
            firstNameProperty.SetSetMethod(firstNamePropertySetter);


            //create the lastName field
            FieldBuilder lastNameField = typeBuilder.DefineField("lastName", typeof(System.String), FieldAttributes.Private);

            //create the lastName attribute [FieldOrder(1)]
            Type[] lastNameFieldOrderAttributeParams = new Type[] { typeof(int) };
            ConstructorInfo lastNameFieldOrderAttrInfo = typeof(FieldOrderAttribute).GetConstructor(lastNameFieldOrderAttributeParams);
            CustomAttributeBuilder lastNameFieldOrderAttributeBuilder = new CustomAttributeBuilder(lastNameFieldOrderAttrInfo, new object[] { 1 });
            lastNameField.SetCustomAttribute(lastNameFieldOrderAttributeBuilder);

            //create the LastName property
            PropertyBuilder lastNameProperty = typeBuilder.DefineProperty("LastName", PropertyAttributes.HasDefault, typeof(System.String), null);

            //create the LastName Getter
            MethodBuilder lastNamePropertyGetter = typeBuilder.DefineMethod("get_LastName", MethodAttributes.Public | MethodAttributes.SpecialName |
                                                                              MethodAttributes.HideBySig, typeof(System.String), Type.EmptyTypes);
            ILGenerator lastNamePropertyGetterIL = lastNamePropertyGetter.GetILGenerator();
            lastNamePropertyGetterIL.Emit(OpCodes.Ldarg_0);
            lastNamePropertyGetterIL.Emit(OpCodes.Ldfld, lastNameField);
            lastNamePropertyGetterIL.Emit(OpCodes.Ret);

            //create the FirstName Setter
            MethodBuilder lastNamePropertySetter = typeBuilder.DefineMethod("set_FirstName", MethodAttributes.Public | MethodAttributes.SpecialName |
                                                                MethodAttributes.HideBySig, null, new Type[] { typeof(System.String) });
            ILGenerator lastNamePropertySetterIL = lastNamePropertySetter.GetILGenerator();
            lastNamePropertySetterIL.Emit(OpCodes.Ldarg_0);
            lastNamePropertySetterIL.Emit(OpCodes.Ldarg_1);
            lastNamePropertySetterIL.Emit(OpCodes.Stfld, lastNameField);
            lastNamePropertySetterIL.Emit(OpCodes.Ret);

            //assign getter and setter
            lastNameProperty.SetGetMethod(lastNamePropertyGetter);
            lastNameProperty.SetSetMethod(lastNamePropertySetter);

        }

        public partial class Person
        {
            private string firstName;

            private string lastName;

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }
        }
        private class DelimitedRecordAttribute
        {
        }

        private class FieldOrderAttribute
        {
        }
    }
    /// <summary>
    /// Ejemplo Add Atributos
    /// </summary>
    class CreateClass
    {
        //Stackoverflow
        //Add attribute on property of a runtime created type using reflection

        private TypeBuilder getTypeBuilder()
        {
            var typeSignature = "IDynamicFlattenedType";
            var an = new AssemblyName(typeSignature);

            AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(an, AssemblyBuilderAccess.Run);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("DynamicDomain");
            TypeBuilder tb = moduleBuilder.DefineType(typeSignature
                                , TypeAttributes.Public |
                                TypeAttributes.Interface |
                                TypeAttributes.Abstract |
                                TypeAttributes.AutoClass |
                                TypeAttributes.AnsiClass
                                , null);

            return tb;
        }

        private void createProperty(TypeBuilder tb, string propertyName, Type propertyType)
        {
            Type[] ctorParams = new Type[] { typeof(string) };
            ConstructorInfo classCtorInfo = typeof(StuckAttribute).GetConstructor(ctorParams);

            CustomAttributeBuilder myCABuilder2 = new CustomAttributeBuilder(
                                classCtorInfo,
                                new object[] { DateTime.Now.ToString() });

            PropertyBuilder propertyBuilder = tb.DefineProperty(propertyName, PropertyAttributes.HasDefault, propertyType, null);
            propertyBuilder.SetCustomAttribute(myCABuilder2);

            MethodBuilder getPropMthdBldr = tb.DefineMethod("get_" + propertyName,
                MethodAttributes.Public |
                MethodAttributes.Abstract |
                MethodAttributes.Virtual |
                MethodAttributes.HideBySig |
                MethodAttributes.NewSlot,
                CallingConventions.HasThis,
                propertyType,
                Type.EmptyTypes
            );
            getPropMthdBldr.SetImplementationFlags(MethodImplAttributes.Managed);

            MethodBuilder setPropMthdBldr =
                tb.DefineMethod("set_" + propertyName,
                    MethodAttributes.Public |
                    MethodAttributes.Abstract |
                    MethodAttributes.Virtual |
                    MethodAttributes.HideBySig |
                    MethodAttributes.NewSlot,
                    CallingConventions.HasThis,
                    null, new[] { propertyType });
            setPropMthdBldr.SetImplementationFlags(MethodImplAttributes.Managed);

            propertyBuilder.SetGetMethod(getPropMthdBldr);
            propertyBuilder.SetSetMethod(setPropMthdBldr);
        }

        private class StuckAttribute
        {
        }
        //public void test()
        //{
        //    Type flattenedType = Reflection.Classes.FlattenClassBuilder.flattenType<CreateClass>(this.classes);

        //    flattenedType.Should().NotBeNull();

        //    PropertyInfo[] properties = flattenedType.GetProperties();
        //    properties.Should().NotBeEmpty().And.HaveCount(4);

        //    IEnumerable<Attribute> attrs = properties[0].GetCustomAttributes();
        //    attrs.Should().NotBeEmpty();
        //    ///Asi
        //    PropertyInfo[] properties = flattenedType.GetProperties();
        //    properties.Should().NotBeEmpty().And.HaveCount(4);
        //    properties.Should().OnlyContain(p => p.GetCustomAttribute<Reflection.Classes.FieldPropertyOwnerAttribute>() != null);

        //}
    }
    // We will apply this custom attribute to our dynamic type.
    public class ClassCreatorAttribute : Attribute

    {
        private string creator;
        public string Creator
        {
            get
            {
                return creator;
            }
        }

        public ClassCreatorAttribute(string name)
        {
            this.creator = name;
        }

    }

    // We will apply this dynamic attribute to our dynamic method.
    public class DateLastUpdatedAttribute : Attribute

    {
        private string dateUpdated;
        public string DateUpdated
        {
            get
            {
                return dateUpdated;
            }
        }

        public DateLastUpdatedAttribute(string theDate)
        {
            this.dateUpdated = theDate;
        }

    }

    /// <summary>
    /// Prueba Craer metodos y clases
    /// </summary>
    class MethodBuilderCustomAttributesDemo

    {
        public static void Main()
        {

            Type myType = BuildTypeWithCustomAttributesOnMethod();

            object myInstance = Activator.CreateInstance(myType);

            object[] customAttrs = myType.GetCustomAttributes(true);

            Console.WriteLine("Custom Attributes for Type 'MyType':");

            object attrVal = null;

            foreach (object customAttr in customAttrs)
            {
                attrVal = typeof(ClassCreator).InvokeMember("Creator",
                               BindingFlags.GetProperty,
                               null, customAttr, new object[] { });
                Console.WriteLine("-- Attribute: [{0} = \"{1}\"]", customAttr, attrVal);
            }

            Console.WriteLine("Custom Attributes for Method 'HelloWorld()' in 'MyType':");

            customAttrs = myType.GetMember("HelloWorld")[0].GetCustomAttributes(true);

            foreach (object customAttr in customAttrs)
            {
                attrVal = typeof(DateLastUpdated).InvokeMember("DateUpdated",
                               BindingFlags.GetProperty,
                               null, customAttr, new object[] { });
                Console.WriteLine("-- Attribute: [{0} = \"{1}\"]", customAttr, attrVal);
            }

            Console.WriteLine("---");

            Console.WriteLine(myType.InvokeMember("HelloWorld",
                      BindingFlags.InvokeMethod,
                      null, myInstance, new object[] { }));


        }

        public static Type BuildTypeWithCustomAttributesOnMethod()
        {

            AppDomain currentDomain = Thread.GetDomain();

            AssemblyName myAsmName = new AssemblyName();
            myAsmName.Name = "MyAssembly";

            AssemblyBuilder myAsmBuilder = currentDomain.DefineDynamicAssembly(
                               myAsmName, AssemblyBuilderAccess.Run);

            ModuleBuilder myModBuilder = myAsmBuilder.DefineDynamicModule("MyModule");

            // First, we'll build a type with a custom attribute attached.

            TypeBuilder myTypeBuilder = myModBuilder.DefineType("MyType",
                                TypeAttributes.Public);

            Type[] ctorParams = new Type[] { typeof(string) };
            ConstructorInfo classCtorInfo = typeof(ClassCreator).GetConstructor(ctorParams);

            CustomAttributeBuilder myCABuilder = new CustomAttributeBuilder(
                                classCtorInfo,
                                new object[] { "Joe Programmer" });

            myTypeBuilder.SetCustomAttribute(myCABuilder);

            // Now, let's build a method and add a custom attribute to it.

            MethodBuilder myMethodBuilder = myTypeBuilder.DefineMethod("HelloWorld",
                            MethodAttributes.Public,
                            null,
                            new Type[] { });

            ctorParams = new Type[] { typeof(string) };
            classCtorInfo = typeof(DateLastUpdated).GetConstructor(ctorParams);

            CustomAttributeBuilder myCABuilder2 = new CustomAttributeBuilder(
                                classCtorInfo,
                                new object[] { DateTime.Now.ToString() });

            myMethodBuilder.SetCustomAttribute(myCABuilder2);

            ILGenerator myIL = myMethodBuilder.GetILGenerator();

            myIL.EmitWriteLine("Hello, world!");
            myIL.Emit(OpCodes.Ret);

            return myTypeBuilder.CreateType();

        }

        private class DateLastUpdated
        {
        }

        private class ClassCreator
        {
        }
    }

    internal class ContainsNumericAttribute : Attribute
    {
    }

}
