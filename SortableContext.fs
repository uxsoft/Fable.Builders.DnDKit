namespace Fable.Builders.DndKit

open Fable.Builders.Common
open Fable.Core.JsInterop
open Fable.Builders.DndKit.Types

module SortableContext =
    
    type SortableContextBuilder() =
        inherit ReactBuilder(import "SortableContext" "@dnd-kit/sortable")
          
        [<CustomOperation("items")>] member inline _.items (x: DSLElement, v: string array) = x.attr "items" v
        [<CustomOperation("strategy")>] member inline _.strategy (x: DSLElement, v: SortingStrategy) = x.attr "strategy" v
        [<CustomOperation("id")>] member inline _.id (x: DSLElement, v: string) = x.attr "id" v
