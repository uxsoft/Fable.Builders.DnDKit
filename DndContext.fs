namespace Fable.Builders.DndKit

open Fable.Builders.Common
open Fable.Core.JsInterop
open Fable.Builders.DndKit.Types
open Feliz

module DndContext =
    
    type DndContextBuilder() =
        inherit ReactBuilder(import "DndContext" "@dnd-kit/core")
        
        [<CustomOperation("announcements")>] member inline _.announcements (x: DSLElement, v: Announcements) = x.attr "announcements" v
        [<CustomOperation("autoScroll")>] member inline _.autoScroll (x: DSLElement, v: bool) = x.attr "autoScroll" v
        [<CustomOperation("cancelDrop")>] member inline _.cancelDrop (x: DSLElement, v: CancelDrop) = x.attr "cancelDrop" v
        [<CustomOperation("children")>] member inline _.children (x: DSLElement, v: ReactElement) = x.attr "children" v
        [<CustomOperation("collisionDetection")>] member inline _.collisionDetection (x: DSLElement, v: CollisionDetection) = x.attr "collisionDetection" v
        [<CustomOperation("measuring")>] member inline _.measuring (x: DSLElement, v: MeasuringConfiguration) = x.attr "measuring" v
        [<CustomOperation("modifiers")>] member inline _.modifiers (x: DSLElement, v: Modifier array) = x.attr "modifiers" v
        [<CustomOperation("screenReaderInstructions")>] member inline _.screenReaderInstructions (x: DSLElement, v: ScreenReaderInstructions) = x.attr "screenReaderInstructions" v
        [<CustomOperation("sensors")>] member inline _.sensors (x: DSLElement, v: SensorDescriptor<'T>) = x.attr "sensors" v
        [<CustomOperation("onDragStart")>] member inline _.onDragStart (x: DSLElement, v: DragStartEvent -> unit) = x.attr "onDragStart" v
        [<CustomOperation("onDragMove")>] member inline _.onDragMove (x: DSLElement, v: DragMoveEvent -> unit) = x.attr "onDragMove" v
        [<CustomOperation("onDragOver")>] member inline _.onDragOver (x: DSLElement, v: DragOverEvent -> unit) = x.attr "onDragOver" v
        [<CustomOperation("onDragEnd")>] member inline _.onDragEnd (x: DSLElement, v: DragEndEvent -> unit) = x.attr "onDragEnd" v
        [<CustomOperation("onDragCancel")>] member inline _.onDragCancel (x: DSLElement, v: unit -> unit) = x.attr "onDragCancel" v
