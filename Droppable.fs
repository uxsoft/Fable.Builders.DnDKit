module Fable.Builders.DndKit.Droppable

open Browser.Types
open Fable.Builders.DndKit.Types
open Fable.Core
open Fable.React

type UseDroppableArguments =
    { id: string
      disabled: bool
      data: Data
      resizeObserverConfig: ResizeObserverConfig option }

    static member empty =
        { id = ""
          disabled = false
          data = null
          resizeObserverConfig = None }

type UseDroppableResult =
    { rect: obj
      isOver: bool
      node: obj
      over: {| id: string |}
      setNodeRef: HTMLElement -> unit }

[<Import("useDroppable", "@dnd-kit/core")>]
let useDroppableConfig (config: UseDroppableArguments) : UseDroppableResult = jsNative

let useDroppable id =
    useDroppableConfig { UseDroppableArguments.empty with id = id }
