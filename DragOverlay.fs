namespace Fable.Builders.DndKit

open Fable.Builders.Common
open Fable.Core.JsInterop
open Fable.Builders.DndKit.Types

module DragOverlay =
    
    type DragOverlayBuilder() =
        inherit ReactBuilder(import "DragOverlay" "@dnd-kit/core")
          
        [<CustomOperation("adjustScale")>] member inline _.adjustScale (x: DSLElement, v: bool) = x.attr "adjustScale" v
        [<CustomOperation("dropAnimation")>] member inline _.dropAnimation (x: DSLElement, v: DropAnimation) = x.attr "dropAnimation" v
        [<CustomOperation("transition")>] member inline _.transition (x: DSLElement, v: string) = x.attr "transition" v
        [<CustomOperation("modifiers")>] member inline _.modifiers (x: DSLElement, v: Modifier array) = x.attr "modifiers" v
        [<CustomOperation("wrapperElement")>] member inline _.wrapperElement (x: DSLElement, v: 't) = x.attr "wrapperElement" v
        [<CustomOperation("zIndex")>] member inline _.zIndex (x: DSLElement, v: float) = x.attr "zIndex" v