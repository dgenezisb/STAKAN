const vue = {
	data(){
		return{
			
			inpPlc: 'vvodiii',
			inpVal:'',
			notes: ['1stZam','2ndZam']
		}
	},
	methods:{
		
		addNote(){
			if(this.inpVal !== ''){
			this.notes.push(this.inpVal)
			this.inpVal = ''
			}
			
		},
		delNote(index){
			this.notes.splice(index, 1)
		},
		toUpCase(item){
			return item.toUpperCase()
		},
		
	},
	computed:{
		doubleCountComp(){
			
			return this.notes.length * 2
		},
	},
	watch: {
		inpVal(value){
			console.log('ibpVal change',value)
		}
	},
}

Vue.createApp(vue).mount('#myapp')