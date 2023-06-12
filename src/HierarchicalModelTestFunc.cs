using Elements;
using Elements.Geometry;
using System.Collections.Generic;

namespace HierarchicalModelTestFunc
{
    public static class HierarchicalModelTestFunc
    {
        public static HierarchicalModelTestFuncOutputs Execute(Dictionary<string, Model> inputModels, HierarchicalModelTestFuncInputs input)
        {
            Console.WriteLine("SingleFile: '" + input.SingleFile.Key + "'=>'" + input.SingleFile.LocalFilePath + "'");
            foreach (var file in input.ListOfFiles)
            {
                Console.WriteLine("ListOfFiles: '" + file.Key + "'=>'" + file.LocalFilePath + "'");
            }
            Console.WriteLine("Hierarchical: '" + input.Hierarchical.NestedInputData.Key + "'=>'" + input.Hierarchical.NestedInputData.LocalFilePath + "'");
            return new HierarchicalModelTestFuncOutputs("You will have to deploy and run this function many times.");
        }
    }
}