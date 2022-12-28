module Fable.Builders.DndKit.Sortable

open Browser.Types
open Fable.Builders.DndKit.Types
open Fable.Core

type UseSortableArguments =
    { id: string
      data: Data
      disabled: bool
      attributes: {| role: string
                     roleDescription: string
                     tabIndex: float |} option
      resizeObserverConfig: ResizeObserverConfig option
      animateLayoutChanges: AnimateLayoutChanges option
      getNewIndex: NewIndexGetter option
      strategy: SortingStrategy option
      transition: SortableTransition option }

    static member empty =
        { id = ""
          data = null
          disabled = false
          attributes = None
          resizeObserverConfig = None
          animateLayoutChanges = None
          getNewIndex = None
          strategy = None
          transition = None }

type UseSortableResult =
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
                    scaleY: float |} option
      transition: obj }

[<Import("useSortable", "@dnd-kit/sortable")>]
let useSortableConfig (config: UseSortableArguments) : UseSortableResult = jsNative

let useSortable id =
    useSortableConfig { UseSortableArguments.empty with id = id }
