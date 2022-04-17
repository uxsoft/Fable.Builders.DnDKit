module Fable.Builders.DndKit.Types

open Browser.Types

type SyntheticEvent = Browser.Types.Event

type ClientRect =
    { width: float
      height: float
      top: float
      left: float
      right: float
      bottom: float }

type UniqueIdentifier = string
type Data = obj
type DataRef = obj

type DraggableNode =
    { id: UniqueIdentifier
      key: UniqueIdentifier
      node: obj
      data: DataRef }

type DraggableElement =
    { node: DraggableNode
      id: UniqueIdentifier
      index: float
      collection: string
      disabled: bool }

type DroppableContainer =
    { id: UniqueIdentifier
      key: UniqueIdentifier
      data: DataRef
      disabled: bool
      node: obj
      rect: obj }

type Active =
    { id: UniqueIdentifier
      data: DataRef
      rect: obj }

type Over =
    { id: UniqueIdentifier
      rect: ClientRect
      disabled: bool
      data: DataRef }

type Collision = { id: UniqueIdentifier; data: obj }

type DraggableNodes = obj

type DroppableContainers = DroppableContainersMap

type RectMap = Map<UniqueIdentifier, ClientRect>

type Coordinates = { x: float; y: float }

type State =
    { droppable: {| containers: DroppableContainers |}
      draggable: {| active: UniqueIdentifier option
                    initialCoordinates: Coordinates
                    nodes: DraggableNodes
                    translate: Coordinates |} }

type PublicContextDescriptor =
    { activatorEvent: Event option
      active: Active option
      activeNode: HTMLElement option
      activeNodeRect: ClientRect option
      collisions: Collision [] option
      containerNodeRect: ClientRect option
      draggableNodes: DraggableNodes
      droppableContainers: DroppableContainers
      droppableRects: RectMap
      over: Over option
      dragOverlay: {| nodeRef: obj
                      rect: ClientRect option
                      setRef: HTMLElement option -> unit |}
      scrollableAncestors: Element []
      scrollableAncestorRects: ClientRect []
      measureDroppableContainers: UniqueIdentifier array -> unit
      measuringScheduled: bool
      windowRect: ClientRect option }

type SyntheticListener =
    { eventName: string
      handler: SyntheticEvent * UniqueIdentifier -> unit }

type InternalContextDescriptor =
    { activatorEvent: Event option
      activators: SyntheticListener array
      active: Active option
      activeNodeRect: ClientRect option
      ariaDescribedById: {| draggable: UniqueIdentifier |}
      dispatch: obj
      draggableNodes: DraggableNodes
      over: Over option
      measureDroppableContainers: UniqueIdentifier array -> unit }

type Translate = Coordinates

type DragEvent =
    { active: Active
      collisions: Collision array option
      delta: Translate
      over: Over option }

type DragStartEvent = DragEvent
type DragMoveEvent = DragEvent
type DragOverEvent = DragMoveEvent
type DragEndEvent = DragEvent
type DragCancelEvent = DragEndEvent

type Measuring = { measure: HTMLElement -> ClientRect }

type MeasuringConfiguration =
    { draggable: Measuring
      droppable: Measuring
      dragOverlay: Measuring }

type CancelDropArguments = DragEndEvent

type CancelDrop = CancelDropArguments -> bool

type Announcements =
    { onDragStart: UniqueIdentifier -> string
      onDragMove: UniqueIdentifier * UniqueIdentifier -> string
      onDragOver: UniqueIdentifier * UniqueIdentifier -> string
      onDragEnd: UniqueIdentifier * UniqueIdentifier -> string
      onDragCancel: UniqueIdentifier -> string }

type ScreenReaderInstructions = { draggable: string }

type CollisionDetectionArgs =
    { active: Active
      collisionRect: ClientRect
      droppableRects: RectMap
      droppableContainers: DroppableContainer array
      pointerCoordinates: Coordinates option }

type CollisionDetection = CollisionDetectionArgs -> Collision array

type LayoutRect =
    { width: float
      height: float
      offsetLeft: float
      offsetTop: float }

type ViewRect =
    { width: float
      height: float
      offsetLeft: float
      offsetTop: float
      top: float
      left: float
      right: float
      bottom: float }

type Transform =
    { x: float
      y: float
      scaleX: float
      scaleY: float }

type ModifierArgs =
    { transform: Transform
      activeNodeRect: ViewRect option
      draggingNodeRect: ViewRect option
      containerNodeRect: ViewRect option
      overlayNodeRect: ViewRect option
      scrollableAncestors: Element array
      scrollableAncestorRects: ViewRect array
      windowRect: ClientRect option }

type Modifier = ModifierArgs -> Transform

type Activator<'T> =
    { eventName: string
      handler: SyntheticEvent * 'T -> bool }

type Sensor<'T> =
    { autoScrollEnabled: bool
      activators: Activator<'T> array }

type SensorDescriptor<'T> = { sensor: Sensor<'T>; options: 'T }

type DropAnimation =
    { duration: float
      easing: string
      dragSourceOpacity: float }

type ResizeObserverConfig =
    { disabled: bool
      updateMeasurementsFor: UniqueIdentifier array
      timeout: float }

type SortingStrategyArgs =
    { activeNodeRect: ClientRect option
      activeIndex: float
      index: float
      rects: ClientRect array
      overIndex: float }

type SortingStrategy = SortingStrategyArgs -> Transform option

type SortableTransition =
    { property: string
      easing: string
      duration: float }

type AnimateLayoutChangesArgs =
    { active: Active option
      containerId: UniqueIdentifier
      isDragging: bool
      isSorting: bool
      id: UniqueIdentifier
      index: float
      items: UniqueIdentifier []
      previousItems: UniqueIdentifier []
      previousContainerId: UniqueIdentifier
      newIndex: float
      transition: SortableTransition option
      wasDragging: bool }

type AnimateLayoutChanges = AnimateLayoutChangesArgs -> bool

type NewIndexGetterArgs =
    { id: UniqueIdentifier
      items: UniqueIdentifier []
      activeIndex: float
      overIndex: float }

type NewIndexGetter = NewIndexGetterArgs -> float
