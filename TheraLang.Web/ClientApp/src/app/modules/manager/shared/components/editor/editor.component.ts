import { AfterViewInit, Component, ElementRef, forwardRef, OnInit, ViewEncapsulation } from '@angular/core'
import { ControlValueAccessor, NG_VALUE_ACCESSOR } from '@angular/forms'

declare var require: any

const Quill = require('quill')

@Component({
  selector: 'app-quill',
  template: ``,
  providers: [{
    provide: NG_VALUE_ACCESSOR,
    useExisting: forwardRef(() => EditorComponent),
    multi: true,
  }],
  encapsulation: ViewEncapsulation.None
})
export class EditorComponent implements AfterViewInit, OnInit, ControlValueAccessor {
  quillOptions = {
    modules: {
      toolbar:
      {
        container: [
          ['bold', 'italic', 'underline'],
          ['blockquote'],
          [{ 'list': 'ordered' }, { 'list': 'bullet' }],
          [{ 'script': 'sub' }, { 'script': 'super' }],
          [{ 'indent': '-1' }, { 'indent': '+1' }],
          [{ 'size': ['small', false, 'large', 'huge'] }],
          [{ 'header': [1, 2, 3, 4, 5, 6, false] }],
          ['link', 'image', 'video'],
          [{ 'color': [] }],
          [{ 'font': ['sans-serif'] }],
          [{ 'align': [] }],
          ['clean']
        ]
      }
    },
    theme: 'snow'
  }

  quill: any

  content: string

  private propagateChange = (_: any) => { }

  constructor(private elementRef: ElementRef) { }

  ngOnInit() { }

  ngAfterViewInit() {
    this.quill = new Quill(this.elementRef.nativeElement, this.quillOptions)

    if (this.content) this.quill.pasteHTML(this.content)

    this.quill.on('text-change', () => {
      const html = this.elementRef.nativeElement.children[0].innerHTML
      this.propagateChange(html)
    })
  }

  writeValue(value) {
    this.content = value

    if (this.quill) this.quill.pasteHTML(value)
  }

  public registerOnChange(fn: any) {
    this.propagateChange = fn
  }

  public registerOnTouched() { }
}