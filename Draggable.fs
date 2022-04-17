module Fable.Builders.DndKit.Draggable

open Browser.Types
open Fable.Builders.DndKit.Types
open Fable.Core
open Fable.React

type UseDraggableArguments =
    { id: string
      data: Data
      disabled: bool
      attributes: {| role: string
                     roleDescription: string
                     tabIndex: float |} option }

    static member empty =
        { id = ""
          data = null
          disabled = false
          attributes = None }

type UseDraggableResult =
    { active: {| id: UniqueIdentifier
                 node: obj
                 rect: ViewRect |} option
      attributes: {| role: string; tabIndex: float |}
      isDragging: bool
      listeners: obj
      node: obj
      over: {| id: UniqueIdentifier |} option
      setNodeRef: HTMLElement -> unit
      transform: {| x: float
                    y: float
                    scaleX: float
                    scaleY: float |} option }

[<Import("useDraggable", "@dnd-kit/core")>]
let useDraggableConfig (config: UseDraggableArguments) : UseDraggableResult = jsNative

let useDraggable id =
    useDraggableConfig { UseDraggableArguments.empty with id = id }
