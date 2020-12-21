<template>
  <div>
    <b-form @submit="onSubmit" @reset="onReset" v-if="show">
      <b-form-group id="input-group-1"
                    label="Фамилия:"
                    label-for="input-1">
        <b-form-input id="input-1"
                      v-model="form.surname"
                      placeholder="Введите фамилию"
                      required></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-2"
                    label="Имя:"
                    label-for="input-2">
        <b-form-input id="input-2"
                      v-model="form.name"
                      placeholder="Введите имя"
                      required></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-3"
                    label="Номер телефона:"
                    label-for="input-3">
        <b-form-input id="input-3"
                      v-model="form.phoneNumber"
                      placeholder="Введите номер телефона"
                      required></b-form-input>
      </b-form-group>

      <b-button type="submit" variant="primary">Добавить</b-button>
      <b-button type="reset" variant="danger">Очистить</b-button>
    </b-form>
  </div>

</template>

<script>
  export default {
    name: 'InputForm',

    props: {
      msg: String
    },

    data() {
      return {
        form: {
          surname: '',
          name: '',
          phoneNumber: ''
        },

        show: true
      }
    },

    methods: {
      onSubmit(event) {
        event.preventDefault();
        alert(JSON.stringify(this.form));
      },

      onReset(event) {
        event.preventDefault()
        // Reset our form values
        this.form.surname = '';
        this.form.name = '';
        this.form.phoneNumber = '';

        // Trick to reset/clear native browser form validation state
        this.show = false;
        this.$nextTick(() => {
          this.show = true
        });
      }
    }
  }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style>
</style>
